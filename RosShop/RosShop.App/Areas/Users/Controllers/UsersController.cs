namespace RosShop.App.Areas.Users.Controllers
{

	using Microsoft.AspNetCore.Mvc;
	using RosShop.App.Areas.Admin.Models;
	using RosShop.App.Areas.Users.Models;
	using RosShop.Services;
    using System;

    [Area("Users")]
	public class UsersController : Controller
	{
		private readonly IUserServices userServices;



		public UsersController(IUserServices userServices)
		{
			this.userServices = userServices;

		}

		[HttpGet]
		public IActionResult UsersAllProduct()
		{
			var result = new AllUsersProductViewModel()
			{
				All = this.userServices.AllProducts()
			};

			return View(result);
		}

		[HttpGet]
		public IActionResult Details(int id)
		{
			var result = new DetailsUsersProductViewModel()
			{
				DetailsProductModel = this.userServices.DetailsProduct(id)
			};

			if (result == null)
			{
				TempData["_Message"] = "The product is not find";
				return RedirectToAction(nameof(UsersAllProduct));
			}

			return View(result);
		}

		
		[HttpGet]
		public IActionResult SearchProduct(string searchString)
		{

			if (!String.IsNullOrEmpty(searchString) )
			{
				var result = new AllUsersProductViewModel()
				{
					All = this.userServices.SearchProducts(searchString)
				};

				if (result == null)
				{
					TempData["Error"] = "The product is not find";
					return RedirectToAction(nameof(UsersAllProduct));

				}
				return View("UsersAllProduct",result);
			}

			this.TempData["Error"] = " The search string is null or empty !!!!";
			return RedirectToAction(nameof(UsersAllProduct));

		}
	}
}