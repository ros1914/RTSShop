namespace RosShop.Services.Implementation
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
	using System.Threading.Tasks;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Identity;
	using Microsoft.AspNetCore.Mvc.Rendering;
	using Microsoft.EntityFrameworkCore;
	using RosShop.Data;
	using RosShop.Data.Models;
	using RosShop.Services.Models;
    using static System.Net.Mime.MediaTypeNames;

    public class AdminServices : IAdminServices
	{
		private readonly RosShopDbContext db;
		private readonly UserManager<User> userManager;
		private readonly RoleManager<IdentityRole> roleManager;
		private readonly IHostingEnvironment he;

		public AdminServices(RosShopDbContext db, UserManager<User> userManager, RoleManager<IdentityRole> roleManager, IHostingEnvironment e)
		{
			this.db = db;
			this.userManager = userManager;
			this.roleManager = roleManager;
			this.he = e;
		}


		public bool AddProducts(AddProductModel productModel)
		{
			var sameModel = this.db.Products.Where(p => p.NameOfModel == productModel.NameOfModel && p.Gender == productModel.Gender && p.NumberOfSize == productModel.NumberOfSize && p.Color == productModel.Color).FirstOrDefault();
			if (sameModel != null)
			{
				return false;
			}


			var newProduct = new Product()
			{
				Type = productModel.Type,
				BrandName = productModel.BrandName,
				NameOfModel = productModel.NameOfModel,
				Description = productModel.Description,
				Price = productModel.Price,
				Gender = productModel.Gender,
				ImagePath = AddImageToProduct(productModel.Photo),
				NumberOfSize = productModel.NumberOfSize,
				Color = productModel.Color,
				Quantity = productModel.Quantity
			};

			if (newProduct != null)
			{
				this.db.Add(newProduct);
				this.db.SaveChanges();

				return true;
			}

			return false;
		}

		public IEnumerable<AllListingUsersAdmin> AllAdminUsers()
		{
			var allUsers = userManager.GetUsersInRoleAsync("Administrator").Result;

			var result = new List<AllListingUsersAdmin>();

			foreach (var user in allUsers)
			{
				var roleUser = new List<string>();


				foreach (var role in userManager.GetRolesAsync(user).Result)
				{
					roleUser.Add(role);
				}

				result.Add(new AllListingUsersAdmin()
				{
					Id = user.Id,
					Name = user.UserName,
					Email = user.Email,
					AllRoles = roleUser
				});
			}

			return result;
		}

		public IEnumerable<AllListingUsers> AllUsers()
		{
			var userIsCustomer = userManager.GetUsersInRoleAsync("Customer").Result;
			//var roleID = this.db.Roles.Where(r => r.Name == "Administrator").FirstOrDefault().Id;
			//var userIsNotAdmin = this.db.UserRoles.Where(r => r.RoleId != roleID).Select(u=>u.UserId);


			var result =
				userIsCustomer
				.Select(u => new AllListingUsers
				{
					Id = u.Id,
					UserName = u.UserName,
					FirstName = u.FirstName,
					LastName = u.LastName,
					Email = u.Email,
					ConfurmEmail = u.EmailConfirmed,
					PhoneNumber = u.PhoneNumber,
					ConfirmPhonNumber = u.PhoneNumberConfirmed,
					TwoFactorEnabled = u.TwoFactorEnabled,
					DateOfRegistration = u.DateOfRegistration,
					Image = u.Image,
					Addres = u.Addres,
					PostCode = u.PsteCode,
					Town = u.Town
				})
				.ToList();


			return result;
		}

		public IEnumerable<SelectListItem> AllBrandName()
		{
			var result = this.db.Products.Select(b => new SelectListItem
			{
				Text = b.BrandName,
				Value = b.BrandName
			}).ToList();
			return result;
		}

		public async Task<bool> DeleteAdmin(string id)
		{
			var user = this.db.Users.Where(a => a.Id == id).FirstOrDefault();
			if (user == null)
			{
				return false;
			}

			var result = await this.userManager.RemoveFromRoleAsync(user, "Administrator");

			return true;
		}

		public bool MakeAdmin(string id)
		{
			var user = this.db.Users.Where(a => a.Id == id).FirstOrDefault();

			var userRoles = this.userManager.GetRolesAsync(user).Result;

			var roleName = userRoles.Contains("Administrator");

			if (roleName)
			{
				return false;
			}

			var result = userManager.AddToRoleAsync(user, "Administrator").Result;

			return true;
		}

		public IEnumerable<AllListingProducts> AllProducts()
		{
			var result = this.db.Products.Select(p => new AllListingProducts()
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
			var result = this.db.Products.Where(p => p.Id == id)
				.Select(p => new DetailsProductModel
				{
					Id = p.Id,
					Type = p.Type,
					BrandName = p.BrandName,
					NameOfModel = p.NameOfModel,
					Description = p.Description,
					NumberOfSize = p.NumberOfSize,
					Gender = p.Gender,
					ImagePath = p.ImagePath,
					Price = p.Price,
					Color = p.Color,
					Quantity = p.Quantity
				}).FirstOrDefault();


			return result;
		}


		public EditProductModel EditProduct(int id)
		{
			var result = this.db.Products
				.Where(p => p.Id == id)
				.Select(p => new EditProductModel
				{
					Id = p.Id,
					Type = p.Type,
					BrandName = p.BrandName,
					NameOfModel = p.NameOfModel,
					Description = p.Description,
					NumberOfSize = p.NumberOfSize,
					Gender = p.Gender,
					ImagePath = p.ImagePath,
					Price = p.Price,
					Color = p.Color,
					Quantity = p.Quantity
				})
				.FirstOrDefault();

			return result;

		}

		public bool SaveEditProducts(int id, EditProductModel editProduct)
		{
			var findEditModel = this.db.Products.Find(id);

			if (findEditModel == null)
			{
				return false;
			}


			findEditModel.Type = editProduct.Type;
			findEditModel.BrandName = editProduct.BrandName;
			findEditModel.NameOfModel = editProduct.NameOfModel;
			findEditModel.Description = editProduct.Description;
			findEditModel.Price = editProduct.Price;
			findEditModel.ImagePath = editProduct.ImagePath;
			findEditModel.NumberOfSize = editProduct.NumberOfSize;
			findEditModel.Color = editProduct.Color;
			findEditModel.Gender = editProduct.Gender;
			findEditModel.Quantity = editProduct.Quantity;

			this.db.SaveChanges();
			return true;

		}

		public bool Delete(int id)
		{

			//var result = this.db.Products.Where(p => p.Id == id).FirstOrDefault();
			var result = this.db.Products.Find(id);
			if (result == null)
			{
				return false;
			}

			this.db.Remove(result);
			this.db.SaveChanges();
			return true;
		}

		public bool AddShupper(AddShiperModel addShiper)
		{
			var result = this.db.Shippers.Where(s => s.NameOfShipper == addShiper.NameOfShipper || s.Phone == addShiper.Phone).FirstOrDefault();

			if (result != null)
			{

				return false;
			}
			var shipper = new Shipper()
			{
				NameOfShipper = addShiper.NameOfShipper,
				Phone = addShiper.Phone,
				ShopingId = 1
			};

			if (shipper == null)
			{
				return false;
			}

			this.db.Shippers.Add(shipper);
			this.db.SaveChanges();
			return true;
		}

		public IEnumerable<AllListingShippers> AllShippers()
		{
			var result = this.db.Shippers
				.Select(s => new AllListingShippers()
				{
					Id = s.Id,
					NameOfShipper = s.NameOfShipper,
					Phone = s.Phone

				});
			return result;
		}

		public DetailsShipperModel DetailsShipper(int id)
		{
			var result = this.db.Shippers.Where(s => s.Id == id)
				.Select(s => new DetailsShipperModel()
				{
					Id = s.Id,
					NameOfShipper = s.NameOfShipper,
					Phone = s.Phone
				})
				.FirstOrDefault();
			return result;
		}

		public EditShipperModel EditShipper(int id)
		{
			var result = this.db.Shippers
				.Where(s => s.Id == id)
				.Select(s => new EditShipperModel()
				{
					Id = s.Id,
					NameOfShipper = s.NameOfShipper,
					Phone = s.Phone
				})
				.FirstOrDefault();
			return result;
		}

		public bool DeleteShipper(int id)
		{
			var result = this.db.Shippers.Where(s => s.Id == id).FirstOrDefault();
			if (result == null)
			{
				return false;
			}

			this.db.Remove(result);
			this.db.SaveChanges();
			return true;
		}

		public bool SaveEditShipper(int id, EditShipperModel editShipper)
		{
			var result = this.db.Shippers.Where(s => s.Id == id).FirstOrDefault();
			if (result == null)
			{
				return false;
			}
			result.NameOfShipper = editShipper.NameOfShipper;
			result.Phone = editShipper.Phone;
			this.db.SaveChanges();

			return true;
		}

		private string AddImageToProduct(IFormFile model)
		{
			string uniqueFileName = String.Empty;

			string uploadsFolder = Path.Combine(he.WebRootPath, "images");
			// make unique name
			uniqueFileName = Guid.NewGuid().ToString() + "_" + model.FileName;
			// комбинираме два стринка за да създадем файл път 
			string filePath = Path.Combine(uploadsFolder, uniqueFileName);
			// записваме в папката images
			model.CopyTo(new FileStream(filePath, FileMode.Create));
			
			return uniqueFileName;
		}

		public bool ChangeImage(ChangeImageModel model)
		{
			var newNameImage = AddImageToProduct(model.Photo);

			var product = this.db.Products.Where(p=>p.Id==model.Id).FirstOrDefault();
			if (product==null)
			{
				return false;
			}

			product.ImagePath = newNameImage;

			this.db.SaveChanges();
			return true;
		}

		public IEnumerable<AllListingUsers> SearchUsers(string searchUser)
		{
			var resultUser = AllUsers().Where(n => n.UserName.Contains(searchUser) || n.FirstName.Contains(searchUser));
			return (resultUser);
		}

		public IEnumerable<AllListingProducts> SearchProduct(string searchProduct)
		{
			var result = AllProducts().Where(n=>n.NameOfModel.Contains(searchProduct) || n.BrandName.Contains(searchProduct));
			return result;
		}
	}
}
