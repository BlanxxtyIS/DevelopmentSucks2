namespace DevelopmentSucks2.Application.DTOs;

public class ChapterDto
{
    public Guid? Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public int Order { get; set; }
    public Guid CourseId { get; set; }
}
