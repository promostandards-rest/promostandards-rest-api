using PromoStandards.REST.Core.Inventory;
using PromoStandards.REST.Core.ProductData.Models;

namespace PromoStandards.REST.Abstraction
{
    public interface IInventoryService
    {
        GetFilterValuesResponse GetFilterValues(GetFilterValuesRequest request);
        Task<CollectionResponse<PartInventory>> GetInventoryLevels(GetInventoryLevelsRequest request);       
    }
}