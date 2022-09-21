using PromoStandards.REST.Core.ProductData.ServiceReference;

namespace PromoStandards.REST.Core.Inventory;

public class PartInventory {
    public string partId { get; set; }
    public bool mainPart { get; set; }
    public string partColor { get; set; }
    public LabelSize labelSize { get; set; }
    public bool labelSizeSpecified { get; set; }
    public string partDescription { get; set; }
    public Quantity quantityAvailable { get; set; }
    public bool manufacturedItem { get; set; }
    public bool buyToOrder { get; set; }
    public int replenishmentLeadTime { get; set; }
    public bool replenishmentLeadTimeSpecified { get; set; }
    public string attributeSelection { get; set; }
    public InventoryLocation[] InventoryLocationArray { get; set; }
    public DateTime lastModified { get; set; }
    public bool lastModifiedSpecified { get; set; }
}