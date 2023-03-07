using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using MISAEL.ArqLimpia.DAL;
using MISAEL.ArqLimpia.BL;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;

namespace MISAEL.ArqLimpia.IoC
{
    public static class DependecyContainer
    {

        public static IServiceCollection AddMISAELDependecies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDALDependecies(configuration);
            services.AddBLDependecies();
            return services;
        }
    }
}
