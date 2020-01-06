namespace RosShop.Services.Models
{
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using RosShop.Data.Models;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
	public  class AddProductModel
	{
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

		public IFormFile Photo { get; set; }

		[Range(0,500)]
		public double Price { get; set; }

		public string Gender { get; set; }

		[Required]
		[Range(15,60)]
		[Display(Name ="Number of Size")]
		public int NumberOfSize { get; set; }

		public Color Color { get; set; }

		[Range(0, 50)]
		public int Quantity { get; set; }

	}
}
