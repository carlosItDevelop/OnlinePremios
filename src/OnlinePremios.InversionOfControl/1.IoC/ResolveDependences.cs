﻿
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using OnlinePremios.Data.Orm;
using OnlinePremios.Domain.Interfaces.Notify;
using OnlinePremios.Domain.Interfaces.Repositories;
using OnlinePremios.Domain.Interfaces.Services;
using OnlinePremios.Domain.Notifications;
using OnlinePremios.Domain.Services;
using OnlinePremios.Repository;

namespace OnlinePremios.InversionOfControl.IoC
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

            // Todo: Not is use. I need implement
            services.AddScoped<ICotaItemRepository, CotaItemRepository>();
            services.AddScoped<ICotaItemService, CotaItemService>();


            // fornece uma instancia de HttpContextAcessor
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();




            return services;

        }

    }
}
