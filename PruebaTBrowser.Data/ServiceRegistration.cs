using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PruebaTBrowser.Data.Repositories.Persistence.Repositories;
using PruebaTBrowser.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PruebaTBrowser.Data
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddServiceRegistration(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<PruebaDbContext>(options =>
                options.UseMySQL(configuration.GetConnectionString("DBConnection")));

            services.AddScoped(typeof(IRepository<,>), typeof(Repository<,>));


            return services;
        }
    }
}
