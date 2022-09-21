using PromoStandards.REST.Core.Inventory;

namespace PromoStandards.REST.Abstraction
{
    public interface IInventoryService
    {
        GetFilterValuesResponse GetFilterValues(GetFilterValuesRequest request);
        Task<Core.Inventory.Inventory?> GetInventoryLevels(GetInventoryLevelsRequest request);       
    }
}