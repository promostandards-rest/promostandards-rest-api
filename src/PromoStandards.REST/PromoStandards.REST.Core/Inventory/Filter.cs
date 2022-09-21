using PromoStandards.REST.Core.ProductData.ServiceReference;

namespace PromoStandards.REST.Core.Inventory;

public class Filter
{
    public string[] partIdArray { get; set; }
    public LabelSize[] LabelSizeArray { get; set; }
    public string[] PartColorArray { get; set; }
}