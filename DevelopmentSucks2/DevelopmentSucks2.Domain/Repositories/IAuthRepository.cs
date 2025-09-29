using DevelopmentSucks2.Domain.Entities;

namespace DevelopmentSucks2.Domain.Repositories;

public interface IAuthRepository
{
    Task<Guid?> RegisterAsync(User user);
    Task<List<User>> GetAllUsers();
    Task<User?> GetUserById(Guid id);
    Task<User?> LoginAsync(string username, string password);
}
