using PromoStandards.REST.Core.Inventory;

namespace PromoStandards.REST.Abstraction
{
    public interface IInventoryService
    {
        GetFilterValuesResponse GetFilterValues(GetFilterValuesRequest request);
        GetInventoryLevelsResponse GetInventoryLevels(GetInventoryLevelsRequest request);       
    }
}