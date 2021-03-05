using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OnlinePremios.Data.Orm;

namespace OnlinePremio.Mvc.Configurations
{
    public static class MyDataContextConfig
    {
        public static IServiceCollection AddMyDataContextConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<OnlinePremiosContext>(options =>
                options.UseSqlServer(
                    configuration.GetConnectionString("DefaultConnection")));

            return services;
        }
    }
}
