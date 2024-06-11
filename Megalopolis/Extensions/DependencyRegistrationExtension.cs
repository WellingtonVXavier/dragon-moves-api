using Megalopolis.Helpers;
using Megalopolis.Repository;
using Megalopolis.Service;

namespace Megalopolis.Extensions;

public static class DependencyRegistrationExtension
{
    public static IServiceCollection RegistrerDependencies(this IServiceCollection services)
    {
        services.AddScoped<FilmesService>();
        services.AddScoped<FilmesRepository>();
        services.AddAutoMapper(typeof(AutoMapperProfile).Assembly);

        return services;
    }
}
