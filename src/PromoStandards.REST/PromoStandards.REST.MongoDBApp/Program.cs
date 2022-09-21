using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Driver;
using PromoStandards.REST.MongoDB;
using PromoStandards.REST.MongoDBApp;
using System.IO;

var basePath = Directory.GetCurrentDirectory();

var configuration = new ConfigurationBuilder()
    .SetBasePath(basePath)
    .AddJsonFile("appsettings.json", false, true)
    .AddEnvironmentVariables()
    .Build();

IServiceCollection services = new ServiceCollection();
services.AddOptions();

services.AddSingleton<IMongoClient>(c => new MongoClient(configuration["MongoDB:Url"]))
    .AddScoped(c => c.GetService<IMongoClient>().StartSession());
services.AddSingleton<MongoDBProductService>();
services.AddSingleton<MongoDBConverter>();
services.Configure<MongoDBProductServiceConfiguration>(p =>
{
    p.DatabaseName = configuration["Config:DatabaseName"];
    p.ProductCollectionName = configuration["Config:ProductCollectionName"];
});
services.Configure<MongoDBConverterConfig>(p =>
{
    p.WsVersion = configuration["Config:WsVersion"];
    p.Endpoint = configuration["Config:Endpoint"];
    p.Id = configuration["Config:Id"];
    p.LocalizationCountry = configuration["Config:LocalizationCountry"];
    p.LocalizationLanguage = configuration["Config:LocalizationLanguage"];
    p.Password = configuration["Config:Password"];
    p.Throttling = configuration["Config:Throttling"];
});

var serviceProvider = services.BuildServiceProvider();
using var scope = serviceProvider.CreateScope();
var task = scope.ServiceProvider.GetService<MongoDBConverter>();
await task.Process();