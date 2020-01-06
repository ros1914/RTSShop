using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RosShop.App.Models;

namespace RosShop.App.Controllers
{
	public class HomeController : Controller
	{
		private readonly IHostingEnvironment he;
		public HomeController(IHostingEnvironment e)
		{
			this.he = e;
		}
		public IActionResult Index()
		{
			if (User.IsInRole("Administrator"))
			{
				return RedirectToAction("AllProduct", "Admin", new { area = "Admin" });
			}
			return RedirectToAction("UsersAllProduct", "Users", new { area="Users"});
			//return View();
		}

		public IActionResult About()
		{
			
			ViewData["Message"] = "Your application description page.";

			return View();
		}

		[HttpPost]
		public IActionResult About(List<IFormFile> formFile)
		{
			var result = formFile;

			//var fileName = Path.Combine(he.WebRootPath, Path.GetFileName(formFile.FileName));
			//formFile.CopyTo(new FileStream(fileName,FileMode.Create));
			return View();
		}

		public IActionResult Contact()
		{
			ViewData["Message"] = "Your contact page.";

			return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
