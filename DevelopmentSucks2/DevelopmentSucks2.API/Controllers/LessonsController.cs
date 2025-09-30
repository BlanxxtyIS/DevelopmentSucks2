using DevelopmentSucks2.Application.DTOs;
using DevelopmentSucks2.Application.Services.Interfaces;
using DevelopmentSucks2.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace DevelopmentSucks2.API.Controllers;

[ApiController]
[Route("[controller]")]
public class LessonsController: ControllerBase
{
    private readonly ILessonsService _lessonsService;

    public LessonsController(ILessonsService lessonsService)
    {
        _lessonsService = lessonsService;
    }

    [HttpGet]
    public async Task<ActionResult<List<Course>>> GetAllLessons()
    {
        var courses = await _lessonsService.GetAllLessons();

        return Ok(courses);
    }

    [HttpGet("{id:guid}")]
    public async Task<ActionResult<Lesson>> GetLessonById(Guid id)
    {
        var lesson = await _lessonsService.GetLessonById(id);

        return lesson != null ? Ok(lesson) : NotFound();
    }

    [HttpPost]
    public async Task<ActionResult<Guid>> CreateLesson([FromBody] LessonDto lessonDto)
    {
        var lesson = new Lesson
        {
            Id = Guid.NewGuid(),
            Title = lessonDto.Title,
            Order = lessonDto.Order,
            Content = lessonDto.Content,
            ChapterId = lessonDto.ChapterId
        };

        var createdLesson = await _lessonsService.CreateLesson(lesson);

        return CreatedAtAction(
            nameof(GetLessonById),
            new { id = createdLesson },
            createdLesson);
    }

    [HttpPut("{id:guid}")]
    public async Task<ActionResult> UpdateLesson(Guid id, [FromBody] LessonDto lessonDto)
    {
        var lesson = new Lesson
        {
            Id = id,
            Title = lessonDto.Title,
            Order = lessonDto.Order,
            Content = lessonDto.Content,
            ChapterId = lessonDto.ChapterId
        };

        var updatedLesson = await _lessonsService.UpdateLesson(lesson);

        return updatedLesson ? NoContent() : NotFound();
    }

    [HttpDelete("{id:guid}")]
    public async Task<ActionResult> DeleteLesson(Guid id)
    {
        var deletedLesson = await _lessonsService.DeleteLesson(id);
        return deletedLesson ? NoContent() : NotFound();
    }
}
