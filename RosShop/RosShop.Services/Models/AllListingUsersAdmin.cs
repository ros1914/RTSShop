namespace RosShop.Services.Models
{
	
	using System.Collections.Generic;

	public class AllListingUsersAdmin
	{
		public string Id { get; set; }

		public string Name { get; set; }

		public string Email { get; set; }

		public IEnumerable<string> AllRoles { get; set; }
	}
}
