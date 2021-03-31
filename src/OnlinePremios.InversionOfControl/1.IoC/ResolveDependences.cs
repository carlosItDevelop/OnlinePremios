
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using OnlinePremios.Data.Orm;
using OnlinePremios.Domain.Entities.bcCompra;
using OnlinePremios.Domain.Interfaces.Notify;
using OnlinePremios.Domain.Interfaces.Repositories;
using OnlinePremios.Domain.Interfaces.Services;
using OnlinePremios.Domain.Notifications;
using OnlinePremios.Domain.Services;
using OnlinePremios.Repository;

namespace OnlinePremio.InversionOfControl.IoC
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


            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<IClienteService, ClienteService>();

            services.AddScoped<ICotaRepository, CotaRepository>();
            services.AddScoped<ICotaService, CotaService>();

            services.AddScoped<ISorteioRepository, SorteioRepository>();
            services.AddScoped<ISorteioService, SorteioService>();

            //fornece uma instancia de HttpContextAcessor
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();


            //cria um objeto Scoped, ou seja um objeto que esta associado a requisição
            //isso significa que se duas pessoas solicitarem o objeto CarrinhoCompra ao  mesmo tempo
            //elas vão obter instâncias diferentes
            services.AddScoped(sp => CarrinhoCompra.GetCarrinho(sp));

            //configura o uso da Sessão
            services.AddMemoryCache();
            services.AddSession();


            return services;

        }

    }
}
