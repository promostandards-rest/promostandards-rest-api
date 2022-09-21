using Microsoft.AspNetCore.Mvc;

namespace PromoStandards.REST.API.Controllers
{
    [ApiController]
    public class ProductDataController : ControllerBase
    {
        public ProductDataController()
        {
        }

        /// <summary>
        /// Provides a collection of Products based on any optional subset filtering provided at the request.
        /// </summary>
        /// <param name="dateModified">Beginning date time since last change in UTC</param>
        /// <param name="closeOut">Return all items that are closed out or not</param>
        /// <param name="sellable">Return all items that are sellable or not</param>
        /// <returns>All products matching the provided filters</returns>
        /// <remarks>
        /// </remarks>
        /// <response code="200">All products matching the filters are returned</response>
        [HttpGet("api/products")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IEnumerator<Product> GetProducts(DateTime? dateModified, bool? closeOut, bool? sellable)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Provides the detail product data based on a specific ProductId provided at the request.
        /// </summary>
        /// <param name="productId">The supplier's ID for a given product</param>
        /// <returns>A newly created TodoItem</returns>
        /// <remarks>
        /// </remarks>
        /// <response code="200">Returns the product</response>
        /// <response code="404">When the product is not found</response>
        [HttpGet("api/product/{productId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public Product Get(string productId)
        {
            return new Product
            {
                productId = "product-1"
            };
        }
    }
}