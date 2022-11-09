using Domain.Infraestructure.Notification;
using Domain.Repository;
using Microsoft.Extensions.DependencyInjection;
using Npgsql;
using System.Data;

namespace JogoCartasAPI.Config
{
    public static class ResolveDependencyConfig
    {
        public static void ResolveDependency(this IServiceCollection services) 
        {
            services.AddScoped<IDbConnection, NpgsqlConnection>();

            services.AddScoped<INotification, Notification>();
            services.AddScoped<TipoJogoRepository>();
            services.AddScoped<CartaRepository>();
            services.AddScoped<JogoRepository>();
        }
    }
}
