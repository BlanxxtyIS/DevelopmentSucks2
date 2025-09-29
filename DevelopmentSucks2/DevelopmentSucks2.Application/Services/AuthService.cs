using DevelopmentSucks2.Application.DTOs;
using DevelopmentSucks2.Domain.Entities;
using DevelopmentSucks2.Domain.Repositories;

namespace DevelopmentSucks2.Application.Services;

public class AuthService : IAuthService
{
    private readonly IPasswordHasher _hasher;
    private readonly IAuthRepository _repository;

    public AuthService(IPasswordHasher hasher, IAuthRepository repository)
    {
        _hasher = hasher;
        _repository = repository;
    }

    public async Task<List<User>> GetAllUsers()
    {
        var users = await _repository.GetAllUsers();

        return users;
    }

    public async Task<User?> LoginAsync(string username, string password)
    {
        var user = await _repository.LoginAsync(username, password);

        return user;
    }

    public async Task<User?> GetUserById(Guid id)
    {
        var user = await _repository.GetUserById(id);

        return user;
    }

    public async Task<Guid?> RegisterUser(UserDto userDto)
    {
        var user = new User
        {
            Id = Guid.NewGuid(),
            Username = userDto.Username,
            Email = userDto.Email,
            PasswordHash = _hasher.Hash(userDto.Password)
        };

        return await _repository.RegisterAsync(user);
    }
}
