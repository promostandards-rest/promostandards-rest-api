using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromoStandards.REST.Core.ProductData.Models {
    public class PagingRequest {
        public int page { get; set; }
        public int pageSize { get; set; }
            
    }
}
