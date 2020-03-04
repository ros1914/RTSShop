using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RosShop.Data;
using RosShop.Data.Models;
using RosShop.App.Common;
using Microsoft.AspNetCore.Identity.UI.Services;
using RosShop.App.Areas.Identity.Services;
using RosShop.Services.Implementation;
using RosShop.Services;
using Stripe;
using RosShop.App.Data;

namespace RosShop.App
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			services.Configure<CookiePolicyOptions>(options =>
			{
				// This lambda determines whether user consent for non-essential cookies is needed for a given request.
				options.CheckConsentNeeded = context => true;
				options.MinimumSameSitePolicy = SameSiteMode.None;
			});

			services.AddDbContext<RosShopDbContext>(options =>
				options.UseSqlServer(
					Configuration.GetConnectionString("DefaultConnection")));

			services.AddIdentity<User, IdentityRole>()
				.AddEntityFrameworkStores<RosShopDbContext>()
				.AddDefaultTokenProviders()
				.AddDefaultUI();

			services.Configure<IdentityOptions>(options =>
			{
				options.Password.RequireDigit = false;
				options.Password.RequiredLength = 3;
				options.Password.RequireLowercase = false;
				options.Password.RequireNonAlphanumeric = false;
				options.Password.RequireUppercase = false;
			});

			services.AddAuthentication();

			
			services.AddTransient<IAdminServices , AdminServices>();
			services.AddTransient<IUserServices, UserServices>();
			services.AddTransient<IShopingCardService , ShopingCardService>();

			services.AddSingleton<IEmailSender, SendGridEmailSender>();
			services.Configure<SendGridOptions>(this.Configuration.GetSection("EmailSettings"));
			services.Configure<StripeSettings>(this.Configuration.GetSection("Stripe"));

			services.AddMvc(options =>
			{
				options.Filters.Add<AutoValidateAntiforgeryTokenAttribute>();
			})
			.SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
			
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IHostingEnvironment env)
		{

			StripeConfiguration.SetApiKey(this.Configuration.GetSection("Stripe")["SecretKey"]);

			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
				app.UseDatabaseErrorPage();
			}
			else
			{
				app.UseExceptionHandler("/Home/Error");
				app.UseHsts();
			}

			app.UseHttpsRedirection();
			app.UseStaticFiles();
			app.UseCookiePolicy();
			app.SeedDatabase();

			app.UseAuthentication();

			app.UseMvc(routes =>
			{

				routes.MapRoute(
				  name: "areas",
				  template: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
				);

				routes.MapRoute(
					name: "default",
					template: "{controller=Home}/{action=Index}/{id?}");
			});
		}
	}
}
