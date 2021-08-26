using GeoCubed.Minimiez.Application.Interfaces;
using GeoCubed.Minimiez.Infrastructure.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace GeoCubed.Minimiez.Infrastructure
{
    public static class InfrastructureServiceRegistration
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IAsyncRepository, BaseRepository>();
            services.AddScoped<IGroupRepository, GroupRepository>();
            services.AddScoped<ITeamRepository, TeamRepository>();

            return services;
        }
    }
}
