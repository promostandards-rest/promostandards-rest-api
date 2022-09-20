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
        public object Get(string id)
        {
            return new 
            {
                productId = "product-1"
            };
        }
    }
}