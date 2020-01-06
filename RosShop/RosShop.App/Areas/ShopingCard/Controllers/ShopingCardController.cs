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
			int countProduct = this.db.ProductShopingCard.Count();
			this.TempData["CountProduct"] = countProduct.ToString();
			return RedirectToAction("UsersAllProduct", "Users", new { area = "Users" });

		}

		[HttpGet]
		public IActionResult DeleteProductOnShopingCard(int id)
		{
			var sucssecce = this.shopinCardService.DeliteProductOnShopingCard(id);

			if (!sucssecce)
			{
				return RedirectToAction("ShopingCard", "ShopingCard");
			}

			return RedirectToAction("ShopingCard", "ShopingCard");

		}

		[HttpGet]
		public IActionResult MakeOrder(ShopingCardViewModel model)
		{
			var shipperId = model.CardProduct.ShipperId;
			var shopingCardId = model.CardProduct.Id;
			if (model.CardProduct.CardId == 0)
			{
				//var succsses = this.shopinCardService.AddPaymantCard(shopingCardId);
				return RedirectToAction("Paymant", "ShopingCard");
			}

			return View();
		}

		[HttpPost]
		public IActionResult MakeOrder()
		{
			return View();
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
	}
}