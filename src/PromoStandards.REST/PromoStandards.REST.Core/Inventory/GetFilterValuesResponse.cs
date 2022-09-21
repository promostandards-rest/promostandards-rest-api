namespace PromoStandards.REST.Core.Inventory;

public class GetFilterValuesResponse
{
    public GetFilterValuesResponseFilterValues FilterValues { get; set; }
    public ServiceMessage[] ServiceMessageArray { get; set; }
}