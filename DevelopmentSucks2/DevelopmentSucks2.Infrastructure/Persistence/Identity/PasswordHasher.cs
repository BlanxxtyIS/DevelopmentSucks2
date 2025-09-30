using DevelopmentSucks2.Domain.Repositories.Auth;

namespace DevelopmentSucks2.Infrastructure.Persistence.Identity;

public class PasswordHasher : IPasswordHasher
{

    public string Hash(string password)
    {
        return BCrypt.Net.BCrypt.HashPassword(password);
    }

    public bool Verify(string hash, string password)
    {
        return BCrypt.Net.BCrypt.Verify(password, hash);
    }
}
