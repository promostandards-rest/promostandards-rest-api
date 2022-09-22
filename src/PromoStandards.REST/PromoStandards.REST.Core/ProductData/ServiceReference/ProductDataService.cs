namespace PromoStandards.REST.Core.ProductData.ServiceReference;
public interface ProductDataService
{
    System.Threading.Tasks.Task<GetProductResponse> getProductAsync(GetProductRequest request);
    System.Threading.Tasks.Task<GetProductDateModifiedResponse> getProductDateModifiedAsync(GetProductDateModifiedRequest request);
    System.Threading.Tasks.Task<GetProductCloseOutResponse> getProductCloseOutAsync(GetProductCloseOutRequest request);
    System.Threading.Tasks.Task<GetProductSellableResponse> getProductSellableAsync(GetProductSellableRequest request);
}