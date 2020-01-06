namespace RosShop.Services.Models.ShopingCard
{
	using RosShop.Data.Models;
	using System.Collections.Generic;

	public class OrderModel
	{
		public int Id { get; set; }

		public IEnumerable<Product> Product { get; set; }

		public int ShipperId { get; set; }

		public string NameOfSiopper { get; set; }

		public int PaymantCardId { get; set; }


	}
}
