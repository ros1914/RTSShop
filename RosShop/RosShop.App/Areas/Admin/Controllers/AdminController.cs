namespace RosShop.App.Areas.Admin.Controllers
{
	using Microsoft.AspNetCore.Authorization;
	using Microsoft.AspNetCore.Hosting;
	using Microsoft.AspNetCore.Http;
	using Microsoft.AspNetCore.Identity;
	using Microsoft.AspNetCore.Mvc;
	using RosShop.App.Areas.Admin.Models;
	using RosShop.App.Areas.Admin.Models.Shipper;
	using RosShop.App.Common.Messages;
	using RosShop.Data.Models;
	using RosShop.Services;
	using RosShop.Services.Models;
	using System;
	using System.IO;
	using System.Threading.Tasks;

	[Area("Admin")]
	[Authorize(Roles = "Administrator")]
	public class AdminController : Controller
	{
		private readonly IAdminServices adminServices;
		private readonly UserManager<User> userManager;


		public AdminController(IAdminServices adminServices, UserManager<User> userManager)
		{
			this.adminServices = adminServices;
			this.userManager = userManager;

		}

		[HttpGet]
		public IActionResult ChangeImage(int id)
		{
			return View();
		}

		[HttpPost]
		public IActionResult ChangeImage(ChangeImageModel file)
		{
			if (file.Id == 0 || file.Photo == null)
			{
				this.TempData["_Message"] = "Photo model or id of product is wrong !!!";
				return RedirectToAction(nameof(AllProduct));
			}

			var sucsses = this.adminServices.ChangeImage(file);
			if (!sucsses)
			{
				this.TempData["_Message"] = "The new image is not canged ";
				return RedirectToAction(nameof(AllProduct));

			}

			this.TempData["_Message"] = "Image is changed sucssesful";
			return RedirectToAction(nameof(Details), new { id = file.Id });

		}

		[HttpGet]
		public IActionResult All()
		{
			var allListingsUser = adminServices.AllUsers();
			//var allAdmin = this.adminServices.AllAdminUsers();

			//var user = this.userManager.GetUserAsync(this.User);

			if (allListingsUser == null)
			{
				return NotFound();
			}

			var result = new AllUserViewModel()
			{
				AllUsers = allListingsUser
			};

			//var result2 = new AllAdminUsersViewModel()
			//{
			//	AllAdmins = allAdmin
			//};

			return View(result);
		}

		[HttpGet]
		public IActionResult AllAdmin()
		{
			// return all admins
			var allAdmin = this.adminServices.AllAdminUsers();
			if (allAdmin == null)
			{
				return NotFound();
			}

			var result2 = new AllAdminUsersViewModel()
			{
				AllAdmins = allAdmin
			};

			return View(result2);
		}

		[HttpPost]
		public async Task<IActionResult> DeleteAdmin(string id)
		{
			var result = await this.adminServices.DeleteAdmin(id);

			if (result)
			{
				this.TempData["_Message"] = "Sucsses: The User is not admin !";

				return RedirectToAction(nameof(AllAdmin));

			}

			return RedirectToAction("All");
		}



		[HttpGet]
		public IActionResult MakeAdmin(string id)
		{

			var result = this.adminServices.MakeAdmin(id);

			if (result)
			{
				this.TempData["_Message"] = "Sucsses: The User is admin !";
				return RedirectToAction(nameof(AllAdmin));
				//return  View();
			}
			return RedirectToAction(nameof(AllAdmin));
		}

		[HttpGet]
		public IActionResult AddProduct()
		{
			return View();
		}

		[HttpPost]
		public IActionResult AddProduct(AddProductModel model)
		{
			if (!ModelState.IsValid)
			{
				this.ViewBag.Error = "The model is wrong !!!";
				return View(model);
			}

			var succses = this.adminServices.AddProducts(model);

			this.TempData["_Message"] = "Sucsses: Добави нови обуща !";

			return RedirectToAction("AddProduct", "Admin");
		}

		[HttpGet]
		public IActionResult AllProduct()
		{
			var result = new AllProductViewModel()
			{
				All = this.adminServices.AllProducts()
			};

			if (result == null)
			{
				this.ViewBag.Error = "The result is null";
				return View();
			}
			return View(result);
		}

		[HttpGet]
		public IActionResult Details(int id)
		{
			var result = new DetailsProductViewModel()
			{
				DetailsProductModel = this.adminServices.DetailsProduct(id)
			};

			if (result == null)
			{
				TempData["_Message"] = "Details is wrong !!!";
				return RedirectToAction(nameof(AllProduct));
			}
			return View(result);
		}

		[HttpGet]
		public IActionResult Edit(int id)
		{
			var result = new EditProductViewModel()
			{
				Edit = this.adminServices.EditProduct(id)
			};

			if (result == null)
			{
				this.TempData["_Message"] = "Edit model is wrong !!!";
				return RedirectToAction(nameof(Details));
			}
			return View(result);
		}

		[HttpPost]
		public IActionResult Edit(int id, EditProductViewModel model)
		{
			if (!ModelState.IsValid)
			{
				this.ViewBag.Error = "The edit model is wrong!!!";
				return View(model);
			}

			var result = this.adminServices.SaveEditProducts(id, model.Edit);

			if (!result)
			{
				this.ViewBag.Error = "The edit is not successful";
				return View(model);
			}

			this.TempData["_Message"] = "The edit is successful";

			return RedirectToAction(nameof(AllProduct));


		}


		public IActionResult Delete(int id)
		{
			if (id == 0 || id < 0)
			{
				this.TempData["_Message"] = "Delite id is null or negative number";
				return RedirectToAction(nameof(AllProduct));
			}
			return View(id);
		}


		public IActionResult Destroy(int id)
		{
			var result = this.adminServices.Delete(id);

			if (!result)
			{
				this.TempData["_Message"] = "The delete is not successful";
				return View(id);
			}

			this.TempData["_Message"] = "The delete is successful";
			return RedirectToAction(nameof(AllProduct));
		}

		[HttpGet]
		public IActionResult AddShipper()
		{
			return View();
		}

		[HttpPost]
		public IActionResult AddShipper(AddShiperModel model)
		{
			if (!ModelState.IsValid)
			{
				this.ViewBag.Error = "The input data is not valid !!!";
				return View(model);
			}


			var result = this.adminServices.AddShupper(model);

			if (!result)
			{
				TempData["_Message"] = "The shipper is not add in database !!! ";

				return View(model);
			}

			this.TempData["_Message"] = "The shipper is add successful";

			return RedirectToAction(nameof(AddShipper));
		}

		[HttpGet]
		public IActionResult AllShipper()
		{
			var result = new AllShipperViewModel()
			{
				AllShipper = this.adminServices.AllShippers()
			};

			if (result == null)
			{
				this.ViewBag.Error = "The shippers is not find";
				return View();
			}

			return View(result);
		}

		[HttpGet]
		public IActionResult DetailsShipper(int id)
		{
			if (id == 0 || id < 0)
			{
				this.TempData["_Message"] = "The Shipper id is wrong !!!";
				return RedirectToAction(nameof(AllShipper));
			}
			var model = new DetailsShipperViewModel()
			{
				DetailsShipper = this.adminServices.DetailsShipper(id)
			};

			if (model == null)
			{
				this.ViewBag.Error = "The shippers is not find";
				return View(id);
			}

			return View(model);
		}

		[HttpGet]
		public IActionResult EditShipper(int id)
		{


			var model = new EditShipperVieModel()
			{
				EditModel = this.adminServices.EditShipper(id)
			};

			if (model == null)
			{
				this.TempData["_Message"] = "Edit shipper is not find";
				return RedirectToAction(nameof(DetailsShipper), new { id });
			}

			return View(model);
		}

		[HttpPost]
		public IActionResult EditShipper(int id, EditShipperVieModel model)
		{
			if (model == null)
			{
				this.ViewBag.Error = "The edit model is null !!!";
				return View(id);
			}
			var editModel = this.adminServices.SaveEditShipper(id, model.EditModel);

			if (editModel)
			{
				this.TempData["_Message"] = "Shipper is edit  successful!!!";
				return RedirectToAction(nameof(DetailsShipper), new { id });
			}

			this.ViewBag.Error = "Shipper is not edit !!!";

			return View(model);
		}


		public IActionResult DeleteShipper(int id)
		{
			if (id == 0 || id < 0)
			{
				this.TempData["_Message"] = "Id id null or negativ !!!";
				return RedirectToAction(nameof(AllShipper));
			}
			return View(id);
		}


		public IActionResult DestroyShipper(int id)
		{
			id = 89;
			var result = this.adminServices.DeleteShipper(id);

			if (!result)
			{
				this.TempData["_Message"] = "The shipper is not delite";
				return RedirectToAction(nameof(AllShipper), id);
			}

			this.TempData["_Message"] = "The shipper is delete successful !!!";
			return RedirectToAction(nameof(AllShipper));
		}


		[HttpGet]
		public IActionResult SearchUser(string searchUser)
		{
			if (!String.IsNullOrEmpty(searchUser))
			{
				var result = new AllUserViewModel()
				{
					AllUsers = this.adminServices.SearchUsers(searchUser)
				};
				if (result == null)
				{
					this.TempData["Error"] = "The user is not found";

					return RedirectToAction(nameof(All));
				}
				return View("All", result);
			}

			this.TempData["Error"] = "Search string is null or empty";
			return RedirectToAction(nameof(All));
		}

		[HttpGet]
		public IActionResult SearchProduct(string searchProduct)
		{
			if (!String.IsNullOrEmpty(searchProduct))
			{
				var result = new AllProductViewModel()
				{
					All = this.adminServices.SearchProduct(searchProduct)
				};

				if (result == null)
				{
					this.TempData["Error"] = "Product whith name is not found !!!";
					return RedirectToAction(nameof(AllProduct));
				}
				return View("AllProduct", result);
			}

			this.TempData["Error"] = "Search string is null or empty !!!";
			return RedirectToAction(nameof(AllProduct));
		}
	}
}