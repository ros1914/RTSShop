namespace RosShop.Data.Models
{
	public class ProductShopingCard
	{
		public int ProductId { get; set; }

		public Product Product { get; set; }

		public int ShopingCardId { get; set; }

		public ShopingCard ShopingCard { get; set; }
	}
}
