using DevelopmentSucks2.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace DevelopmentSucks2.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<ICoursesService, CoursesService>();
        services.AddScoped<IChaptersService, ChaptersService>();
        services.AddScoped<IAuthService, AuthService>();
        services.AddScoped<IJwtService, JwtService>();

        return services;
    }
}
