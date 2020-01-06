namespace RosShop.App.Areas.Admin.Models
{
	using RosShop.Services.Models;
	using System.Collections.Generic;

	public class AllUserViewModel
	{
		public IEnumerable<AllListingUsers> AllUsers { get; set; }
	}
}
