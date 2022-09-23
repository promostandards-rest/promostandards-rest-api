using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromoStandards.REST.MongoDBApp
{
    public class MongoDBConverterConfig
    {
        public string Throttling { get; set; }
        public string Endpoint { get; set; }
        public string WsVersion { get; set; }
        public string Id { get; set; }
        public string Password { get; set; }
        public string LocalizationCountry { get; set; }
        public string LocalizationLanguage { get; set; }
        public string InventoryEndpoint { get; set; }
    }
}
