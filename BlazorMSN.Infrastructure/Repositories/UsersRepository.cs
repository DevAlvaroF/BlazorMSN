using BlazorMSN.Core.Domain.Entities;
using BlazorMSN.Core.Domain.RepositoryContracts;
using BlazorMSN.Infrastructure.DbContext;

namespace BlazorMSN.Infrastructure.Repositories
{
	public class UsersRepository : IUsersRepository
	{
		private readonly FakeApplicationDbContext _db;

		public UsersRepository(FakeApplicationDbContext db)
		{
			_db = db;
		}

		public async Task<User> AddUser(User user)
		{
			await Task.FromResult(0);
			if (user.ConnectionId != Guid.Empty)
			{
				User? matchUser = await GetUser(user.ConnectionId);

				// IF user exists
				if (matchUser != null) return null;

				// Add user
				_db.RegisteredUsers.Add(user);

			}
			user.imageIndex = _db.RegisteredUsers.Count;

			return user;

		}

		public async Task<bool> DeleteUser(Guid connectionString)
		{
			User? matchedUser = await GetUser(connectionString);

			if (matchedUser != null)
			{
				_db.RegisteredUsers.Remove(matchedUser);
				return true;
			}

			return false;

		}

		public async Task<User?> GetUser(Guid connectionId)
		{
			await Task.FromResult(0);

			User? matchUser = _db.RegisteredUsers.FirstOrDefault(u => u.ConnectionId == connectionId);

			if (matchUser == null) return null;

			return matchUser;
		}


	}
}
