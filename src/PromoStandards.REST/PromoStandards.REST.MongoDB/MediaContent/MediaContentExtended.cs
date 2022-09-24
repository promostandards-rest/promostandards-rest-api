using Microsoft.AspNetCore.Mvc.Formatters;
using MongoDB.Bson;
using PromoStandards.REST.Core.ProductData.ServiceReference;

namespace PromoStandards.REST.MongoDB.MediaContent
{
    public class MediaContentExtended
    {
        public ObjectId Id { get; set; }
        public string ProductId { get; set; }
        public Core.MediaContent.ServiceReference.mediaTypeType MediaType { get; set; }
        public List<Core.MediaContent.ServiceReference.MediaContent> MediaContent { get; set; }
    }
}
