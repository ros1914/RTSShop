namespace RosShop.Services.Models.ShopingCard
{
    using Microsoft.AspNetCore.Mvc.Rendering;
    using RosShop.Data.Models;
	using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class OrderModel
	{
		[MinLength(2)]
		[Required]
		public string Town { get; set; }

		[Required]
		public string Adress { get; set; }

		[Range(1000, 9999, ErrorMessage = "The Post Code must be 4 numbers")]
		[Display(Name = "Post Code")]
		public int PostCode { get; set; }

		public int ShipperId { get; set; }
		public IEnumerable<SelectListItem> Shippers { get; set; }

	}
}
