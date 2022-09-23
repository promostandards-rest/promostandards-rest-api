using AutoBogus;
using PromoStandards.REST.Abstraction;
using PromoStandards.REST.Core.MediaContent.ServiceReference;
using PromoStandards.REST.Core.ProductData.Models;


namespace PromoStandards.REST.StaticImplementation;

public class StaticMediaService : IMediaContentService
{
    public async Task<CollectionResponse<MediaContent>> GetProductMedia(string productId, mediaTypeType image, string? partId, string? cultureName, int? classType,
        DateTime? lastModifiedDate)
    {
        var faker = AutoFaker.Create();
        return faker.Generate<CollectionResponse<MediaContent>>();
    }
}