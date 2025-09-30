using DevelopmentSucks2.Application.Services.Interfaces;
using DevelopmentSucks2.Domain.Entities;
using DevelopmentSucks2.Domain.Repositories;

namespace DevelopmentSucks2.Application.Services;

public class LessonsService : ILessonsService
{
    private readonly ILessonsRepository _repository;

    public LessonsService(ILessonsRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<Lesson>> GetAllLessons()
    {
        try
        {
            return await _repository.GetLessons();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
            throw;
        }
    }

    public async Task<Lesson?> GetLessonById(Guid id)
    {
        try
        {
            return await _repository.GetLessons(id);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
            throw;
        }
    }

    public async Task<Guid> CreateLesson(Lesson lesson)
    {
        try
        {
            return await _repository.CreateLesson(lesson);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
            throw;
        }
    }

    public async Task<bool> UpdateLesson(Lesson lesson)
    {
        try
        {
            return await _repository.UpdateLesson(lesson);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
            throw;
        }
    }

    public async Task<bool> DeleteLesson(Guid id)
    {
        try
        {
            return await _repository.DeleteLesson(id);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
            throw;
        }
    }
}
