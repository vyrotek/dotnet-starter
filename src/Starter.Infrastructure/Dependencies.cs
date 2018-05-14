using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace Starter.Infrastructure
{
    public static class Dependencies
    {
        /// <summary>
        /// Register services required by Starter.Infrastructure
        /// </summary>
        public static IServiceCollection AddInfrastructureDependencies(this IServiceCollection services)
        {
            services.AddTransient(sp => sp.GetService<IOptions<Settings>>().Value);
            
            return services;
        }
    }
}
