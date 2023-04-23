using BlazorMSN.Core.Domain.Entities;

namespace BlazorMSN.Core.DTO
{
	public class UserResponse
	{
		public string? UserName { get; set; }
		public Guid ConnectionId { get; set; }
		public int imageIndex { get; set; }
	}

	public static class UserExtensions
	{
		public static UserResponse ToUserResponse(this User user)
		{
			return new UserResponse()
			{
				UserName = user.UserName,
				ConnectionId = user.ConnectionId,
				imageIndex = user.imageIndex
			};
		}
	}
}
