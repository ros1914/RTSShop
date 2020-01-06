
namespace RosShop.Services.Implementation
{
	using System.Collections.Generic;
	using System.Linq;
	using RosShop.Data;
	using RosShop.Services.Models;
	using RosShop.Services.Models.Users;

	public class UserServices : IUserServices
	{

		private readonly RosShopDbContext db;
		
		public UserServices(RosShopDbContext db)
		{
			this.db = db;
			
		}
		
		public IEnumerable<UsersAllListingProduct> AllProducts()
		{
			var result = this.db.Products.Select(p => new UsersAllListingProduct()
			{
				Id = p.Id,
				Type = p.Type,
				BrandName = p.BrandName,
				NameOfModel = p.NameOfModel,
				Description = p.Description,
				ImagePath = p.ImagePath,
				Price = p.Price,
				NumberOfSize = p.NumberOfSize,
				Color = p.Color,
				Gender = p.Gender,
				Quantity = p.Quantity
			});
		
			return result;
		}
		
		public DetailsProductModel DetailsProduct(int id)
		{
			var product = this.db.Products.Where(p => p.Id == id).Select(p => new DetailsProductModel()
			{
				Id = p.Id,
				Type = p.Type,
				BrandName = p.BrandName,
				NameOfModel = p.NameOfModel,
				Description = p.Description,
				ImagePath = p.ImagePath,
				Price = p.Price,
				NumberOfSize = p.NumberOfSize,
				Quantity = p.Quantity,
				Gender = p.Gender,
				Color = p.Color
			}).FirstOrDefault();
		
			return product;
		}
		
	}
}
