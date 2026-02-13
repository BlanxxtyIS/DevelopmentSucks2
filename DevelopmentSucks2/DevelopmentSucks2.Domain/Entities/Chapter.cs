using System.ComponentModel.DataAnnotations.Schema;

namespace DevelopmentSucks2.Domain.Entities;

public class Chapter
{
    public Guid Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public int Order { get; set; }
    public Guid CourseId { get; set; }

    [ForeignKey(nameof(CourseId))]
    public Course? Course { get; set; }

    public List<Lesson> Lessons { get; set; } = new();
}
