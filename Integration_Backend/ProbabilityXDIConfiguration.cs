using Microsoft.Extensions.DependencyInjection;
using ProbabilityX_API.IRepositories;
using ProbabilityX_API.IServices;
using ProbabilityX_API.Repositories;
using ProbabilityX_API.Services;

public static class ProbabilityXDIConfiguration
{
    public static void ConfigureDependencies(IServiceCollection services)
    {
        // Ajoute toutes les injections de dépendances nécessaires ici
        services.AddScoped<ITodoService, TodoService>();
        services.AddScoped<ITodoRepository, TodoRepository>();

        // Ajoute d'autres injections de dépendances au besoin
    }
}
