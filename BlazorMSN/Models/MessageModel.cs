namespace BlazorMSN.UI.Models
{
	public class MessageModel
	{
		//public MessageModel(string userName, string body, bool mine)
		//{
		//	UserName = userName;
		//	Body = body;
		//	Mine = mine;
		//}

		public string? UserName { get; set; }
		public string? Body { get; set; }
		public bool Mine { get; set; }
		public DateTime DateSent { get; set; }
		public string? genericImageId { get; set; }
		public string CSS
		{
			get
			{
				return Mine ? "right" : "left";
			}
		}
	}
}
