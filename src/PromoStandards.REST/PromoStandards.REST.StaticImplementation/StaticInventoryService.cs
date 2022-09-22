using AutoBogus;
using PromoStandards.REST.Abstraction;
using PromoStandards.REST.Core.Inventory;
using PromoStandards.REST.Core.ProductData.Models;

namespace PromoStandards.REST.StaticImplementation;

public class StaticInventoryService : IInventoryService
{
    public GetFilterValuesResponse GetFilterValues(GetFilterValuesRequest request)
    {
        var faker = AutoFaker.Create();
        return faker.Generate<GetFilterValuesResponse>();
    }

    public async Task<CollectionResponse<PartInventory>> GetInventoryLevels(String productId, String[]? parts, String[]? colors, String[]? sizes) {
        var faker = AutoFaker.Create();
        return faker.Generate<CollectionResponse<PartInventory>>();
    }
}