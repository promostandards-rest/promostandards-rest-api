using AutoBogus;
using PromoStandards.REST.Abstraction;
using PromoStandards.REST.Core.Inventory;
using PromoStandards.REST.Core.ProductData.Models;

namespace PromoStandards.REST.StaticImplementation;

public class StaticInventoryService : IMyInventoryService {
    public async Task<Inventory?> GetInventoryLevels(GetInventoryLevelsRequest request)
    {
        var faker = AutoFaker.Create();
        return faker.Generate<Inventory?>();
    }
}

public class StaticInventoryFilterService : IMyInventoryFilterService {
    public Task<GetFilterValuesResponse?> GetFilterValues(wsVersion wsVersion, string productId) => null;
}