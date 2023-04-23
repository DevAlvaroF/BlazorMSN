namespace BlazorMSN.Core.Domain.Entities
{
	public class User
	{
		public string? UserName { get; set; }
		public Guid ConnectionId { get; set; }
		public int imageIndex { get; set; }
	}
}
