namespace PromoStandards.REST.Validator.API.Models
{
    public class ValidationResult
    {
        public bool IsValid { get; set; }
        public IEnumerable<string> Messages { get; set; }
        public ValidationResult()
        {
            Messages = new List<string>();
        }
    }
}
