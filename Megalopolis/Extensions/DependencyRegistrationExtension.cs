using Megalopolis.Help;

namespace Megalopolis.Extensions;

public static class DependencyRegistrationExtension
{
    public static IServiceCollection RegistrerDependencies(this IServiceCollection services)
    {
        services.AddAutoMapper(typeof(AutoMapperProfile).Assembly);
        return services;
    }
}
