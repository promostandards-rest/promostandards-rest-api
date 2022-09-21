namespace PromoStandards.REST.Core.Inventory;

public class GetInventoryLevelsResponse
{
    public Inventory Inventory { get; set; }
    public ServiceMessage[] ServiceMessageArray { get; set; }
}