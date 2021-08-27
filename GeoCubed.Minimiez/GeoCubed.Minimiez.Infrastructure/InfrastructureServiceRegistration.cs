using GeoCubed.Minimiez.Application.Interfaces;
using GeoCubed.Minimiez.Infrastructure.DatabaseConnector;
using GeoCubed.Minimiez.Infrastructure.DatabaseConnector.SQLite;
using GeoCubed.Minimiez.Infrastructure.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GeoCubed.Minimiez.Infrastructure
{
    public static class InfrastructureServiceRegistration
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IAsyncRepository, BaseRepository>();
            services.AddScoped<IGroupRepository, GroupRepository>();
            services.AddScoped<ITeamRepository, TeamRepository>();
            services.AddScoped<IPlayerRepository, PlayerRepository>();
            services.AddScoped<IDatabaseConnector>(x => new SQLiteDatabaseConnector(configuration.GetConnectionString("sqlite")));

            return services;
        }
    }
}
