using DevelopmentSucks2.Domain.Entities;

namespace DevelopmentSucks2.Application.Services.Interfaces;

/// <summary>
/// Сервис для управления уроками.
/// </summary>
public interface ILessonsService
{
    /// <summary>
    /// Создает новый урок.
    /// </summary>
    /// <param name="lesson">Урок который нужно создать.</param>
    /// <returns>Guid - Id созданного урока.</returns>
    Task<Guid> CreateLesson(Lesson lesson);

    /// <summary>
    /// Получить коллекцию уроков.
    /// </summary>
    /// <returns>Коллекция уроков или null.</returns>
    Task<List<Lesson>> GetAllLessons();

    /// <summary>
    /// Получить урок по Id.
    /// </summary>
    /// <param name="id">Id требуемого урока.</param>
    /// <returns>Урок или null.</returns>
    Task<Lesson?> GetLessonById(Guid id);

    /// <summary>
    /// Обновить урок.
    /// </summary>
    /// <param name="lesson">Обновленный урок.</param>
    /// <returns><c>true</c>, если удалось обновить урок, иначе: <c>false</c>.</returns>
    Task<bool> UpdateLesson(Lesson lesson);

    /// <summary>
    /// Удаляет урок по Id.
    /// </summary>
    /// <param name="id">Id урока который нужно удалить.</param>
    /// <returns><c>true</c>, если удалось удалить, иначе: <c>false</c>.</returns>
    Task<bool> DeleteLesson(Guid id);
}