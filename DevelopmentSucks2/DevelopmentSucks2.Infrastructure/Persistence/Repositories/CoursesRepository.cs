using DevelopmentSucks2.Domain.Entities;
using DevelopmentSucks2.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace DevelopmentSucks2.Infrastructure.Persistence.Repositories;

public class CoursesRepository : ICoursesRepository
{
    private readonly AppDbContext _context;

    public CoursesRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<Course>> GetCourses()
    {
        var courses = await _context.Courses
            .AsNoTracking()
            .ToListAsync();

        return courses;
    }

    public async Task<Course?> GetCourse(Guid id)
    {
        var course = await _context.Courses
            .FindAsync(id);

        return course;
    }

    public async Task<Guid> CreateCourse(Course course)
    {
        await _context.Courses.AddAsync(course);
        await _context.SaveChangesAsync();

        return course.Id;
    }

    public async Task<bool> UpdateCourse(Course course)
    {
        var updated = await _context.Courses.FindAsync(course.Id);
        if (updated == null) return false;

        updated.Title = course.Title;
        updated.Description = course.Description;

        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<bool> DeleteCourse(Guid id)
    {
        var deleted = await _context.Courses
            .Where(c => c.Id == id)
            .ExecuteDeleteAsync();

        return deleted > 0;
    }
}
