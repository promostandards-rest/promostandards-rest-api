using PromoStandards.REST.Core.Inventory;

namespace PromoStandards.REST.Abstraction
{
    public interface IInventoryService
    {
        //Task<CollectionResponse<PartInventory>> GetInventoryLevels(GetInventoryLevelsRequest request);
        Task<Core.Inventory.Inventory?> GetInventoryLevels(GetInventoryLevelsRequest request);
    }

    public interface IInventoryFilterService
    {
       Task<GetFilterValuesResponse?> GetFilterValues(wsVersion wsVersion, string productId);
    }
}