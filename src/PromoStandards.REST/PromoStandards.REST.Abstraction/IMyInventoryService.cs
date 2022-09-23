using PromoStandards.REST.Core.Inventory;

namespace PromoStandards.REST.Abstraction
{
    public interface IMyInventoryService
    {
         Task<Core.Inventory.Inventory?> GetInventoryLevels(GetInventoryLevelsRequest request);
    }

    public interface IMyInventoryFilterService
    {
       Task<GetFilterValuesResponse?> GetFilterValues(wsVersion wsVersion, string productId);
    }
}