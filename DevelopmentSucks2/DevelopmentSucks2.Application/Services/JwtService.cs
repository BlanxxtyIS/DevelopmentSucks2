using DevelopmentSucks2.Domain.Repositories;

namespace DevelopmentSucks2.Application.Services;

public class JwtService : IJwtService
{
    private readonly IJwtRepository _jwtRepository;

    public JwtService(IJwtRepository jwtRepository)
    {
        _jwtRepository = jwtRepository;
    }

    public string GenerateToken(string userId, string username, IList<string> roles)
    {
        return _jwtRepository.GenerateToken(userId, username, roles);
    }
}
