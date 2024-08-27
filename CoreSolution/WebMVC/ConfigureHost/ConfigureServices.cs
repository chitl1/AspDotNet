using Application.Services;
using Application.Services.Implements;

namespace WebMVC.ConfigureHost
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddProductServices(this IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductService>();
            return services;
        }
    }
}
