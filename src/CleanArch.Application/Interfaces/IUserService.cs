using CleanArch.Domain.Entities;

namespace CleanArch.Application.Interfaces;

public interface IUserService
{
	Task<List<User>> GetAllUsers();
}
