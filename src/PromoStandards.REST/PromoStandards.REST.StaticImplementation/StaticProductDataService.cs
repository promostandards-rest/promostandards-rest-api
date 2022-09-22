using AutoBogus;
using PromoStandards.REST.Abstraction;
using PromoStandards.REST.Core.ProductData.Models;


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

    public async Task<GetProductResponse> getProductAsync(GetProductRequest request)
    {
        var faker = AutoFaker.Create();
        return faker.Generate<GetProductResponse>();
    }

    public async Task<GetProductDateModifiedResponse> getProductDateModifiedAsync(GetProductDateModifiedRequest request)
    {
        var faker = AutoFaker.Create();
        return faker.Generate<GetProductDateModifiedResponse>();
    }

    public async Task<GetProductCloseOutResponse> getProductCloseOutAsync(GetProductCloseOutRequest request)
    {
        var faker = AutoFaker.Create();
        return faker.Generate<GetProductCloseOutResponse>();
    }

    public async Task<GetProductSellableResponse> getProductSellableAsync(GetProductSellableRequest request)
    {
        var faker = AutoFaker.Create();
        return faker.Generate<GetProductSellableResponse>();
    }

    public async Task<CollectionResponse<Product>> GetProducts(bool? isSellable = null, bool? isCloseout = null, DateTime? modifiedDate = null, int page = 0,
        int pageSize = 20, Dictionary<string, string>? additionalParameters = null)
    {
        var faker = AutoFaker.Create();
        return faker.Generate<CollectionResponse<Product>>();
    }

    public Task<getProductResponse1> getProductAsync(getProductRequest1 request)
    {
        throw new NotImplementedException();
    }

    public Task<getProductDateModifiedResponse1> getProductDateModifiedAsync(getProductDateModifiedRequest1 request)
    {
        throw new NotImplementedException();
    }

    public Task<getProductCloseOutResponse1> getProductCloseOutAsync(getProductCloseOutRequest1 request)
    {
        throw new NotImplementedException();
    }

    public Task<getProductSellableResponse1> getProductSellableAsync(getProductSellableRequest1 request)
    {
        throw new NotImplementedException();
    }
}