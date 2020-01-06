namespace RosShop.Data.Models
{
	using Microsoft.AspNetCore.Identity;
	using System;
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;

	public class User : IdentityUser
	{
		[MinLength(3)]
		[MaxLength(10)]
		[Display(Name = "First Name")]
		public string FirstName { get; set; }

		[MinLength(3)]
		[MaxLength(10)]
		[Display(Name = "Last Name")]
		public string LastName { get; set; }


		public DateTime DateOfRegistration { get; set; } = DateTime.Now;

		[MinLength(3)]
		[MaxLength(15)]
		public string Town { get; set; }

		[MaxLength(30)]
		public string Addres { get; set; }

		[MinLength(4)]
		[MaxLength(5)]
		public int PsteCode { get; set; }

		public IEnumerable<IpAdress> IPAdress { get; set; } = new List<IpAdress>();

		public byte[] Image { get; set; }

		public IEnumerable<ShopingCard> Shopingcard { get; set; } = new List<ShopingCard>();

		public IEnumerable<PaymentCard> PaymentCards { get; set; } = new List<PaymentCard>();

		public IEnumerable<ProductUser> Products { get; set; } = new List<ProductUser>();

	}
}
