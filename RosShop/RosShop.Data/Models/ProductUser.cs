using System;
using System.Collections.Generic;
using System.Text;

namespace RosShop.Data.Models
{
	public class ProductUser
	{
		public string UserId { get; set; }

		public User User { get; set; }

		public int ProductId { get; set; }

		public Product Product { get; set; }

		
	}
}
