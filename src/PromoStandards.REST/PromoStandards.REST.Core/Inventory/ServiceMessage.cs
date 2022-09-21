namespace PromoStandards.REST.Core.Inventory;

public class ServiceMessage
{
    public int code { get; set; }

    public string description { get; set; }
    public ServiceMessageSeverity severity { get; set; }
}