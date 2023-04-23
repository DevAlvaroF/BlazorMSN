using BlazorMSN.Core.Domain.Entities;
using BlazorMSN.Core.Domain.RepositoryContracts;
using BlazorMSN.Core.DTO;
using BlazorMSN.Core.ServiceContracts;

namespace BlazorMSN.Core.Services
{

	public class UserGetterService : IUserGetterService
	{
		private readonly IUsersRepository _usersRepository;

		public UserGetterService(IUsersRepository usersRepository)
		{
			_usersRepository = usersRepository;
		}
		public async Task<UserResponse?> GetUser(Guid userId)
		{
			User? matchedUser = await _usersRepository.GetUser(userId);

			if (matchedUser == null) return null;

			return matchedUser.ToUserResponse();
		}
	}
}
