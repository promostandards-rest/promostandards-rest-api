namespace PromoStandards.REST.Validator.API.Models
{
    public class ValidationRequest
    {
        public string SchemaId { get; set; }
        public IFormFile JsonFile { get; set; }

    }
}
