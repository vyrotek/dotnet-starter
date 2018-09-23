using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Starter.Web
{
    public static class Dependencies
    {
        /// <summary>
        /// Register services required by Starter.Web
        /// </summary>
        public static IServiceCollection AddWebDependencies(this IServiceCollection services)
        {
            services.AddTransient(sp => sp.GetService<IOptions<Web.Settings>>().Value);

            return services;
        }
    }
}
