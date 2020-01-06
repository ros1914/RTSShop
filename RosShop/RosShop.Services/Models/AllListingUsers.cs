using System;

namespace RosShop.Services.Models
{
	public class AllListingUsers
	{
		public string Id { get; set; }

		public string UserName { get; set; }

		public string FirstName { get; set; }

		public string LastName { get; set; }

		public string Email { get; set; }

		public bool ConfurmEmail { get; set; }
		
		public string PhoneNumber { get; set; }

		public bool ConfirmPhonNumber { get; set; }

		public bool TwoFactorEnabled { get; set; }

		public DateTime DateOfRegistration { get; set; }

		public byte[] Image { get; set; }

		public string Addres { get; set; }
			   
		public int PostCode { get; set; }

		public string Town { get; set; }
	}
}
