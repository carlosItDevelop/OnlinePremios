using AutoMapper;
using LanchesMac.Repositories;
using LanchesMac.Repositories.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OnlinePremio.InversionOfControl.IoC;
using OnlinePremio.Mvc.Configurations;
using OnlinePremio.Mvc.Models;

namespace OnlinePremio.Mvc
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IWebHostEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", true, true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", true, true)
                .AddEnvironmentVariables();
            if (env.IsProduction()) // Todo: Considerar usar IsDevelopment
            {
                builder.AddUserSecrets<Startup>();
            }

            Configuration = builder.Build();
        }

        
        public void ConfigureServices(IServiceCollection services)
        {
            // Configurations=>ExtensionMethods
            // --------------------------------
            services.AddDependencyInjection();
            services.AddIdentityConfiguration(Configuration);
            services.AddMyDataContextConfiguration(Configuration);



            services.ConfigureApplicationCookie(options => options.AccessDeniedPath = "/Home/AccessDenied");
            services.Configure<ConfigurationImagens>(Configuration.GetSection("ConfigurationPastaImagens"));

            services.AddAutoMapper(typeof(Startup));

            services.AddMsgMvcConfiguration();

            services.AddDistributedMemoryCache();


            services.AddDistributedMemoryCache();

            // Todo: Depois migrar para os locais corretos, fora do Mvc
            services.AddTransient<ILancheRepository, LancheRepository>();
            services.AddTransient<ICategoriaRepository, CategoriaRepository>();
            services.AddTransient<IPedidoRepository, PedidoRepository>();

            //services.AddScoped<RelatorioVendasService>();

            //cria um objeto Scoped, ou seja um objeto que esta associado a requisição
            //isso significa que se duas pessoas solicitarem o objeto CarrinhoCompra ao  mesmo tempo
            //elas vão obter instâncias diferentes
            services.AddScoped(sp => CarrinhoCompra.GetCarrinho(sp));


            services.AddControllersWithViews();
            //services.AddPaging(options => {
            //    options.ViewName = "Bootstrap4";
            //    options.PageParameterName = "pageindex";
            //});

            //configura o uso da Sessão
            services.AddMemoryCache();
            services.AddSession();


            services.AddRazorPages();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/erro/500");
                app.UseStatusCodePagesWithRedirects("/erro/{0}");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseSession();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseGlobalizationConfig();


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "AdminArea",
                    pattern: "{area:exists}/{controller=Admin}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(name: "categoriaFiltro",
                   pattern: "Lanche/{action}/{categoria?}",
                   defaults: new { Controller = "Lanche", action = "List" });

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

                endpoints.MapRazorPages();


            });

        }
    }
}
