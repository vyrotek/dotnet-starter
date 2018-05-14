using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Starter.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Starter.Core
{
    public static class Dependencies
    {
        /// <summary>
        /// Register services required by Starter.Core
        /// </summary>
        public static IServiceCollection AddCoreDependencies(this IServiceCollection services)
        {
            services.AddTransient(sp => sp.GetService<IOptions<Settings>>().Value);
            
            return services;
        }
    }
}
