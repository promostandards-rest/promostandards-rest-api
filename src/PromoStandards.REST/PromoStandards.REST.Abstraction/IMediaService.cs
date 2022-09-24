using PromoStandards.REST.Core.MediaContent.ServiceReference;
using PromoStandards.REST.Core.ProductData.Models;


namespace PromoStandards.REST.Abstraction
{
    public interface IMediaContentService
    {
        Task<CollectionResponse<MediaContent>> GetProductMedia(string productId, mediaTypeType mediaType, string? partId, string? cultureName, int? classType, DateTime? lastModifiedDate);
    }
}