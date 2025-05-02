using CleanArch.Application.Interfaces;
using CleanArch.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace CleanArch.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
	private readonly IUserService _userServices;

	public UserController(IUserService userServices)
	{
		_userServices = userServices;
	}

	[HttpGet]
	public IActionResult GetAllUsers()
	{
		var res = _userServices.GetAllUsers();

		if (res != null)
			return Ok(res);

		return NotFound();
	}
}
