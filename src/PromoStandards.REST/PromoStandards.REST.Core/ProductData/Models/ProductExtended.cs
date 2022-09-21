using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace PromoStandards.REST.Core.ProductData.Models
{
    public class ProductExtended : Product
    {
        public ObjectId Id { get; set; }
        public bool? isSellable { get; set; }
    }
}
