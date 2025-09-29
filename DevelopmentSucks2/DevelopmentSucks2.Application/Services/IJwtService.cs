
namespace DevelopmentSucks2.Application.Services;

public interface IJwtService
{
    string GenerateToken(string userId, string username, IList<string> roles);
}