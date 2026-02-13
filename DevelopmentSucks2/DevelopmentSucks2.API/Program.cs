using DevelopmentSucks2.API.Extensions;
using DevelopmentSucks2.Application;
using DevelopmentSucks2.Infrastructure;
using DevelopmentSucks2.Infrastructure.Persistence;
using DevelopmentSucks2.Infrastructure.Persistence.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

var connString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<AppDbContext>(options => 
    options.UseNpgsql(connString)

);

builder.Services.AddApplication();
builder.Services.AddInfrastructure();

builder.Services.Configure<JwtSettings>(
    builder.Configuration.GetSection("JwtSettings"));

builder.Services.ConfigureJWT(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
