using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace PromoStandards.REST.Core.Inventory;

[JsonConverter(typeof(StringEnumConverter))]
public enum SortOrder {
    Ascending = 0,
    Descending = 1
}