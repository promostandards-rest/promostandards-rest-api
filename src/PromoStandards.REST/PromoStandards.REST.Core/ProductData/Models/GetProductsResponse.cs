using System.Text.Json.Serialization;
using PromoStandards.REST.Core.ProductData.ServiceReference;

namespace PromoStandards.REST.Core.ProductData.Models
{
    public class GetProductsResponse
    {
        [JsonPropertyName("total")]
        public long Total { get; set; }
        [JsonPropertyName("products")]
        public List<Product> Products { get; set; }
    }
}
