using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Repository.Context;
using Repository.Interfaces;
using Repository.RepositoriesClasses;
using Services.Interfaces;

namespace Services.DIP
{
    public class Initializer
    {
        public static void Configure(IServiceCollection services, string connection)
        {
            services.AddDbContext<AnimalContext>(options => options.UseSqlServer(connection));

            services.AddScoped(typeof(IRepository<Animal>), typeof(AnimalRepository));
            services.AddScoped(typeof(IService<Animal>), typeof(AnimalServices));
        }
    }
}