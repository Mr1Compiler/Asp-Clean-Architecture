using CleanArch.Domain.Entities;


namespace CleanArch.Domain.Interfaces;
public interface IUserRepository
{
	Task<IEnumerable<User>> GetAllUsersAsync();
}
