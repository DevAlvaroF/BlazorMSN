using BlazorMSN.Core.Domain.Entities;

namespace BlazorMSN.Infrastructure.DbContext
{
	public class FakeApplicationDbContext
	{
		// Simulated Database Interaction
		public List<User> RegisteredUsers { get; set; } = new List<User>();
		public List<User> Messages { get; set; } = new List<User>();
	}
}
