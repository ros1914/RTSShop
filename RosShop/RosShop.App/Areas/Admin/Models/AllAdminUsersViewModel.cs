namespace RosShop.App.Areas.Admin.Models
{
	using RosShop.Services.Models;
	using System.Collections.Generic;

	public class AllAdminUsersViewModel
	{
		public IEnumerable<AllListingUsersAdmin> AllAdmins { get; set; }
	}
}
