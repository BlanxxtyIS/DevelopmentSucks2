using DevelopmentSucks2.Domain.Entities;

namespace DevelopmentSucks2.Application.Services.Interfaces;

/// <summary>
/// Сервис по управлению курсами. 
/// </summary>
public interface ICoursesService
{
    /// <summary>
    /// Создает новый курс.
    /// </summary>
    /// <param name="course">Курс который нужно создать.</param>
    /// <returns>Guid - Id созданной главы.</returns>
    Task<Guid> CreateCourse(Course course);

    /// <summary>
    /// Получает колекцию всех курсов.
    /// </summary>
    /// <returns>Список курсов или null.</returns>
    Task<List<Course>> GetAllCourses();

    /// <summary>
    /// Получает курс по Id.
    /// </summary>
    /// <param name="id">Id требуемого курса.</param>
    /// <returns>Курс или null.</returns>
    Task<Course?> GetCourseById(Guid id);

    /// <summary>
    /// Обновляет курс.
    /// </summary>
    /// <param name="course">Обновляемый курс.</param>
    /// <returns><c>true</c>, если удалось обновить курс, иначе:<c>false</c>.</returns>
    Task<bool> UpdateCourse(Course course);

    /// <summary>
    /// Удаляет курс по Id.
    /// </summary>
    /// <param name="id">Id курса который необходимо удалить.</param>
    /// <returns><c>true</c>, если удалось удалить курс, иначе:<c>false</c>.</returns>
    Task<bool> DeleteCourse(Guid id);
}