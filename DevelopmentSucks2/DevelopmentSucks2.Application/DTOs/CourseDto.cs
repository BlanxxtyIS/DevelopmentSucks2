using DevelopmentSucks2.Domain.Entities;

namespace DevelopmentSucks2.Application.DTOs;

public class CourseDto
{
    public Guid? Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
}
