namespace PromoStandards.REST.Core.Inventory;

public class InventoryLocation
{
    public string inventoryLocationId { get; set; }

    public string inventoryLocationName { get; set; }

    public string postalCode { get; set; }
    public InventoryLocationCountry country { get; set; }
    public bool countrySpecified { get; set; }
    public Quantity inventoryLocationQuantity { get; set; }
    public FutureAvailability[] FutureAvailabilityArray { get; set; }
}