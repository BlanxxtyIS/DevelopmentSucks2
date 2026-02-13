using DevelopmentSucks2.Application.Services.Interfaces;
using DevelopmentSucks2.Domain.Entities;
using DevelopmentSucks2.Domain.Repositories;

namespace DevelopmentSucks2.Application.Services;

public class ChaptersService : IChaptersService
{
    private readonly IChaptersRepository _repository;

    public ChaptersService(IChaptersRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<Chapter>> GetAllChapters()
    {
        try
        {
            return await _repository.GetChapters();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            throw;
        }
    }

    public async Task<Chapter> GetChapterById(Guid id)
    {
        try
        {
            return await _repository.GetChapter(id);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            throw;
        }
    }

    public async Task<Guid> CreateChapter(Chapter chapter)
    {
        try
        {
            return await _repository.CreateChapter(chapter);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
            throw;
        }
    }

    public async Task<bool> UpdateChapter(Chapter chapter)
    {
        try
        {
            return await _repository.UpdateChapter(chapter);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
            throw;
        }
    }

    public async Task<bool> DeleteChapter(Guid id)
    {
        try
        {
            return await _repository.DeleteChapter(id);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
            throw;
        }
    }
}
