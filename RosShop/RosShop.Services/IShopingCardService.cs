namespace RosShop.Services
{
	using RosShop.Services.Models;
	using RosShop.Services.Models.ShopingCard;
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
	}
}
