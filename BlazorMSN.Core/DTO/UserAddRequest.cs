using BlazorMSN.Core.Domain.Entities;

namespace BlazorMSN.Core.DTO
{
	public class UserAddRequest
	{
		public string? UserName { get; set; }
		public Guid ConnectionId { get; set; }

		public User ToUser()
		{
			return new User()
			{
				UserName = UserName,
				ConnectionId = ConnectionId
			};
		}
	}
}


