using ListGenius.Domain.Abstractions;
using ListGenius.Infrastructure.Context;
using ListGenius.Infrastructure.Repositories;
using ListGenius.Application.Abstractions;
using ListGenius.Application.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ListGenius.CrossCutting.DependenciesApp;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(
                                     this IServiceCollection services,
                                     IConfiguration configuration)
    {
        var connectionString = configuration
                      .GetConnectionString("Sqlite");

        services.AddDbContext<ApplicationDbContext>(opt =>
                             opt.UseSqlite(connectionString));

        services.AddScoped<ILivroRepository, LivroRepository>();
        services.AddScoped<ILivroService, LivroService>();

        return services;
    }
}
