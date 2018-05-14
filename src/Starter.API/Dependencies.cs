using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Starter.Core.Data;
using Starter.Core.Users;
using Starter.Infrastructure.Data;
using Starter.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Starter.Infrastructure;

namespace Starter.API
{
    public static class Dependencies
    {
        /// <summary>
        /// Register services required by Starter.API
        /// </summary>
        public static IServiceCollection AddAPIDepedencies(this IServiceCollection services)
        {
            services.AddTransient(sp => sp.GetService<IOptions<Settings>>().Value);
            services.AddTransient<IStarterDB, StarterDB>();
            services.AddTransient<UserService>();

            return services;
        }
    }
}
