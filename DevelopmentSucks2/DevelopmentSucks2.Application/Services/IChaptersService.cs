using DevelopmentSucks2.Domain.Entities;

namespace DevelopmentSucks2.Application.Services
{
    public interface IChaptersService
    {
        Task<Guid> CreateChapter(Chapter chapter);
        Task<bool> DeleteChapter(Guid id);
        Task<List<Chapter>> GetAllChapters();
        Task<Chapter> GetChapterById(Guid id);
        Task<bool> UpdateChapter(Chapter chapter);
    }
}