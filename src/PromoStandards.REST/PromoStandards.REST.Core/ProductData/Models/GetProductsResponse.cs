using System.Text.Json.Serialization;


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
