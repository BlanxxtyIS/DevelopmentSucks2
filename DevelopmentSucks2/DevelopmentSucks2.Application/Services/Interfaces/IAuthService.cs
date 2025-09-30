using DevelopmentSucks2.Application.DTOs;
using DevelopmentSucks2.Domain.Entities;

namespace DevelopmentSucks2.Application.Services.Interfaces;

/// <summary>
/// Сервис для управления регистрацей и аутентификацией пользователей.
/// </summary>
public interface IAuthService
{
    /// <summary>
    /// Регистрирует нового пользователя.
    /// </summary>
    /// <param name="userDto">DTO с данными пользователя для регистрации.</param>
    /// <see cref="Guid"/> — идентификатор созданного пользователя,
    /// или <c>null</c>, если регистрация не удалась.
    /// </returns>
    Task<Guid?> RegisterUser(UserDto userDto);

    /// <summary>
    /// Выполняет аутентификацию пользователя по имени и паролю.
    /// </summary>
    /// <param name="username">Имя пользователя.</param>
    /// <param name="password">Пароль пользователя.</param>
    /// <returns>
    /// Объект <see cref="User"/>, если аутентификация успешна;
    /// иначе <c>null</c>.
    /// </returns>
    Task<User?> LoginAsync(string username, string password);
}