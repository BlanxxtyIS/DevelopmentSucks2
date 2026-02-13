using DevelopmentSucks2.Application.DTOs;
using DevelopmentSucks2.Application.Services.Interfaces;
using DevelopmentSucks2.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace DevelopmentSucks2.API.Controllers;

[ApiController]
[Route("[controller]")]
public class ChaptersController: ControllerBase
{
    private IChaptersService _chapterService;

    public ChaptersController(IChaptersService chapterService)
    {
        _chapterService = chapterService;
    }

    [HttpGet]
    public async Task<ActionResult<List<Chapter>>> GetAllChapters()
    {
        var chapters = await _chapterService.GetAllChapters();

        return chapters;
    }

    [HttpGet("{id:guid}")]
    public async Task<ActionResult<Chapter>> GetChapterById(Guid id)
    {
        var chapter = await _chapterService.GetChapterById(id);

        return chapter;
    }

    [HttpPost]
    public async Task<ActionResult<Guid>> CreateChapter([FromBody] ChapterDto chapterDto)
    {
        var chapter = new Chapter
        {
            Id = Guid.NewGuid(),
            Title = chapterDto.Title,
            Order = chapterDto.Order,
            CourseId = chapterDto.CourseId,
        };

        var createdChapter = await _chapterService.CreateChapter(chapter);

        return CreatedAtAction(
            nameof(GetChapterById),
            new { id = createdChapter },
            createdChapter);
    }

    [HttpPut("{id:guid}")]
    public async Task<ActionResult> UpdateChapter(Guid id, [FromBody] ChapterDto chapterDto)
    {
        var chapter = new Chapter
        {
            Id = id,
            Title = chapterDto.Title,
            Order = chapterDto.Order,
            CourseId = chapterDto.CourseId,
        };

        var updatedChapter = await _chapterService.UpdateChapter(chapter);

        return updatedChapter ? NoContent() : NotFound();
    }

    [HttpDelete("{id:guid}")]
    public async Task<ActionResult> DeleteChapter(Guid id)
    {
        var deletedChapter = await _chapterService.DeleteChapter(id);

        return deletedChapter ? NoContent() : NotFound();
    }
}
