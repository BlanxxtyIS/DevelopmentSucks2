namespace DevelopmentSucks2.Application.DTOs;

public class LessonDto
{
    public Guid? Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
    public int Order { get; set; }
    public Guid ChapterId { get; set; }
}
