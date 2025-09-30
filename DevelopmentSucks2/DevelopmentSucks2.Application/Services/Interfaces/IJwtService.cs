namespace DevelopmentSucks2.Application.Services.Interfaces;

/// <summary>
/// Сервис для генерации Jwt - токена.
/// </summary>
public interface IJwtService
{
    /// <summary>
    /// Генерация токена.
    /// </summary>
    /// <param name="userId">Id пользователя.</param>
    /// <param name="username">Имя пользователя.</param>
    /// <param name="roles">Роли пользователя.</param>
    /// <returns>Сгенерированный JWT-токен.</returns>
    string GenerateToken(string userId, string username, IList<string> roles);
}