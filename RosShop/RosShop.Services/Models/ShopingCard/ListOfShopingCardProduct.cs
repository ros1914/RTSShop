using Microsoft.AspNetCore.Mvc.Rendering;
using RosShop.Data.Models;
using System.Collections.Generic;

namespace RosShop.Services.Models.ShopingCard
{
	public class ListOfShopingCardProduct
	{
		public int Id { get; set; }
		public IEnumerable<Product> Product { get; set; }

		public int Quantity { get; set; }

		public int ShipperId { get; set; }
		public IEnumerable<SelectListItem> Shippers { get; set; }

		public int CardId { get; set; }
		public IEnumerable<PaymentCard> Cards { get; set; }


	}
}
