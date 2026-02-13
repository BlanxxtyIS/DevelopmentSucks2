using DevelopmentSucks2.Domain.Repositories;
using DevelopmentSucks2.Domain.Repositories.Auth;
using DevelopmentSucks2.Infrastructure.Persistence.Identity;
using DevelopmentSucks2.Infrastructure.Persistence.Repositories;
using DevelopmentSucks2.Infrastructure.Persistence.Repositories.Auth;
using Microsoft.Extensions.DependencyInjection;

namespace DevelopmentSucks2.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddScoped<ICoursesRepository, CoursesRepository>();
        services.AddScoped<IChaptersRepository, ChaptersRepository>();
        services.AddScoped<IAuthRepository, AuthRepository>();
        services.AddScoped<IPasswordHasher, PasswordHasher>();
        services.AddScoped<IJwtRepository, JwtRepository>(); 
        services.AddScoped<IUsersRepository, UsersRepository>();

        return services;
    }
}
