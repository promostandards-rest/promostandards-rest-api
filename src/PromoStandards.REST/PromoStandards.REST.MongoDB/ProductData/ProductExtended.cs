using MongoDB.Bson;
using PromoStandards.REST.Core.ProductData.ServiceReference;
using Product = PromoStandards.REST.Core.ProductPricingConfiguration.ServiceReference.Product;

namespace PromoStandards.REST.MongoDB.ProductData
{
    public class ProductExtended : Product
    {
        public ObjectId Id { get; set; }
        public bool? isSellable { get; set; }
    }
}
