using DevelopmentSucks2.Application.DTOs;
using DevelopmentSucks2.Domain.Entities;

namespace DevelopmentSucks2.Application.Services;

public interface IAuthService
{
    Task<List<User>> GetAllUsers();
    Task<User?> GetUserById(Guid id);
    Task<Guid?> RegisterUser(UserDto userDto);
    Task<User?> LoginAsync(string username, string password);
}