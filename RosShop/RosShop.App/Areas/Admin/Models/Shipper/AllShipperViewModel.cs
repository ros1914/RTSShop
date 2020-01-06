namespace RosShop.App.Areas.Admin.Models.Shipper
{
	using RosShop.Services.Models;
	using System.Collections.Generic;

	public class AllShipperViewModel
	{
		public IEnumerable<AllListingShippers> AllShipper { get; set; }
	}
}
