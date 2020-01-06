using System.ComponentModel.DataAnnotations;

namespace RosShop.Data.Models
{
	public class PaymentCard
	{
		public int Id { get; set; }

		[Required]
		public string Name { get; set; }

		[Required]
		[Range(0,16)]
		public int BanckAccount { get; set; }

		[Range(0,3)]
		public int Cvv { get; set; }

		public int ShopingCardId { get; set; }

		public ShopingCard ShopingCard { get; set; }

		public string UserId { get; set; }

		public User User { get; set; }
	}
}