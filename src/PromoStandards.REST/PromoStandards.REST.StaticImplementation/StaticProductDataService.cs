using AutoBogus;
using PromoStandards.REST.Abstraction;
using PromoStandards.REST.Core.ProductData.Models;
using PromoStandards.REST.Core.ProductData.ServiceReference;


namespace PromoStandards.REST.StaticImplementation;

public class StaticProductDataService : IProductDataService
{
    public async Task<GetProductResponse> GetProduct(GetProductRequest request)
    {
        var faker = AutoFaker.Create();
        return faker.Generate<GetProductResponse>();
    }

    public async Task<CollectionResponse<Product>> GetProducts(bool? isSellable = null, bool? isCloseout = null, DateTime? modifiedDate = null, int page = 0,
        int pageSize = 20, Dictionary<string, string>? additionalParameters = null)
    {
        var faker = AutoFaker.Create();
        return faker.Generate<CollectionResponse<Product>>();
    }
}