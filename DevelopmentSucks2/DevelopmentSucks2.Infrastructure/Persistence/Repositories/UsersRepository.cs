using DevelopmentSucks2.Domain.Entities;
using DevelopmentSucks2.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace DevelopmentSucks2.Infrastructure.Persistence.Repositories;

public class UsersRepository : IUsersRepository
{
    private readonly AppDbContext _context;

    public UsersRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<User>> GetAllUsers()
    {
        var users = await _context.Users
            .AsNoTracking()
            .ToListAsync();

        return users;
    }

    public async Task<User?> GetUserById(Guid id)
    {
        var user = await _context.Users
            .FindAsync(id);

        return user;
    }
}
