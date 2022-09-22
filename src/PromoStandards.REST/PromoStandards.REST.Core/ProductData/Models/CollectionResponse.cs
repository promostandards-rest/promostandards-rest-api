
using System.Text.Json.Serialization;

namespace PromoStandards.REST.Core.ProductData.Models {
    public class CollectionResponse<t> {
        public CollectionResponse() => Data = new List<t>();
        public CollectionResponse(List<t> data) {
            Data = data;
            Total = data.Count;
        }
        [JsonPropertyName("data")]
        public List<t> Data { get; set; }
        public List<ServiceMessage>? ServiceMessages { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? page { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? pageSize { get; set; }

        [JsonPropertyName("total")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public long Total { get; set; }
    }
}