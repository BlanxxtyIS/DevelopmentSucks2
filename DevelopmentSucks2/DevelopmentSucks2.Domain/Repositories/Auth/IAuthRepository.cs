using DevelopmentSucks2.Domain.Entities;

namespace DevelopmentSucks2.Domain.Repositories.Auth;

/// <summary>
/// Репозиторий для работы с аутентификацией пользователей.
/// </summary>
public interface IAuthRepository
{
    /// <summary>
    /// Регистрирует нового пользователя в базе данных.
    /// </summary>
    /// <param name="user">Объект пользователя для сохранения.</param>
    /// <returns>
    /// <see cref="Guid"/> — идентификатор созданного пользователя, 
    /// или <c>null</c>, если регистрация не удалась.
    /// </returns>
    Task<Guid?> RegisterAsync(User user);

    /// <summary>
    /// Выполняет аутентификацию пользователя по имени и паролю.
    /// </summary>
    /// <param name="username">Имя пользователя.</param>
    /// <param name="password">Пароль пользователя.</param>
    /// <returns>
    /// Объект <see cref="User"/>, если аутентификация прошла успешно; 
    /// иначе <c>null</c>.
    /// </returns>
    Task<User?> LoginAsync(string username, string password);
}
