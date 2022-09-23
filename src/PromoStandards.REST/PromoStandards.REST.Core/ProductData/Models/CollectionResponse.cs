using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Text.Json.Serialization;
using PromoStandards.REST.Core.ProductData.ServiceReference;

namespace PromoStandards.REST.Core.ProductData.Models {
    public class CollectionResponse<t> {
        public CollectionResponse() => Data = new List<t>();
        public CollectionResponse(List<t> data) {
            Data = data;
            Total = data.Count;
        }
        /// <summary>
        /// The collection of objects
        /// </summary>
        [JsonPropertyName("data")]
        public List<t> Data { get; set; }

        /// <summary>
        /// Error message object array
        /// </summary>
        public List<ServiceMessage>? ServiceMessages { get; set; }

        /// <summary>
        /// The current page number. Ommitted on single record calls
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? pageNumber { get; set; }

        /// <summary>
        /// The maximum size of the collection
        /// </summary>
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? pageSize { get; set; }

        /// <summary>
        /// The total count of records in the collection
        /// </summary>
        [JsonPropertyName("total")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public long Total { get; set; }

    }
}