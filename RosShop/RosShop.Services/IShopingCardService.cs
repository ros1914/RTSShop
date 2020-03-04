namespace RosShop.Services
{
    using Microsoft.AspNetCore.Mvc.Rendering;
    using RosShop.Services.Models;
	using RosShop.Services.Models.ShopingCard;
    using RosShop.Services.Models.ShopingCard.PayPal;
    using RosShop.Services.Models.ShopingCard.Stripe;
    using System.Collections.Generic;

	public interface IShopingCardService
	{
		IEnumerable<AllListingProducts> AllProducts();
		
		int CreateShopingCard(string id);
		
		int FindShopigCardId(string id);

		ListOfShopingCardProduct ShowShopingCard(int id);

		bool AddProductToCard(int productId , string userId);

		bool DeliteProductOnShopingCard(int id);

		bool AddPaymantCard(AddPaymantModel model);

		PayPalConfig getPayPalConfig();

		IEnumerable<SelectListItem> AddAdresAndShipper();

		bool MakeOrder(string userId, OrderModel model);

		bool UserPay(StripeModel stripeModel, string userId);
	}
}
