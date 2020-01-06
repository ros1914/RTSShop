namespace RosShop.Services.Models
{
	using RosShop.Data.Models;

	public class BaseProductModel
	{
		public int Id { get; set; }
		public string Type { get; set; }

		public string BrandName { get; set; }

		public string NameOfModel { get; set; }

		public string Description { get; set; }

		public string ImagePath { get; set; }

		public double Price { get; set; }

		public string Gender { get; set; }


		public int NumberOfSize { get; set; }

		public Color Color { get; set; }

		public int Quantity { get; set; }
	}
}
