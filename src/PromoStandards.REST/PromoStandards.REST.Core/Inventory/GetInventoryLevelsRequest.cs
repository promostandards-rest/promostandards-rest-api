namespace PromoStandards.REST.Core.Inventory;

public class GetInventoryLevelsRequest
{
    public wsVersion wsVersion { get; set; }
    public string id { get; set; }
    public string password { get; set; }
    public string productId { get; set; }
    public Filter Filter { get; set; }
}