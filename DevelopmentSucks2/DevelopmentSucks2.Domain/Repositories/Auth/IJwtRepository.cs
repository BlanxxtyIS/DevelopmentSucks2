namespace DevelopmentSucks2.Domain.Repositories.Auth;

/// <summary>
/// Интерфейс для генерации JWT-токентов.
/// </summary>
public interface IJwtRepository
{
    /// <summary>
    /// Генерирует JWT-токен для указанного пользователя.
    /// </summary>
    /// <param name="userId">Уникальный идентификатор пользователя.</param>
    /// <param name="username">Имя пользователя.</param>
    /// <param name="roles">Список ролей пользователя.</param>
    /// <returns>Строка с JWT-токеном.</returns>
    string GenerateToken(string userId, string username, IList<string> roles);
}
 