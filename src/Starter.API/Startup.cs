﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Starter.Core;
using Swashbuckle.AspNetCore.Swagger;

namespace Starter.API
{
    public class Startup
    {
        public IHostingEnvironment Environment { get; }
        public IConfiguration Configuration { get; }

        public Startup(IHostingEnvironment environment, IConfiguration configuration)
        {
            Environment = environment;
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {            
            // Options
            services.AddOptions();
            services.Configure<API.Settings>(Configuration.GetSection("Starter.API"));
            services.Configure<Core.Settings>(Configuration.GetSection("Starter.Core"));

            // MVC
            services.AddMvc()
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_1)
                .WithRazorPagesRoot("/");

            // Dependencies
            services.AddAPIDepedencies();
            services.AddCoreDependencies();            

            // Swagger
            services.AddSwaggerGen(options =>
            {
                // Enable full type name schema Ids
                //options.CustomSchemaIds((type) => type.FullName);

                // Group endpoints by version
                options.DocInclusionPredicate((docName, apiDesc) => apiDesc.RelativePath.StartsWith(docName + "/", StringComparison.InvariantCultureIgnoreCase));

                // Add security tester
                //options.AddSecurityDefinition("Bearer", new ApiKeyScheme()
                //{
                //    Description = "Security stuff description",
                //    Name = "Authorization",
                //    In = "header",
                //    Type = "apiKey"
                //});

                options.SwaggerDoc("v1", new Info { Title = "Starter API v1", Version = "v1" });
                options.SwaggerDoc("v2", new Info { Title = "Starter API v2", Version = "v2" });

                // Set the comments path for the swagger json and ui.
                // options.IncludeXmlComments(Path.Combine(PlatformServices.Default.Application.ApplicationBasePath, "Starter.API.xml"));
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {            
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // Enable Swagger JSON & UI
            app.UseSwagger();
            app.UseSwaggerUI(options =>
            {
                options.RoutePrefix = "docs";
                options.SwaggerEndpoint("/swagger/v1/swagger.json", "V1");
                options.SwaggerEndpoint("/swagger/v2/swagger.json", "V2");
            });

            app.UseCors(builder => builder.WithOrigins("*"));

            app.UseStaticFiles();
            app.UseMvc();
        }
    }
}
