namespace RosShop.App.Areas.ShopingCard.Controllers
{
	using Microsoft.AspNetCore.Identity;
	using Microsoft.AspNetCore.Mvc;
	using RosShop.Data;
	using RosShop.Services;
	using RosShop.Data.Models;
	using RosShop.Services.Models.ShopingCard;
	using System.Linq;
    using RosShop.App.Areas.ShopingCard.Models.ShopingCard;
    using Stripe;
    using System.Collections.Generic;
    using RosShop.App.Areas.ShopingCard.Models;
    using RosShop.Services.Models.ShopingCard.Stripe;

    [Area("ShopingCard")]
	public class ShopingCardController : Controller
	{
		private readonly IShopingCardService shopinCardService;
		private readonly RosShopDbContext db;
		private readonly UserManager<User> userManager;


		public ShopingCardController(IShopingCardService shopinCardService, RosShopDbContext db, UserManager<User> userManager)
		{
			this.shopinCardService = shopinCardService;
			this.db = db;
			this.userManager = userManager;

		}

		[HttpGet]
		public IActionResult ShopingCard()
		{
			string userId = this.userManager.GetUserId(HttpContext.User);

			var shopingCardId = this.shopinCardService.FindShopigCardId(userId);
			if (shopingCardId == 0)
			{
				shopingCardId = this.shopinCardService.CreateShopingCard(userId);
			}

			var model = new ShopingCardViewModel()
			{
				CardProduct = this.shopinCardService.ShowShopingCard(shopingCardId)
			};

			return View(model);
		}



		[HttpPost]
		public IActionResult ShopingCard(int id)
		{
			string userId = this.userManager.GetUserId(HttpContext.User);

			var succsses = this.shopinCardService.AddProductToCard(id, userId);
			if (succsses)
			{
				int countProduct = this.db.ProductShopingCard.Count();
				this.TempData["CountProduct"] = countProduct.ToString();
				this.TempData["_Message"] = "The product is added successfully";
				return RedirectToAction("UsersAllProduct", "Users", new { area = "Users" });
			}

			this.TempData["Error"] = "The Product is not added !!!!";
			return RedirectToAction("UsersAllProduct", "Users", new { area = "Users" });


		}

		[HttpGet]
		public IActionResult DeleteProductOnShopingCard(int id)
		{
			if (id == 0 || id < 0)
			{
				this.TempData["_Message"] = "Id id null or negativ !!!";
				return RedirectToAction(nameof(ShopingCard));
			}
			return View(id);
		}

		[HttpGet]
		public IActionResult DestroyProductOnShopingCard(int id)
		{
			var sucssecce = this.shopinCardService.DeliteProductOnShopingCard(id);

			if (!sucssecce)
			{
				this.TempData["Error"] = "Сomething is wrong!!!";
				return RedirectToAction("ShopingCard", "ShopingCard");
			}

			this.TempData["_Message"] = "The deleted is successfully";
			//this.ViewBag.Error = "The deleted is successfully !!!";
			return RedirectToAction("ShopingCard", "ShopingCard");

		}

		[HttpGet]
		public IActionResult MakeOrder()
		{
			var model = new OrderModel()
			{
				Shippers= this.shopinCardService.AddAdresAndShipper()
			};
			return View(model);
		}

		[HttpPost]
		public IActionResult MakeOrder(OrderModel model)
		{

			if (!ModelState.IsValid)
			{
				model.Shippers = this.shopinCardService.AddAdresAndShipper();
				this.ViewBag.Error = "The model is wrong !!!";
				return View(model);
			}
			string userId = this.userManager.GetUserId(HttpContext.User);

			var sucssec = this.shopinCardService.MakeOrder(userId, model);
			if (sucssec==false)
			{
				ViewBag.Error = "Sometimes wrong and can't make order!!!";
				return View();
			}

			return RedirectToAction(nameof(StripePayment));
		}

		[HttpGet]
		public IActionResult Paymant()
		{
			return View();
		}

		public IActionResult Paymant(AddPaymantModel model)
		{
			if (!ModelState.IsValid)
			{
				return NotFound();
			}
			var succsses = this.shopinCardService.AddPaymantCard(model);
			return RedirectToAction("MakeOrder", "ShopingCard");
		}

		[HttpGet]
		public IActionResult StripePayment()
		{
			return View();
		}
		[HttpPost]
		public IActionResult StripePayment(StripeModel stripeModel )
		{
			//StripeConfiguration.SetApiKey("sk_test_Fbuusi3Y4VRoVIELALrUUCoi00YK6O2ekr");
			string userId = this.userManager.GetUserId(HttpContext.User);

			var sucsses = this.shopinCardService.UserPay(stripeModel, userId);

			

			return View();
		}
	}
}