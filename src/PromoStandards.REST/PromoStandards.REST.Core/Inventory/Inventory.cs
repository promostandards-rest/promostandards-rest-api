namespace PromoStandards.REST.Core.Inventory;

public class Inventory
{
    public string productId { get; set; }
    public PartInventory[] PartInventoryArray { get; set; }
}