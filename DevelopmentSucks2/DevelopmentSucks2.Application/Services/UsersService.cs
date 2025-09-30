using DevelopmentSucks2.Application.Services.Interfaces;
using DevelopmentSucks2.Domain.Entities;
using DevelopmentSucks2.Domain.Repositories;

namespace DevelopmentSucks2.Application.Services;

public class UsersService : IUsersService
{
    public readonly IUsersRepository _usersRepository;

    public UsersService(IUsersRepository usersRepository)
    {
        _usersRepository = usersRepository;
    }

    public async Task<List<User>> GetAllUsers()
    {
        var users = await _usersRepository.GetAllUsers();

        return users;
    }

    public async Task<User?> GetUserById(Guid id)
    {
        var user = await _usersRepository.GetUserById(id);

        return user;
    }
}
