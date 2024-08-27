using Application.Data.Repositories;
using Application.Mappings;
using AutoMapper;
using Infrastructure.Data.Repositories;

namespace WebMVC.ConfigureHost
{
    public static class ConfigureMapper
    {
        public static IServiceCollection AddMapper(this IServiceCollection services)
        {
            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new AutoMapperProfile());
            });

            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);
            return services;
        }
    }
}
