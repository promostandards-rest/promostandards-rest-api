using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace PromoStandards.REST.MongoDB.Inventory
{
    [BsonIgnoreExtraElements]
    public class InventoryExtended : Core.Inventory.Inventory
    {
        public ObjectId Id { get; set; }
    }
}
