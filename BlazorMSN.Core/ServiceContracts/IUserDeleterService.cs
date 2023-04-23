namespace BlazorMSN.Core.ServiceContracts
{
	public interface IUserDeleterService
	{
		/// <summary>
		/// Deletes user leaving the chatroom with a conenction Id.
		/// </summary>
		/// <param name="userName">User with connection string to remove</param>
		/// <returns>True if user deleted correctly, false if not</returns>
		Task<bool> DeleteUser(Guid connectionId);
	}
}
