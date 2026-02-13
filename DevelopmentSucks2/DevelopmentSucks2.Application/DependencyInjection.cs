using DevelopmentSucks2.Application.Services;
using DevelopmentSucks2.Application.Services.Interfaces;
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
        services.AddScoped<IUsersService, UsersService>();  

        return services;
    }
}
