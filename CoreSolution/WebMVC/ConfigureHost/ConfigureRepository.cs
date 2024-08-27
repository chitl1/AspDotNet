using Application.Data.Repositories;
using Infrastructure.Data.Repositories;

namespace WebMVC.ConfigureHost
{
    public static class ConfigureRepository
    {
        public static IServiceCollection AddRepository(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IProductRepository, ProductRepository>();
            return services;
        }
    }
}
