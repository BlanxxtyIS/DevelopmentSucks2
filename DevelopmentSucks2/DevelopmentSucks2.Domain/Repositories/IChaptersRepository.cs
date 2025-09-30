using DevelopmentSucks2.Domain.Entities;

namespace DevelopmentSucks2.Domain.Repositories;

/// <summary>
/// Репорзиторий для работы с главами курсов в бд.
/// </summary>
public interface IChaptersRepository
{
    /// <summary>
    /// Добавляет новую главу в базу данных.
    /// </summary>
    /// <param name="chapter">Глава для сохранения.</param>
    /// <returns>Id сохраненной главы.</returns>
    Task<Guid> CreateChapter(Chapter chapter);

    /// <summary>
    /// Получает главу из базы данных по Id.
    /// </summary>
    /// <param name="id">Id главы.</param>
    /// <returns>Глава - если найдена, если нет - null.</returns>
    Task<Chapter> GetChapter(Guid id);

    /// <summary>
    /// Получает главы из базы данных.
    /// </summary>
    /// <returns>Коллекцию глав или null.</returns>
    Task<List<Chapter>> GetChapters();

    /// <summary>
    /// Обновляет существующую главу в базе данных.
    /// </summary>
    /// <param name="chapter">Обновленная глава.</param>
    /// <returns><c>true</c>, если обновление прошло успешно; иначе <c>false</c>.</returns>
    Task<bool> UpdateChapter(Chapter chapter);

    /// <summary>
    /// Удаляет главу из базы данных по Id.
    /// </summary>
    /// <param name="id">Id удаляемой главы.</param>
    /// <returns><c>true</c>, если удаление прошло успешно; иначе <c>false</c>.</returns>
    Task<bool> DeleteChapter(Guid id);
}
