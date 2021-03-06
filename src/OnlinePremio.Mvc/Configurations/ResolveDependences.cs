using Microsoft.Extensions.DependencyInjection;
using OnlinePremios.Data.Orm;
using OnlinePremios.Domain.Interfaces;
using OnlinePremios.Domain.Notifications;
using OnlinePremios.Domain.Services;
using OnlinePremios.Repository;

namespace OnlinePremio.Mvc.Configurations
{
    public static class ResolveDependences
    {

        public static IServiceCollection AddDependencyInjection(this IServiceCollection services)
        {
            // DI : Todo Criar Extension Method to DI too
            services.AddScoped<OnlinePremiosContext>();
            services.AddScoped<INotificator, Notificator>();

            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<IProdutoService, ProdutoService>();

            return services;

        }



    }
}
