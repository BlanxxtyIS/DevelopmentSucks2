using DevelopmentSucks2.Domain.Entities;
namespace DevelopmentSucks2.Domain.Repositories;

/// <summary>
/// Репозиторий для работы с курсами в бд.
/// </summary>
public interface ICoursesRepository
{
    /// <summary>
    /// Добавляет новый курс в базу данных.
    /// </summary>
    /// <param name="course">Курс для сохранения.</param>
    /// <returns>Id сохраненной главы.</returns>
    Task<Guid> CreateCourse(Course course);

    /// <summary>
    /// Получает курс из базы данных по Id.
    /// </summary>
    /// <param name="id">Id курса.</param>
    /// <returns>Курс - если найдена, иначе - null.</returns>
    Task<Course?> GetCourse(Guid id);

    /// <summary>
    /// Получает курсы из базы данных.
    /// </summary>
    /// <returns>Коллекцию курсов, иначе - null.</returns>
    Task<List<Course>> GetCourses();

    /// <summary>
    /// Обновляет существующий курс в базе данных.
    /// </summary>
    /// <param name="course">Обновленный курс.</param>
    /// <returns><c>true</c>, если обновление прошло успешно, иначе <c>false</c>.</returns>
    Task<bool> UpdateCourse(Course course);

    /// <summary>
    /// Удаляет курс из базы данных по Id.
    /// </summary>
    /// <param name="id">Id удаляемой главы.</param>
    /// <returns><c>true</c>, если удаление прошло успешно; иначе <c>false</c>.</returns>
    Task<bool> DeleteCourse(Guid id);
}
