using Microsoft.AspNetCore.Mvc;

namespace PromoStandards.REST.API.Common {
    public class GeneratedSchema {
        public string Id { get; set; }
        public string? Schema { get; set; }
    }
    public enum SchemaIds {
        Product,
        Inventory,
        FilterValues
    }
    public class ValidationRequest {
        public string SchemaId { get; set; }
        public string JsonData { get; set; }

    }
    public class ValidationResult {
        public bool IsValid { get; set; }
        public IEnumerable<string> Messages { get; set; }
        public ValidationResult() {
            Messages = new List<string>();
        }
    }

}
