using Microsoft.AspNetCore.Mvc;

namespace PromoStandards.REST.API.Controllers
{
    [ApiController]
    public class ProductDataController : ControllerBase
    {
        public ProductDataController()
        {
        }

        [HttpGet("api/products/{id}")]
        public Product Get(string id)
        {
            return new Product
            {
                productId = "product-1"
            };
        }
    }
}