using DevelopmentSucks2.Application.DTOs;
using DevelopmentSucks2.Application.Services;
using DevelopmentSucks2.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace DevelopmentSucks2.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController: ControllerBase
{
    private readonly IAuthService _authService;
    private readonly IJwtService _jwtService;
    
    public AuthController(IAuthService authService, IJwtService jwtService)
    {
        _authService = authService;
        _jwtService = jwtService;
    }

    [HttpPost("login")]
    public async Task<ActionResult> LoginUser([FromBody] LoginDto loginDto)
    {
        var user = await _authService.LoginAsync(loginDto.Username, loginDto.Password);

        if (user == null)
            return Unauthorized();

        var jwtToken = _jwtService.GenerateToken(
            user.Id.ToString(),
            user.Username,
            new List<string> { "User" }
        );

        return Ok(new { accessToken = jwtToken });
    }

    [HttpGet]
    public async Task<List<User>> GetAllUsers()
    {
        var users = await _authService.GetAllUsers();
        return users;
    }

    [HttpGet("{id:guid}")]
    public async Task<User?> GetUserById(Guid id)
    {
        var user = await _authService.GetUserById(id);
        return user;
    }

    [HttpPost("register")]
    public async Task<ActionResult<Guid?>> RegisterAsync([FromBody] UserDto userDto)
    {
        var createdUserGuid = await _authService.RegisterUser(userDto);

        return Ok(createdUserGuid);
    }
}
