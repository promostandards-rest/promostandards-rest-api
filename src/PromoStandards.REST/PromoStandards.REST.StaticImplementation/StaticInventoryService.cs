using AutoBogus;
using PromoStandards.REST.Abstraction;
using PromoStandards.REST.Core.Inventory;

namespace PromoStandards.REST.StaticImplementation;

public class StaticInventoryService : IInventoryService
{
    public GetFilterValuesResponse GetFilterValues(GetFilterValuesRequest request)
    {
        var faker = AutoFaker.Create();
        return faker.Generate<GetFilterValuesResponse>();
    }

    public async Task<Inventory?> GetInventoryLevels(GetInventoryLevelsRequest request)
    {
        var faker = AutoFaker.Create();
        return faker.Generate<Inventory>();
    }
}