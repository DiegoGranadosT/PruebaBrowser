using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTBrowser.Application
{
    public static class AppApplicacionServices 
    {
        public static IServiceCollection AddApplicacionServices(this IServiceCollection services) 
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(AppApplicacionServices).Assembly));

            return services;
        }
    }
}
