using DevelopmentSucks2.Application.Services.Interfaces;
using DevelopmentSucks2.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace DevelopmentSucks2.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsersController: ControllerBase
{
    private readonly IUsersService _usersService;
    
    public UsersController(IUsersService usersService)
    {
        _usersService = usersService;
    }

    [HttpGet]
    public async Task<List<User>> GetAllUsers()
    {
        var users = await _usersService.GetAllUsers();
        return users;
    }

    [HttpGet("{id:guid}")]
    public async Task<User?> GetUserById(Guid id)
    {
        var user = await _usersService.GetUserById(id);
        return user;
    }
}
