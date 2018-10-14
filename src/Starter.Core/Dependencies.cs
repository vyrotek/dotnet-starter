using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Starter.Core.Data.Database;
using Starter.Core.Services.Users;
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

            services.AddTransient<StarterDB>();
            services.AddTransient<UserService>();

            return services;
        }
    }
}
