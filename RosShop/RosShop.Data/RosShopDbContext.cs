using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RosShop.Data.Models;

namespace RosShop.Data
{
	public class RosShopDbContext : IdentityDbContext<User>
	{
		public DbSet<Product> Products { get; set; }

		public DbSet<Shipper> Shippers { get; set; }

		public DbSet<PaymentCard> PaymentCards { get; set; }

		public DbSet<ShopingCard> ShopingCards { get; set; }

		public DbSet<IpAdress> IpAdresses { get; set; }

		public DbSet<ProductShopingCard> ProductShopingCard { get; set; }

		public RosShopDbContext(DbContextOptions<RosShopDbContext> options)
			: base(options)
		{
		}

		protected override void OnModelCreating(ModelBuilder builder)
		{
			builder.Entity<ProductUser>()
				.HasKey(pu => new { pu.ProductId, pu.UserId });

			builder.Entity<ProductShopingCard>()
				.HasKey(psh => new { psh.ProductId, psh.ShopingCardId });

			builder.Entity<Product>()
				.HasMany(u => u.Users)
				.WithOne(p => p.Product)
				.HasForeignKey(p => p.ProductId);

			builder.Entity<User>()
				.HasMany(p => p.Products)
				.WithOne(u => u.User)
				.HasForeignKey(u => u.UserId);

			builder.Entity<User>()
				.HasMany(c => c.PaymentCards)
				.WithOne(p => p.User)
				.HasForeignKey(p => p.UserId);

			builder.Entity<User>()
				.HasMany(sh => sh.Shopingcard)
				.WithOne(u => u.User)
				.HasForeignKey(u => u.UserId);


			builder.Entity<Product>()
				.HasMany(sh => sh.ShopingCards)
				.WithOne(p => p.Product)
				.HasForeignKey(p => p.ProductId);

			builder.Entity<ShopingCard>()
				.HasMany(p => p.Product)
				.WithOne(sh => sh.ShopingCard)
				.HasForeignKey(sh => sh.ShopingCardId);

			base.OnModelCreating(builder);
		}
	}
}
