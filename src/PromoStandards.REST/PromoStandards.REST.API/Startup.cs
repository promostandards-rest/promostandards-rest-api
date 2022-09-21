using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using PromoStandards.REST.Abstraction;
using System;
using System.Reflection;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using PromoStandards.REST.MongoDB;
using PromoStandards.REST.MongoDB.ProductData;
using Swashbuckle.AspNetCore.Newtonsoft;

namespace PromoStandards.REST.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "alpha",
                    Title = "PromoStandards",
                    Description = "Putting SOAP to REST"
                });

                c.UseInlineDefinitionsForEnums();

                var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                c.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
                c.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, "PromoStandards.REST.Core.xml"));

            });
            services.AddSwaggerGenNewtonsoftSupport();

            services.AddOptions();

            services.AddSingleton<IMongoClient>(c => new MongoClient(Configuration["MongoDB:Url"]))
                .AddScoped(c => c.GetService<IMongoClient>().StartSession());
            services.Configure<MongoDBProductServiceConfiguration>(p =>
            {
                p.DatabaseName = Configuration["Config:DatabaseName"];
                p.ProductCollectionName = Configuration["Config:ProductCollectionName"];
            });
            services.AddSingleton<IProductDataService, MongoDBProductService>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                //c.RoutePrefix = "";
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "PromoStandards.REST.API v1");
                c.InjectStylesheet("/custom.css");
            });

            app.UseStaticFiles();

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
