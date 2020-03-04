
namespace RosShop.Services.Models.ShopingCard.PayPal
{
	using Microsoft.Extensions.Configuration;
	using System.IO;
	public class PayPalService
	{
		public PayPalConfig GetPayPalConfig()
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
	}
}
