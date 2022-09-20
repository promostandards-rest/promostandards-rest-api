using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using PromoStandards.REST.Abstraction;
using PromoStandards.REST.StaticImplementation;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "alpha",
        Title = "PromoStandards",
        Description = "Putting SOAP to REST"
    });

    var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
    options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, "PromoStandards.REST.Core.xml"));

});

builder.Services.AddSingleton<IProductDataService, StaticProductDataService>();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI(options =>{
    options.InjectStylesheet("/custom.css");
});

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseAuthorization();

app.MapControllers();

app.Run();
