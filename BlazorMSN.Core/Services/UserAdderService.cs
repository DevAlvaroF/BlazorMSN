using BlazorMSN.Core.Domain.Entities;
using BlazorMSN.Core.Domain.RepositoryContracts;
using BlazorMSN.Core.DTO;
using BlazorMSN.Core.ServiceContracts;

namespace BlazorMSN.Core.Services
{
	public class UserAdderService : IUserAdderService
	{
		private readonly IUsersRepository _usersRepository;

		public UserAdderService(IUsersRepository usersRepository)
		{
			_usersRepository = usersRepository;
		}

		public async Task<UserResponse> AddUser(UserAddRequest userAddRequest)
		{
			// Get user
			User createdUser = await _usersRepository.AddUser(userAddRequest.ToUser());

			return createdUser.ToUserResponse();
		}
	}
}
