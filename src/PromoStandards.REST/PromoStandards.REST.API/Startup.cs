using Microsoft.OpenApi.Models;
using PromoStandards.REST.Abstraction;
using System.Reflection;
using MongoDB.Driver;
using PromoStandards.REST.MongoDB.ProductData;
using PromoStandards.REST.MongoDB.Inventory;
using System.Text.Json.Serialization;
using AutoBogus;
using PromoStandards.REST.MongoDB.MediaContent;
using PromoStandards.REST.StaticImplementation;

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
            AutoFaker.Configure(builder =>
            {
                builder
                    .WithLocale("en_US")        // Configures the locale to use
                    .WithRepeatCount(2)         // Configures the number of items in a collection
                    .WithDataTableRowCount(2)   // Configures the number of data table rows to generate
                    .WithRecursiveDepth(10)      // Configures how deep nested types should recurse
                    .WithTreeDepth(10);          // Configures the tree depth of an object graph
            });
            services.AddControllers().AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
                options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
            });
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

                c.EnableAnnotations();
            });

            services.AddOptions();

            services.AddSingleton<IMongoClient>(c => new MongoClient(Configuration["MongoDB:Url"]))
                .AddScoped(c => c.GetService<IMongoClient>().StartSession());
            services.Configure<MongoDBProductServiceConfiguration>(p =>
            {
                p.DatabaseName = Configuration["Config:DatabaseName"];
                p.ProductCollectionName = Configuration["Config:ProductCollectionName"];
            });

            services.Configure<MongoDBMediaContentServiceConfiguration>(p =>
            {
                p.DatabaseName = Configuration["Config:DatabaseName"];
                p.MediaCollectionName = Configuration["Config:MediaCollectionName"];
            });
            services.Configure<MyMongoDBInventoryServiceConfiguration>(c =>
            {
                c.DatabaseName = Configuration["Config:DatabaseName"];
                c.InventoryCollectionName = Configuration["Config:InventoryCollectionName"];
                c.InventoryFilterCollectionName = Configuration["Config:InventoryFilterCollectionName"];
            });


            services.AddCors(o => o.AddPolicy("CorsPolicy", builder =>
            {
                builder.SetIsOriginAllowed(_ => true)
                       .AllowAnyMethod()
                       .AllowAnyHeader()
                       .AllowCredentials();
            }));

            services.AddSingleton<IProductDataService, MongoDBProductService>();
            services.AddSingleton<IMyInventoryService, MyMongoDBInventoryService>();
            services.AddSingleton<IMyInventoryFilterService, MyMongoDBInventoryFilterService>();
            services.AddSingleton<IMediaContentService, MongoDBMediaContentService>();

            // Uncomment for local:
            //services.AddSingleton<IProductDataService, StaticProductDataService>();
            //services.AddSingleton<IMyInventoryService, StaticInventoryService>();
            //services.AddSingleton<IMyInventoryFilterService, StaticInventoryFilterService>();
            //services.AddSingleton<IMediaContentService, StaticMediaService>();

            services.AddRazorPages();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors("CorsPolicy");

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                //c.RoutePrefix = "";
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "PromoStandards.REST.API v1");
                c.InjectStylesheet("/css/swagger-ui.css");
                c.InjectJavascript("/js/swagger-ui.js");
            });

            app.UseStaticFiles();

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();
            
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapRazorPages();
            });
        }
    }
}
