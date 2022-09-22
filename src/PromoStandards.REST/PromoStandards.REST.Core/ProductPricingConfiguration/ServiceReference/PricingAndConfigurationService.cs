namespace PromoStandards.REST.Core.ProductPricingConfiguration.ServiceReference;
public interface PricingAndConfigurationService
{
    System.Threading.Tasks.Task<GetAvailableLocationsResponse> getAvailableLocationsAsync(GetAvailableLocationsRequest request);
    System.Threading.Tasks.Task<GetDecorationColorsResponse> getDecorationColorsAsync(GetDecorationColorsRequest request);
    System.Threading.Tasks.Task<GetFobPointsResponse> getFobPointsAsync(GetFobPointsRequest request);
    System.Threading.Tasks.Task<GetAvailableChargesResponse> getAvailableChargesAsync(GetAvailableChargesRequest request);
    System.Threading.Tasks.Task<GetConfigurationAndPricingResponse> getConfigurationAndPricingAsync(GetConfigurationAndPricingRequest request);
}