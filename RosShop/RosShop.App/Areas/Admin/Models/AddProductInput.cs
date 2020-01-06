namespace RosShop.App.Areas.Admin.Models
{
    using RosShop.Data.Models;
    using System;
    using System.ComponentModel.DataAnnotations;

    public class AddProductInput
	{
		
		public string Type { get; set; }

		[Display(Name = "Brand Name")]
		public string BrandName { get; set; }

		
		[Display(Name = "Name of Model")]
		public string NameOfModel { get; set; }

		
		public string Description { get; set; }

		public byte[] Image { get; set; }

		[Range(0,500)]
		public double Price { get; set; }

		public string Gender { get; set; }
		
		public int NumberOfSize { get; set; }

		public Color Color { get; set; }

		[Range(0, 50)]
		public int Quantity { get; set; }
	}
}
