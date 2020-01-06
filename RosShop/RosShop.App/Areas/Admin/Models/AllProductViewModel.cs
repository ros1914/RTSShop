namespace RosShop.App.Areas.Admin.Models
{
	using RosShop.Services.Models;
	using System.Collections.Generic;

	public class AllProductViewModel
	{
		public IEnumerable<AllListingProducts> All { get; set; }
	}
}
