using Megalopolis.Data;
using Microsoft.EntityFrameworkCore;

namespace Megalopolis.Extensions;

public static class ExtensionsConnect
{
    public static IServiceCollection AddDataBaseConection(this IServiceCollection services, IConfiguration config)
    {
        services.AddDbContext<DataContext>(options =>
        {
            options.UseSqlServer(config.GetConnectionString("DefaultConnection"));
        });

        return services;
    }
}
