using DevelopmentSucks2.Domain.Entities;

namespace DevelopmentSucks2.Domain.Repositories;

/// <summary>
/// Репозиторий для работы с уроками в бд.
/// </summary>
public interface ILessonsRepository
{
    /// <summary>
    /// Добавляет урок в базу данных.
    /// </summary>
    /// <param name="lesson">Урок для сохранения.</param>
    /// <returns>Id сохраненного урока.</returns>
    Task<Guid> CreateLesson(Lesson lesson);

    /// <summary>
    /// Получает коллекцию уроков из базы данных по Id.
    /// </summary>
    /// <returns>Коллекция уроков - если найден, если нет - null.</returns>
    Task<List<Lesson>> GetLessons();

    /// <summary>
    /// Получает урок по Id.
    /// </summary>
    /// <param name="id">Id главы.</param>
    /// <returns>Возвращает урок если найден, иначе: null.</returns>
    Task<Lesson?> GetLessons(Guid id);

    /// <summary>
    /// Обновляет существующий урок в базе данных.
    /// </summary>
    /// <param name="lesson">Обновленный урок.</param>
    /// <returns><c>true</c>, если обновление прошло успешно; иначе <c>false</c>.</returns>
    Task<bool> UpdateLesson(Lesson lesson);

    /// <summary>
    /// Удаляет существующий урок в базе данных.
    /// </summary>
    /// <param name="id">Id удаляемого урока.</param>
    /// <returns><c>true</c>, если обновление прошло успешно; иначае <c>false</c>.</returns>
    Task<bool> DeleteLesson(Guid id);
}
