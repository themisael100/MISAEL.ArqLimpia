using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Extensions.DependencyInjection;
using MISAEL.ArqLimpia.BL.Interfaces;

namespace MISAEL.ArqLimpia.BL
{
    public static class DependecyContainer
    {
        public static IServiceCollection AddBLDependecies(this IServiceCollection services)
        {
            services.AddTransient<IUserBL, UserBL>();
            return services;
        }
    }
}