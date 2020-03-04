using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;
using RosShop.Data;
using RosShop.Data.Models;
using RosShop.Services.Models;
using RosShop.Services.Models.Shipper;
using RosShop.Services.Models.ShopingCard;
using RosShop.Services.Models.ShopingCard.PayPal;
using RosShop.Services.Models.ShopingCard.Stripe;
using Stripe;
using Product = RosShop.Data.Models.Product;

namespace RosShop.Services.Implementation
{
	public class ShopingCardService : IShopingCardService
	{
		private readonly RosShopDbContext db;
		private List<Product> products = new List<Product>();
		private readonly UserManager<User> userManager;

		public ShopingCardService(RosShopDbContext db, UserManager<User> userManager)
		{
			this.db = db;

			this.userManager = userManager;
		}

		public bool AddProductToCard(int productId, string userId)
		{
			var findProduct = this.db.Products.Where(p => p.Id == productId).FirstOrDefault();

			if (findProduct != null)
			{
				var shopingCard = this.db.ShopingCards.Where(s => s.UserId == userId).FirstOrDefault();
				if (shopingCard == null)
				{
					shopingCard.Id = CreateShopingCard(userId);

				}
				var duplicateProduct = this.db.ProductShopingCard.Where(p => p.ProductId == productId).FirstOrDefault();
				if (duplicateProduct != null)
				{
					return false;
				}

				var result = new ProductShopingCard()
				{
					ProductId = findProduct.Id,
					ShopingCardId = shopingCard.Id
				};

				this.db.Add(result);
				this.db.SaveChanges();
			}
			else
			{
				return false;
			}
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
				//Image = p.Image,
				Price = p.Price,
				NumberOfSize = p.NumberOfSize,
				Color = p.Color,
				Gender = p.Gender,
				Quantity = p.Quantity
			});

			return result;
		}

		public int CreateShopingCard(string id)
		{
			var result = new ShopingCard()
			{

				Quontity = 0,
				Payment = new List<PaymentCard>(),
				Shippers = this.db.Shippers.FirstOrDefault(),
				UserId = id
			};

			this.db.Add(result);
			this.db.SaveChanges();
			return result.Id;

		}

		public int FindShopigCardId(string id)
		{
			var result = this.db.ShopingCards.Where(sh => sh.UserId == id).FirstOrDefault();

			if (result == null)
			{
				return 0;

			}
			return result.Id;
		}

		public ListOfShopingCardProduct ShowShopingCard(int id)
		{
			var result = new ListOfShopingCardProduct()
			{
				Id = id,
				Product = AllProductOnUserShopingCard(id),
				Cards = new List<PaymentCard>(),
				Shippers = GetAllShipper()
			};
			return result;
		}

		private IEnumerable<Product> AllProductOnUserShopingCard(int shopingCardId)
		{

			var result = this.db.ProductShopingCard.Where(p => p.ShopingCardId == shopingCardId).Select(p => p.ProductId).ToList();
			var product = new List<Product>();
			foreach (var id in result)
			{
				var findProduct = this.db.Products.Where(p => p.Id == id).FirstOrDefault();
				product.Add(findProduct);
			}
			return product;
		}

		private IEnumerable<SelectListItem> GetAllShipper()
		{
			var allShipper = this.db.Shippers.
				OrderBy(s => s.NameOfShipper)
				.Select(s => new AllShippers
				{
					Id = s.Id,
					Name = s.NameOfShipper
				}).ToList();

			var result = allShipper.Select(s => new SelectListItem
			{
				Text = s.Name,
				Value = s.Id.ToString()
			});

			return result;
		}

		public bool DeliteProductOnShopingCard(int id)
		{
			var product = this.db.ProductShopingCard.Where(p => p.ProductId == id).FirstOrDefault();
			if (product == null)
			{
				return false;
			}

			this.db.Remove(product);
			this.db.SaveChanges();
			return true;
		}

		public bool AddPaymantCard(AddPaymantModel model)
		{
			var result = new PaymentCard()
			{
				Name = model.Name,
				BanckAccount = model.BanckAccount,
				Cvv = model.Cvv,
				ShopingCardId = 1

			};

			if (result == null)
			{
				return false;
			}

			this.db.Add(result);
			this.db.SaveChanges();
			return true;
		}

		public PayPalConfig getPayPalConfig()
		{
			var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsetting.json");

			var configurator = builder.Build();

			return new PayPalConfig()
			{
				AuthToken = configurator["PayPal:AuthToken"],
				PostUrl = configurator["PayPal:PostUrl"],
				Business = configurator["PayPal:Business"],
				ReturnUrl = configurator["PayPal:ReturnUrl"]
			};
		}

		public IEnumerable<SelectListItem> AddAdresAndShipper()
		{
			return GetAllShipper();
		}

		public bool MakeOrder(string userId, OrderModel model)
		{
			var shopingCard = this.db.ShopingCards.Where(u => u.UserId == userId).FirstOrDefault();
			var shipperId = this.db.Shippers.Where(s => s.Id == model.ShipperId).FirstOrDefault();
			if (shopingCard == null|| shipperId==null)
			{
				return false;
			}
			shopingCard.OrderAdress = model.Town + ", " + model.Adress + ", " + model.PostCode;
			shopingCard.Shippers = shipperId;

			this.db.SaveChanges();
			return true;
		}

		public bool UserPay(StripeModel stripeModel, string userId)
		{

			var shopingCardOfUser = this.db.ShopingCards.Where(c => c.UserId == userId).FirstOrDefault();

			var sumOfPay = this.db.ProductShopingCard.Where(c=>c.ShopingCardId==shopingCardOfUser.Id);
			var emailOnUser = this.db.Users.Where(c => c.Id == userId).Select(c => c.Email).FirstOrDefault();
			;
			var customers = new CustomerService();
			var charges = new ChargeService();

			var customer = customers.Create(new CustomerCreateOptions
			{
				Email = emailOnUser,
				Source = stripeModel.StripeToken
			});


			var charge = charges.Create(new ChargeCreateOptions
			{
				Amount = 500,
				Description = "Test PaymentBG",
				Currency = "BGN",
				Customer = customer.Id,
				ReceiptEmail = emailOnUser,
				Metadata = new Dictionary<string, string>()
				{
					{ "OrderID","111"},
					{ "PostCode", "LEE111"}
				}

			});

			if (charge.Status == "succeeded")
			{
				string BalanceTransactionId = charge.BalanceTransactionId;
				return true;
			}
			return false;
		}
	}
}
