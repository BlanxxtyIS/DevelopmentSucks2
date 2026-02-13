using DevelopmentSucks2.Domain.Entities;
using DevelopmentSucks2.Domain.Repositories.Auth;
using Microsoft.EntityFrameworkCore;

namespace DevelopmentSucks2.Infrastructure.Persistence.Repositories.Auth;

public class AuthRepository : IAuthRepository
{
    private readonly AppDbContext _context;
    private readonly IPasswordHasher _hasher;

    public AuthRepository(AppDbContext context, IPasswordHasher hasher)
    {
        _context = context;
        _hasher = hasher;
    }

    public async Task<Guid?> RegisterAsync(User user)
    {
        var availableUsers = await _context.Users
            .AnyAsync(u => u.Username == user.Username || u.Email == user.Email);

        if (availableUsers)
            return null;

        await _context.Users.AddAsync(user);
        await _context.SaveChangesAsync();

        return user.Id;
    }

    public async Task<User?> LoginAsync(string username, string password)
    {
        var user = await _context.Users
            .FirstOrDefaultAsync(u => u.Username == username);

        if (user == null)
            return null;

        return _hasher.Verify(user.PasswordHash, password) ? user : null;
    }
}
