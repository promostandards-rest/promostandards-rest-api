public interface ProductComplianceService
{
    System.Threading.Tasks.Task<GetProductsWithRegulationsResponse> getProductsWithRegulationsAsync(GetProductsWithRegulationsRequest request);
    System.Threading.Tasks.Task<GetComplianceResponse> getComplianceAsync(GetComplianceRequest request);
}