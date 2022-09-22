using AutoBogus;
using PromoStandards.REST.Abstraction;
using PromoStandards.REST.Core.ProductData.Models;
using PromoStandards.REST.Core.ProductData.ServiceReference;

namespace PromoStandards.REST.StaticImplementation;

public class StaticProductDataService : IProductDataService
{
    public async Task<CollectionResponse<Product>> GetProducts(bool? isSellable = null, bool? isCloseout = null, DateTime? modifiedDate = null, int? page = 0, int? pageSize = 20, Dictionary<string, string>? additionalParameters = null)
    {
        var faker = AutoFaker.Create();
        return faker.Generate<CollectionResponse<Product>>();
    }

    public async Task<Product?> GetProduct(string id)
    {
        var faker = AutoFaker.Create();
        return faker.Generate<Product>();
    }

    public async Task<getProductResponse1> getProductAsync(getProductRequest1 request)
    {
        var faker = AutoFaker.Create();
        return faker.Generate<getProductResponse1>();
    }

    public async Task<getProductDateModifiedResponse1> getProductDateModifiedAsync(getProductDateModifiedRequest1 request)
    {
        var faker = AutoFaker.Create();
        return faker.Generate<getProductDateModifiedResponse1>();
    }

    public async Task<getProductCloseOutResponse1> getProductCloseOutAsync(getProductCloseOutRequest1 request)
    {
        var faker = AutoFaker.Create();
        return faker.Generate<getProductCloseOutResponse1>();
    }

    public async Task<getProductSellableResponse1> getProductSellableAsync(getProductSellableRequest1 request)
    {
        var faker = AutoFaker.Create();
        return faker.Generate<getProductSellableResponse1>();
    }

    public async Task<CollectionResponse<Product>> GetProducts(bool? isSellable = null, bool? isCloseout = null, DateTime? modifiedDate = null, int page = 0,
        int pageSize = 20, Dictionary<string, string>? additionalParameters = null)
    {
        var faker = AutoFaker.Create();
        return faker.Generate<CollectionResponse<Product>>();
    }
}