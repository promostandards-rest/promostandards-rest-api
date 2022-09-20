using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromoStandards.REST.Core.Inventory
{
    public enum SortOrder
    {
        Ascending = 0,
        Descending = 1
    }

    public class RequestOption
    {
        public wsVersion wsVersion { get; set; }
        public string ProductId { get; set; }

        //    public string[] PartIds { get; set; }
        //    public labelSize[] LabelSizeArray { get; set; }
        //    public string[] PartColors { get; set; }
        public string PartIds { get; set; }
        public string LabelSizes { get; set; }
        public string PartColors { get; set; }

        public int PageSize { get; set; }
        public int PageNumber { get; set; }

        // To provide ENum?
        // Do we need to implement Sort? sort can be done on client side
        public string SortPropertyName { get; set; }    
        public SortOrder SortOrder { get; set; }

        public RequestOption()
        {
            PageSize = 20;
            PageNumber = 1;
        }

    }
}
