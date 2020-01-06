namespace RosShop.Data.Models
{
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;

	public class Shipper
	{
		public int Id { get; set; }

		[MinLength(2)]
		[MaxLength(15)]
		[Display(Name ="Name of Shipper")]
		public string NameOfShipper { get; set; }

		[DataType(DataType.PhoneNumber)]
		[Phone]
		public string Phone { get; set; }

		public int ShopingId { get; set; }
		public ShopingCard ShopingCard { get; set; }
	}
}