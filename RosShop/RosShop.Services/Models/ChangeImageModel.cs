namespace RosShop.Services.Models
{
	using Microsoft.AspNetCore.Http;
    using System.Collections.Generic;

    public class ChangeImageModel
	{
		public int Id { get; set; }
		public IFormFile Photo { get; set; }
	}
}
