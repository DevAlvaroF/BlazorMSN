using BlazorMSN.Core.Domain.Entities;

namespace BlazorMSN.Core.Domain.RepositoryContracts
{
	public interface IUsersRepository
	{
		/// <summary>
		/// Adds user to the data store
		/// </summary>
		/// <param name="user">User object to add</param>
		/// <returns></returns>
		Task<User> AddUser(User user);

		/// <summary>
		/// Gets user based on the userId
		/// </summary>
		/// <param name="userId">User Id (connection Id) to search for</param>
		/// <returns>User if found, else null</returns>
		Task<User?> GetUser(Guid connectionId);

		/// <summary>
		/// Deletes user based on the connection Id
		/// </summary>
		/// <param name="connectionString"></param>
		/// <returns>True is success, else false</returns>
		Task<bool> DeleteUser(Guid connectionString);
	}
}
