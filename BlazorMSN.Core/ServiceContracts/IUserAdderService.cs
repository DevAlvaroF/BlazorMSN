using BlazorMSN.Core.DTO;

namespace BlazorMSN.Core.ServiceContracts
{
	public interface IUserAdderService
	{
		/// <summary>
		/// Adds new user with the proper username.
		/// </summary>
		/// <param name="userName">Username to add</param>
		/// <returns>The User Response if user is created or if it exists already</returns>
		Task<UserResponse> AddUser(UserAddRequest userAddRequest);
	}
}
