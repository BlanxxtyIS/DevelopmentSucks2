using DevelopmentSucks2.Application.DTOs;
using DevelopmentSucks2.Application.Services.Interfaces;
using DevelopmentSucks2.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace DevelopmentSucks2.API.Controllers;

[ApiController]
[Route("[controller]")]
public class CoursesController : ControllerBase
{
    private readonly ICoursesService _coursesService;

    public CoursesController(ICoursesService coursesService)
    {
        _coursesService = coursesService;
    }

    [HttpGet]
    public async Task<ActionResult<List<Course>>> GetAllCourses()
    {
        var courses = await _coursesService.GetAllCourses();

        return Ok(courses);
    }

    [HttpGet("{id:guid}")]
    public async Task<ActionResult<Course>> GetCourseById(Guid id)
    {
        var course = await _coursesService.GetCourseById(id);

        return course != null ? Ok(course) : NotFound();
    }

    [HttpPost]
    public async Task<ActionResult<Guid>> CreateCourse([FromBody] CourseDto courseDto)
    {
        var course = new Course
        {
            Id = Guid.NewGuid(),
            Title = courseDto.Title,
            Description = courseDto.Description,
        };

        var createdCourse = await _coursesService.CreateCourse(course);

        return CreatedAtAction(
            nameof(GetCourseById),
            new { id = createdCourse },
            createdCourse);
    }

    [HttpPut("{id:guid}")]
    public async Task<ActionResult> UpdateCourse(Guid id, [FromBody] CourseDto courseDto)
    {
        var course = new Course
        {
            Id = id,
            Title = courseDto.Title,
            Description = courseDto.Description
        };

        var updatedCourse = await _coursesService.UpdateCourse(course);

        return updatedCourse ? NoContent() : NotFound();
    }

    [HttpDelete("{id:guid}")]
    public async Task<ActionResult> DeleteCourse(Guid id)
    {
        var deletedCourse = await _coursesService.DeleteCourse(id);
        return deletedCourse ? NoContent() : NotFound();
    }
}

