namespace RosShop.Services.Models.ShopingCard
{
	using RosShop.Data.Models;
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;

	public class ShopinCardModel
	{
		public int Id { get; set; }

		public IEnumerable<User> Users { get; set; } = new List<User>();

		public IEnumerable<Product> Products { get; set; } = new List<Product>();

		[Range(0, 50)]
		public int Quontity { get; set; }

		public IEnumerable<Shipper> Shippers { get; set; } = new List<Shipper>();

		public IEnumerable<PaymentCard> Payment { get; set; } = new List<PaymentCard>();
	}
}
