using MongoDB.Bson;


namespace PromoStandards.REST.MongoDB.ProductData
{
    public class ProductExtended : Product
    {
        public ObjectId Id { get; set; }
        public bool? isSellable { get; set; }
    }
}
