using DevelopmentSucks2.Domain.Entities;

namespace DevelopmentSucks2.Domain.Repositories;

/// <summary>
/// Репозиторий для работы с Users в базе данных.
/// </summary>
public interface IUsersRepository
{
    /// <summary>
    /// Получает всех пользователей из базы данных.
    /// </summary>
    /// <returns>Коллекцию пользователей или null./</returns>
    Task<List<User>> GetAllUsers();

    /// <summary>
    /// Получает пользователя по Id.
    /// </summary>
    /// <param name="id">Id пользователя.</param>
    /// <returns>Возвращает User или null.</returns>
    Task<User?> GetUserById(Guid id);
}
