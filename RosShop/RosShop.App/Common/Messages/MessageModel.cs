namespace RosShop.App.Common.Messages
{
	using System;
	

	[Serializable]
	public class MessageModel
	{
		public MessageType Type { get; set; }

		public string TextMessege { get; set; }
	}

	
}
