namespace RosShop.App.Areas.Users.Models
{
    using RosShop.Services.Models.Users;
    using System.Collections.Generic;

	public class AllUsersProductViewModel
	{
		public IEnumerable<UsersAllListingProduct> All { get; set; }
	}
}
