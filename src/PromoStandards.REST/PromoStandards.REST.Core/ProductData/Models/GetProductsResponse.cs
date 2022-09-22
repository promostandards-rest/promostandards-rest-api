using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
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
