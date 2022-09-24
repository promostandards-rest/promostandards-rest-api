using Microsoft.AspNetCore.Mvc;
using PromoStandards.REST.Abstraction;
using PromoStandards.REST.API.Common;
using PromoStandards.REST.Core.Inventory;
using PromoStandards.REST.Core.MediaContent.ServiceReference;
using PromoStandards.REST.Core.ProductData.Models;
using PromoStandards.REST.Core.ProductData.ServiceReference;

namespace PromoStandards.REST.API.Controllers
{
    [ApiController]
    [Tags("Product Data")]
    [Route("api/products")]
    public class ProductDataController : ControllerBase
    {
        private readonly IProductDataService _productDataService;
        private readonly IMyInventoryService _inventoryService;
        private readonly IMyInventoryFilterService _inventoryFilterService;
        private readonly IMediaContentService _mediaContentService;

        public ProductDataController(IProductDataService productDataService, IMyInventoryService inventoryService, IMediaContentService mediaContentService, IMyInventoryFilterService inventoryFilterService)
        {
            _productDataService = productDataService;
            _inventoryService = inventoryService;
            _inventoryFilterService = inventoryFilterService;
            _mediaContentService = mediaContentService;
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
        /// <response code="204">No products found</response>
        /// <response code="500">Internal Server Error</response>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<CollectionResponse<Product>>> GetProducts(DateTime? dateModified, bool? closeOut, bool? sellable, [FromQuery] PagingRequest paging)
        {
            var result = await _productDataService.GetProducts(sellable, closeOut, dateModified, paging.page, paging.pageSize);
            return result;
        }

        /// <summary>
        /// Provides the detail product data based on a specific ProductId provided at the request.
        /// </summary>
        /// <param name="productId">The supplier's ID for a given product</param>
        /// <remarks>
        /// </remarks>
        /// <response code="200">Returns the product</response>
        /// <response code="404">Product using productId is not found</response>
        /// <response code="500">Internal Server Error</response>
        [HttpGet("{productId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<Product?>> GetProduct(string productId)
        {
            var result = await _productDataService.GetProduct(new GetProductRequest()
            {
                productId = productId
            });
            if (result == null)
            {
                return new NotFoundResult();
            }

            return result.Product;
        }
    }
}