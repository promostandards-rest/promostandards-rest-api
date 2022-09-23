using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using PromoStandards.REST.Core.Inventory;

namespace PromoStandards.REST.MongoDB.Inventory
{
    [BsonIgnoreExtraElements]
    public class MyInventoryFilterExtended 
    {
        // Todo:ENum
        public int CountryCode { get; set; }    // iso3166-country-code or 1 = US, 2 = CA, 3 = MX ...
        public int Environment { get; set; }   // 0 = Production, 1 = Test   2 = Development...
        public int CultureCode { get; set; }   // iso639-language-code or 1 = en, 2 = fr, 3 = es ...
        public string MyProductId { get; set; }
        public ObjectId Id { get; set; }
        public GetFilterValuesResponse Value { get; set; }
    }

}
