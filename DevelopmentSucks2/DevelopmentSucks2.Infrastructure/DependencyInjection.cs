using DevelopmentSucks2.Domain.Repositories;
using DevelopmentSucks2.Infrastructure.Persistence.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace DevelopmentSucks2.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddScoped<ICoursesRepository, CoursesRepository>();
        services.AddScoped<IChaptersRepository, ChaptersRepository>();

        return services;
    }
}
