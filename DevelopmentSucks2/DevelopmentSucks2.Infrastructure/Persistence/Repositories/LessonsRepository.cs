using DevelopmentSucks2.Domain.Entities;
using DevelopmentSucks2.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace DevelopmentSucks2.Infrastructure.Persistence.Repositories;

public class LessonsRepository : ILessonsRepository
{
    private AppDbContext _context;

    public LessonsRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<Lesson>> GetLessons()
    {
        var lessons = await _context.Lessons
            .AsNoTracking()
            .ToListAsync();

        return lessons;
    }

    public async Task<Lesson?> GetLessons(Guid id)
    {
        var lesson = await _context.Lessons
            .FindAsync(id);

        return lesson;
    }

    public async Task<Guid> CreateLesson(Lesson lesson)
    {
        await _context.Lessons.AddAsync(lesson);
        await _context.SaveChangesAsync();

        return lesson.Id;
    }

    public async Task<bool> UpdateLesson(Lesson lesson)
    {
        var updated = await _context.Lessons.FindAsync(lesson.Id);
        if (updated == null) return false;

        updated.Title = lesson.Title;
        updated.Content = lesson.Content;
        updated.Order = lesson.Order;
        updated.ChapterId = lesson.ChapterId;

        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<bool> DeleteLesson(Guid id)
    {
        var deleted = await _context.Lessons
            .Where(c => c.Id == id)
            .ExecuteDeleteAsync();

        return deleted > 0;
    }
}
