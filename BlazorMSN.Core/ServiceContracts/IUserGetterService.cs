using BlazorMSN.Core.DTO;

namespace BlazorMSN.Core.ServiceContracts
{
	public interface IUserGetterService
	{
		/// <summary>
		/// Returns the person with the matching Guid
		/// </summary>
		/// <param name="userId">User Id (Guid)</param>
		/// <returns>User response if person found or null</returns>
		Task<UserResponse?> GetUser(Guid connectionId);
	}
}
