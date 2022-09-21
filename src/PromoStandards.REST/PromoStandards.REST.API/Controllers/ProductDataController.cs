using Microsoft.AspNetCore.Mvc;
using PromoStandards.REST.Abstraction;
using PromoStandards.REST.Core.ProductData.Models;

namespace PromoStandards.REST.API.Controllers
{
    [ApiController]
    public class ProductDataController : ControllerBase
    {
        private readonly IProductDataService _productDataService;
        public ProductDataController(IProductDataService productDataService)
        {
            _productDataService = productDataService;
        }

        /// <summary>
        /// Provides a collection of Products based on any optional subset filtering provided at the request.
        /// </summary>
        /// <param name="dateModified">Beginning date time since last change in UTC</param>
        /// <param name="closeOut">Return all items that are closed out or not</param>
        /// <param name="sellable">Return all items that are sellable or not</param>
        /// <param name="page">Current page, start is 0</param>
        /// <param name="pageSize">Product count per page, default is 20</param>
        /// <returns>All products matching the provided filters</returns>
        /// <remarks>
        /// </remarks>
        /// <response code="200">All products matching the filters are returned</response>
        [HttpGet("api/products")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<GetProductsResponse> GetProducts(DateTime? dateModified, bool? closeOut, bool? sellable, int page = 0, int pageSize = 20)
        {
            var result = await _productDataService.GetProducts(sellable, closeOut, dateModified, page, pageSize);
            return result;
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
        public async Task<Product?> Get(string productId)
        {
            var result = await _productDataService.GetProduct(productId);
            if (result == null)
            {
                Response.StatusCode = 404;
                return null;
            }

            return result;
        }
    }
}