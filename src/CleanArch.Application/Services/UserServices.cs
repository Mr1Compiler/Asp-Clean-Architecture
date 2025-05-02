using CleanArch.Application.Interfaces;
using CleanArch.Domain.Entities;
using CleanArch.Domain.Interfaces;

namespace CleanArch.Application.Services;
public class UserServices : IUserService
{
	private readonly IUserRepository _userRepository;
	public UserServices(IUserRepository userRepository)
	{
		_userRepository = userRepository;	
	}

	public async Task<List<User>> GetAllUsers()
	{
		var res = await _userRepository.GetAllUsersAsync();

		return res.ToList();
	}
}
