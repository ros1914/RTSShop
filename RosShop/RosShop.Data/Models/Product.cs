namespace RosShop.Data.Models
{
    using Microsoft.Bot.Connector.DirectLine;
    using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;

	public class Product
	{
		public int Id { get; set; }

		[Required]
		[MinLength(3)]
		[MaxLength(15)]
		public string Type { get; set; }

		[Required]
		[MinLength(3)]
		[MaxLength(15)]
		[Display(Name = "Brand Name")]
		public string BrandName { get; set; }

		[Required]
		[MinLength(3)]
		[MaxLength(25)]
		[Display(Name = "Name of Model")]
		public string NameOfModel { get; set; }

		[Required]
		[MaxLength(250)]
		public string Description { get; set; }

		public string ImagePath { get; set; }

		[Required]

		[MinLength(0)]
		public double Price { get; set; }

		public string Gender { get; set; }

		[Required]
		[Range(15, 55)]
		[Display(Name = "Number of Size")]
		public int NumberOfSize { get; set; }

		public Color Color { get; set; }

		[Range(0, 50)]
		public int Quantity { get; set; }

		public IEnumerable<ProductUser> Users { get; set; } = new List<ProductUser>();

		//public int? ShopingId { get; set; }
		//
		//public virtual  ShopingCard Shoping { get; set; }

		public IEnumerable<ProductShopingCard> ShopingCards { get; set; } = new List<ProductShopingCard>();

	}
	

}
