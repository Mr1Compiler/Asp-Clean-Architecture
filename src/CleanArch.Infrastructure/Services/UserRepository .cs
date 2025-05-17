using CleanArch.Domain.Entities;
using CleanArch.Domain.Interfaces;

namespace CleanArch.Infrastructure.Services;
public class UserRepository : IUserRepository
{
	// if there is AppDbContext then u should define constructor and inject AppDbContext

	// in this case its simple simulation -_-
	public async Task<IEnumerable<User>> GetAllUsersAsync()
	{
		var users = new List<User>
			{
				new User { Id = 1, Name = "ayman", Email = "a@gmail.com" }
			};

		return await Task.FromResult<IEnumerable<User>>(users);
	}
}
