using DevelopmentSucks2.Application.Services;
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
    public async Task<ActionResult<Course>> GetCoursesById(Guid id)
    {
        var course = await _coursesService.GetCourseById(id);

        return course != null ? Ok(course) : NotFound();
    }

    [HttpPost]
    public async Task<ActionResult<Guid>> CreateCourse([FromBody] Course course)
    {
        if (course == null)
            return NotFound("Объект пустой");

        var createdCourse = await _coursesService.CreateCourse(course);
        return CreatedAtAction(
            nameof(GetCoursesById),
            new { id = createdCourse },
            createdCourse);
    }

    [HttpPut]
    public async Task<ActionResult> UpdateCourse([FromBody] Course course)
    {
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

