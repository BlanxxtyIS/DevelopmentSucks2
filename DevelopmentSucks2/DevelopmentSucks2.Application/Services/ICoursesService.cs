using DevelopmentSucks2.Domain.Entities;

namespace DevelopmentSucks2.Application.Services
{
    public interface ICoursesService
    {
        Task<Guid> CreateCourse(Course course);
        Task<bool> DeleteCourse(Guid id);
        Task<List<Course>> GetAllCourses();
        Task<Course?> GetCourseById(Guid id);
        Task<bool> UpdateCourse(Course course);
    }
}