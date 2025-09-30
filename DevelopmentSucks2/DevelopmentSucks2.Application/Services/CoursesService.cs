using DevelopmentSucks2.Application.Services.Interfaces;
using DevelopmentSucks2.Domain.Entities;
using DevelopmentSucks2.Domain.Repositories;

namespace DevelopmentSucks2.Application.Services;

public class CoursesService : ICoursesService
{
    private readonly ICoursesRepository _repository;

    public CoursesService(ICoursesRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<Course>> GetAllCourses()
    {
        try
        {
            return await _repository.GetCourses();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
            throw;
        }
    }

    public async Task<Course?> GetCourseById(Guid id)
    {
        try
        {
            return await _repository.GetCourse(id);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
            throw;
        }
    }

    public async Task<Guid> CreateCourse(Course course)
    {
        try
        {
            return await _repository.CreateCourse(course);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
            throw;
        }
    }

    public async Task<bool> UpdateCourse(Course course)
    {
        try
        {
            return await _repository.UpdateCourse(course);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
            throw;
        }
    }

    public async Task<bool> DeleteCourse(Guid id)
    {
        try
        {
            return await _repository.DeleteCourse(id);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
            throw;
        }
    }
}
