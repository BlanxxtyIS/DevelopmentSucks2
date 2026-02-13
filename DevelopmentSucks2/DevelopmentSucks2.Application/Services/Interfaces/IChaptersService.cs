using DevelopmentSucks2.Domain.Entities;

namespace DevelopmentSucks2.Application.Services.Interfaces;

/// <summary>
/// Сервис по управлению главами курсов.
/// </summary>
public interface IChaptersService
{
    /// <summary>
    /// Создает новую главу.
    /// </summary>
    /// <param name="chapter">Объект главу, которую нужно создать.</param>
    /// <returns>Guid - Id созданной главы.</returns>
    Task<Guid> CreateChapter(Chapter chapter);

    /// <summary>
    /// Получает список всех глав.
    /// </summary>
    /// <returns>Список глав.</returns>
    Task<List<Chapter>> GetAllChapters();

    /// <summary>
    /// Получает главу по ID
    /// </summary>
    /// <param name="id">Id главы.</param>
    /// <returns>Объект главы, если найдена.</returns>
    Task<Chapter> GetChapterById(Guid id);

    /// <summary>
    /// Обновляет главу.
    /// </summary>
    /// <param name="chapter">Обновленная глава.</param>
    /// <returns><c>true</c>, если обновление прошло успешно; иначе<c>false</c>.</returns>
    Task<bool> UpdateChapter(Chapter chapter);

    /// <summary>
    /// Удаляет главу по Id.
    /// </summary>
    /// <param name="id">Id удаляемой главы.</param>
    /// <returns><c>true</c>, если глава удалена; иначе <c>false</c>.</returns>
    Task<bool> DeleteChapter(Guid id);
}