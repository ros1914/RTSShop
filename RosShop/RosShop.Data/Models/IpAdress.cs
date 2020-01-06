namespace RosShop.Data.Models
{
	public class IpAdress
	{
		public int Id { get; set; }

		public string IpOfAdress { get; set; }

		public int UserId { get; set; }

		public User User { get; set; }
	}
}
