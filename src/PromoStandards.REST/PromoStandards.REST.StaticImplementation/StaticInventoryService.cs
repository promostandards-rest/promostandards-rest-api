using AutoBogus;
using PromoStandards.REST.Abstraction;
using PromoStandards.REST.Core.Inventory;
using PromoStandards.REST.Core.ProductData.Models;

namespace PromoStandards.REST.StaticImplementation;

public class StaticInventoryService : IMyInventoryService
{
    public GetFilterValuesResponse GetFilterValues(GetFilterValuesRequest request)
    {
        var faker = AutoFaker.Create();
        return faker.Generate<GetFilterValuesResponse>();
    }

    Task<Inventory?> IMyInventoryService.GetInventoryLevels(GetInventoryLevelsRequest request)
    {
        throw new NotImplementedException();
    }

    //public async Task<CollectionResponse<PartInventory>> GetInventoryLevels(GetInventoryLevelsRequest request)
    //{
    //    var faker = AutoFaker.Create();
    //    return faker.Generate<CollectionResponse<PartInventory>>();
    //}
}