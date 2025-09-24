using DevelopmentSucks2.Domain.Entities;

namespace DevelopmentSucks2.Domain.Repositories;

public interface IChaptersRepository
{
    Task<Guid> CreateChapter(Chapter chapter);
    Task<bool> DeleteChpater(Guid id);
    Task<Chapter> GetChapter(Guid id);
    Task<List<Chapter>> GetChapters();
    Task<bool> UpdateChapter(Chapter chapter);
}
