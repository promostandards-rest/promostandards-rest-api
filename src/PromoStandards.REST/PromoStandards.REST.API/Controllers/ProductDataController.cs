using Microsoft.AspNetCore.Mvc;
using PromoStandards.REST.Core.Inventory;

namespace PromoStandards.REST.API.Controllers
{
    [ApiController]
    [Tags("Product Data")]
    [Route("api/products")]
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
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IEnumerator<Product> GetProducts(DateTime? dateModified, bool? closeOut, bool? sellable)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Provides the detail product data based on a specific ProductId provided at the request.
        /// </summary>
        /// <param name="productId">The supplier's ID for a given product</param>
        /// <remarks>
        /// </remarks>
        /// <response code="200">Returns the product</response>
        /// <response code="404">When the product is not found</response>
        [HttpGet("{productId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public Product GetProduct(string productId) {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Provides the available color options for a specific ProductId provided in the request.
        /// </summary>
        /// <param name="productId">The supplier's ID for a given product</param>
        /// <remarks>
        /// </remarks>
        /// <response code="200">Returns a collection of product colors</response>
        /// <response code="404">When the product is not found</response>
        [HttpGet("{productId}/colors")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IEnumerable<string> GetProductColors(string productId) {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Provides the available size options for a specific ProductId provided in the request.
        /// </summary>
        /// <param name="productId">The supplier's ID for a given product</param>
        /// <remarks>
        /// </remarks>
        /// <response code="200">Returns a collection of product sizes</response>
        /// <response code="404">When the product is not found</response>
        [HttpGet("{productId}/sizes")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IEnumerable<string> GetProductSizes(string productId) {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Provides the parts of a specific ProductId provided in the request.
        /// </summary>
        /// <param name="productId">The supplier's ID for a given product</param>
        /// <remarks>
        /// </remarks>
        /// <response code="200">Returns a collection of product parts</response>
        /// <response code="404">When the product is not found</response>
        [HttpGet("{productId}/parts")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IEnumerable<string> GetProductParts(string productId) {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Provides the inventory levels of a specific ProductId provided in the request.
        /// </summary>
        /// <param name="productId">The supplier's ID for a given product</param>
        /// <remarks>
        /// </remarks>
        /// <response code="200">Returns inventory levels</response>
        /// <response code="404">When the product is not found</response>
        [HttpGet("{productId}/inventory")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IEnumerable<Inventory> GetInventoryLevels(string productId) {
            throw new NotImplementedException();
        }
    }
}