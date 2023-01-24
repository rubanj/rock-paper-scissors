using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Roshambo.Infrastructure.Data;

namespace Roshambo.Infrastructure.Extensions.ServiceCollections
{
    public static class DatabaseContext
    {
        public static IServiceCollection AddDbContexts(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<SoundBeatsDbContext>(options => {
                // Add the DbConnector for your project
                options.UseSqlServer(configuration.GetConnectionString("SoundBeatsConnection"));
            });
            return services;
        }
    }
}
