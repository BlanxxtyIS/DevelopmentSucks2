using DevelopmentSucks2.Domain.Entities;

namespace DevelopmentSucks2.Domain.Repositories;

public interface ILessonsRepository
{
    Task<Guid> CreateLesson(Lesson lesson);
    Task<bool> DeleteLesson(Guid id);
    Task<List<Lesson>> GetLessons();
    Task<Lesson?> GetLessons(Guid id);
    Task<bool> UpdateLesson(Lesson lesson);
}
