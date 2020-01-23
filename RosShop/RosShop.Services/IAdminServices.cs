namespace RosShop.Services
{
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using RosShop.Services.Models;
	using System.Collections.Generic;
	using System.Threading.Tasks;

	public interface IAdminServices
	{
		bool ChangeImage(ChangeImageModel model);
		IEnumerable<AllListingUsers> AllUsers();

		bool MakeAdmin(string id);

		IEnumerable<AllListingUsersAdmin> AllAdminUsers();

		Task<bool> DeleteAdmin(string id);

		bool AddProducts(AddProductModel addProductModel);

		IEnumerable<SelectListItem> AllBrandName();

		IEnumerable<AllListingProducts> AllProducts();

		DetailsProductModel DetailsProduct(int id);

		EditProductModel EditProduct(int id);
		bool SaveEditProducts(int id,EditProductModel editProduct);

		bool Delete(int id);

		bool AddShupper(AddShiperModel addShiper);

		IEnumerable<AllListingShippers> AllShippers();

		DetailsShipperModel DetailsShipper(int id);

		EditShipperModel EditShipper(int id);

		bool SaveEditShipper(int id , EditShipperModel editShipper);

		bool DeleteShipper(int id);

		IEnumerable<AllListingUsers> SearchUsers( string searchUser);

		IEnumerable<AllListingProducts> SearchProduct(string searchProduct); 
	}
}
