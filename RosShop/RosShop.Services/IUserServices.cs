namespace RosShop.Services
{
	using RosShop.Services.Models;
    using RosShop.Services.Models.Users;
    using System.Collections.Generic;

	public interface IUserServices
	{
		IEnumerable<UsersAllListingProduct> AllProducts();

		DetailsProductModel DetailsProduct(int id);

	}
}
