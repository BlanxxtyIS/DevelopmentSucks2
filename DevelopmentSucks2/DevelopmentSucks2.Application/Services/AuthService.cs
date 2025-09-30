using DevelopmentSucks2.Application.DTOs;
using DevelopmentSucks2.Application.Services.Interfaces;
using DevelopmentSucks2.Domain.Entities;
using DevelopmentSucks2.Domain.Repositories.Auth;

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

    public async Task<User?> LoginAsync(string username, string password)
    {
        var user = await _repository.LoginAsync(username, password);

        return user;
    }
}
