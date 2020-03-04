using RosShop.Services.Implementation;
using System.IO;
using System.Net;

namespace RosShop.Services.Models.ShopingCard.PayPal
{
	public class PDTHolder
	{
		
		public double CrossTotal { get; set; }

		public int InvoiceNumber { get; set; }

		public string PaymentStatus { get; set; }

		public string PayerFirstName { get; set; }

		public double PaymentFee { get; set; }

		public string BusinessEmail { get; set; }

		public string TxToken { get; set; }

		public string PayerLastName { get; set; }

		public string ReceoverEmail { get; set; }

		public string ItemName { get; set; }

		public string TransactionId { get; set; }

		public string SubscriberId { get; set; }

		public string Custom { get; set; }

		//private static string authToken, txToken, query, strResponse;

		//public  PDTHolder Success(string tx)
		//{
		//	var payPalConfig = new PayPalService().GetPayPalConfig();
		//
		//	ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
		//	authToken = payPalConfig.AuthToken;
		//	txToken = tx;
		//	query = string.Format("cmd=_notify-synch&tx={0}&at={1}", TxToken, authToken);
		//
		//	string url = payPalConfig.PostUrl;
		//	HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
		//	req.Method = "POST";
		//	req.ContentType = "application/x-www-form-urlencoded";
		//	req.ContentLength = query.Length;
		//	StreamWriter stOut = new StreamWriter(req.GetRequestStream(),System.Text.Encoding.ASCII);
		//	stOut.Write(query);
		//	stOut.Close();
		//	StreamReader stIn = new StreamReader(req.GetResponse().GetResponseStream());
		//
		//}

	}
}
