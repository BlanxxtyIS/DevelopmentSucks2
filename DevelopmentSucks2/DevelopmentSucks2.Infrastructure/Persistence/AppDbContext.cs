using DevelopmentSucks2.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DevelopmentSucks2.Infrastructure.Persistence;

public class AppDbContext: DbContext 
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Course> Courses { get; set; }
    public DbSet<Chapter> Chapters { get; set; }
    public DbSet<Lesson> Lessons { get; set; }
}
