using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace PromoStandards.REST.MongoDB.Inventory
{
    [BsonIgnoreExtraElements]
    public class InventoryExtended 
    {
        public ObjectId Id { get; set; }
        public Core.Inventory.Inventory Inventory { get; set; }
    }
}
