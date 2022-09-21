using PromoStandards.REST.Abstraction;
using PromoStandards.REST.Core.ProductData.Models;

namespace PromoStandards.REST.StaticImplementation;

public class StaticProductDataService : IProductDataService
{
    public Task<GetProductsResponse> GetProducts(bool? isSellable = null, bool? isCloseout = null, DateTime? modifiedDate = null, int page = 0,
        int pageSize = 20, Dictionary<string, string>? additionalParameters = null)
    {
        throw new NotImplementedException();
    }

    public Task<Product?> GetProduct(string id)
    {
        throw new NotImplementedException();
    }
}