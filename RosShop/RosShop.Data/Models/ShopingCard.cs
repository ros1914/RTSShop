namespace RosShop.Data.Models
{
	using Newtonsoft.Json.Linq;
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;

	public class ShopingCard
	{
		public int Id { get; set; }

		public string UserId { get; set; }

		public User User { get; set; }

		public IEnumerable<ProductShopingCard> Product { get; set; } = new List<ProductShopingCard>();

		[Range(0, 50)]
		public int Quontity { get; set; }

		public int ShippersId { get; set; }
		public Shipper Shippers { get; set; } 

		public IEnumerable<PaymentCard> Payment { get; set; } = new List<PaymentCard>();

		public bool Send { get; set; }

		public string OrderAdress { get; set; }

	}
}
