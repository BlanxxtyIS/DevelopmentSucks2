using DevelopmentSucks2.Domain.Entities;

namespace DevelopmentSucks2.Application.Services.Interfaces;

/// <summary>
/// Сервис для управления пользователями.
/// </summary>
public interface IUsersService
{
    /// <summary>
    /// Получает всех пользователей.
    /// </summary>
    /// <returns>Коллекция пользователей или null.</returns>
    Task<List<User>> GetAllUsers();

    /// <summary>
    /// Получает пользователя по Id.
    /// </summary>
    /// <param name="id">Id пользователя.</param>
    /// <returns>Возвращает User или null.</returns>
    Task<User?> GetUserById(Guid id);
}