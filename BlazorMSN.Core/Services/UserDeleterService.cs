using BlazorMSN.Core.Domain.RepositoryContracts;
using BlazorMSN.Core.ServiceContracts;

namespace BlazorMSN.Core.Services
{
	public class UserDeleterService : IUserDeleterService
	{
		private readonly IUsersRepository _usersRepository;

		public UserDeleterService(IUsersRepository usersRepository)
		{
			_usersRepository = usersRepository;
		}

		public async Task<bool> DeleteUser(Guid connectionId)
		{
			// Get user
			bool deleteResult = await _usersRepository.DeleteUser(connectionId);

			return deleteResult;
		}
	}
}
