namespace PromoStandards.REST.MongoDB.Inventory;

public class MyMongoDBInventoryServiceConfiguration
{
    public string DatabaseName { get; set; }
    public string InventoryCollectionName { get; set; }
    public string InventoryFilterCollectionName { get; set; }
}