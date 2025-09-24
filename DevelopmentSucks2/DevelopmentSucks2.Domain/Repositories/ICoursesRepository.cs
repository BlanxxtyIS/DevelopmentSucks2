using DevelopmentSucks2.Domain.Entities;
namespace DevelopmentSucks2.Domain.Repositories;

public interface ICoursesRepository
{
    Task<Guid> CreateCourse(Course course);
    Task<bool> DeleteCourse(Guid id);
    Task<Course?> GetCourse(Guid id);
    Task<List<Course>> GetCourses();
    Task<bool> UpdateCourse(Course course);
}
