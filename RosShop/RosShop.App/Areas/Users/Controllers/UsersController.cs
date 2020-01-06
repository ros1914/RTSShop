namespace RosShop.App.Areas.Users.Controllers
{

	using Microsoft.AspNetCore.Mvc;
	using RosShop.App.Areas.Admin.Models;
	using RosShop.App.Areas.Users.Models;
	using RosShop.Services;


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
				return View(nameof(UsersAllProduct));
			}

			return View(result);
		}


	}
}