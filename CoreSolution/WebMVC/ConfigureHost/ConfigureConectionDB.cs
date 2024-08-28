using Application.Data.Repositories;
using AutoMapper;
using Infrastructure;
using Infrastructure.Data.Repositories;
using Microsoft.EntityFrameworkCore;

namespace WebMVC.ConfigureHost
{
    public static class ConfigureConectionDB
    {
        public static void ConfigureDbContext(IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer(connectionString, b => b.MigrationsAssembly("WebMVC"));
            });
        }
    }
}
