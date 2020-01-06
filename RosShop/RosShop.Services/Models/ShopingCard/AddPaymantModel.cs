using System.ComponentModel.DataAnnotations;

namespace RosShop.Services.Models.ShopingCard
{
	public class AddPaymantModel
	{
		//public int Id { get; set; }

		[Required]
		public string Name { get; set; }

		[Required]
		//[Range(0, 16)]
		public int BanckAccount { get; set; }

		//[Range(0, 3)]
		public int Cvv { get; set; }

		
	}
}
