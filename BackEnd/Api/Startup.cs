using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Api.Assets;
using AutoMapper;
using Database.BD.Context;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.PlatformAbstractions;
using Microsoft.IdentityModel.Logging;
using Microsoft.OpenApi.Models;

namespace Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //var connection = Configuration.GetConnectionString("DefaultConnection");

            //Registramos el contexto.
            //services.AddDbContext<MyContext>(options =>
            //{
            //    options.UseSqlServer(connection);
            //});
            services.AddDbContext<MyContext >(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
            });

            //Registramos AutoMapper
            services.AddAutoMapper(typeof(MappingProfile).GetType().Assembly);

            IdentityModelEventSource.ShowPII = true;

            services.AddControllers();

            //Configuracion de IdentityServer

            services.AddAuthentication("Bearer")
                .AddJwtBearer("Bearer", options =>
                {
                    options.Authority = "https://localhost:44309";
                    options.RequireHttpsMetadata = false;
                    options.Audience = "Api";
                });

            //Registramos Swagger
            var filePath = Path.Combine(PlatformServices.Default.Application.ApplicationBasePath, "Api_Prefabricados.xml");
            services.AddSwaggerGen(config =>
            {
                config.SwaggerDoc("v1", new OpenApiInfo { Title = "Prefabricados", Version = "v1" });
                config.IncludeXmlComments(filePath);
                //config.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                //{
                //    Description = "JWT Authorization header using the Bearer scheme. Example: \"Authorization: Bearer {token}\"",
                //    Name = "Authorization",
                //    In = ParameterLocation.Header,
                //    Type = SecuritySchemeType.ApiKey
                //});
            });

            //Añade los servicios y los repositorios empleando Scrutor, que nos permite agregar todas las que siguen un patron
            services.Scan(scan => scan
                .FromAssemblies(Assembly.Load("Service"), Assembly.Load("Database"))
                .AddClasses(c => c.Where(d =>
                    d.Name.EndsWith("Service")
                    || d.Name.EndsWith("Repository")
                    || d.Name.EndsWith("Factory")))
                .AsImplementedInterfaces()
                .WithScopedLifetime());
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseStaticFiles();

            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.), 
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Prefabricados V1");
                c.RoutePrefix = string.Empty;
            });

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
