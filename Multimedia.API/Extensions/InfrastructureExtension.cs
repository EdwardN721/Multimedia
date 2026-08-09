using Microsoft.EntityFrameworkCore;
using Multimedia.Infrastructure.Persistence;

namespace Multimedia.API.Extensions;

public static class InfrastructureExtension
{
    public static IServiceCollection AddDbContextConfiguration(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

        return services;
    }
}