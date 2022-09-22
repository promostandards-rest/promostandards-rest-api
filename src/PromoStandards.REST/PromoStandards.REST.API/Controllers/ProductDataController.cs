using Microsoft.AspNetCore.Mvc;
using PromoStandards.REST.Abstraction;
using PromoStandards.REST.Core.Inventory;
using PromoStandards.REST.Core.ProductData.Models;
using PromoStandards.REST.Core.ProductData.ServiceReference;
using Product = PromoStandards.REST.Core.ProductPricingConfiguration.ServiceReference.Product;

namespace PromoStandards.REST.API.Controllers
{
    [ApiController]
    [Tags("Product Data")]
    [Route("api/products")]
    public class ProductDataController : ControllerBase {
        private readonly IProductDataService _productDataService;
        private readonly IInventoryService _inventoryService;

        public ProductDataController(IProductDataService productDataService, IInventoryService inventoryService) {
            _productDataService = productDataService;
            _inventoryService = inventoryService;
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
        public async Task<ActionResult<CollectionResponse<Product>>> GetProducts(DateTime? dateModified, bool? closeOut, bool? sellable, [FromQuery] PagingRequest paging) {
            var result = await _productDataService.GetProducts(sellable, closeOut, dateModified, paging?.page, paging?.pageSize);

            if (result.Total == 0) return new NoContentResult();

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
        public async Task<ActionResult<Product?>> GetProduct(string productId) {
            var result = await _productDataService.GetProduct(productId);
            if (result == null) {
                return new NotFoundResult();
            }

            return result;
        }

        /// <summary>
        /// Provides the available color options for a specific ProductId provided in the request.
        /// </summary>
        /// <param name="productId">The supplier's ID for a given product</param>
        /// <remarks>
        /// </remarks>
        /// <response code="200">Returns a collection of product colors</response>
        /// <response code="204">Product does not have colors</response>
        /// <response code="404">Product using productId is not found</response>
        /// <response code="500">Internal Server Error</response>
        [HttpGet("{productId}/colors")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<CollectionResponse<string>>> GetProductColors(string productId) {
            var result = await _productDataService.GetProduct(productId);
            if (result == null) {
                return new NotFoundResult();
            }

            if (result.ProductPartArray == null || result.ProductPartArray.Length == 0)
                return new NoContentResult();

            var colorArray = result.ProductPartArray.Where(p => p.ColorArray != null).SelectMany(p => p.ColorArray);
            var colorList = colorArray.Select(p => p.colorName).Where(p => !string.IsNullOrWhiteSpace(p)).Distinct().ToList();
            return new CollectionResponse<string>(colorList);
        }

        /// <summary>
        /// Provides the available size options for a specific ProductId provided in the request.
        /// </summary>
        /// <param name="productId">The supplier's ID for a given product</param>
        /// <remarks>
        /// </remarks>
        /// <response code="200">Returns a collection of product sizes</response>
        /// <response code="204">Product does not sizes</response>
        /// <response code="404">Product using productId is not found</response>
        /// <response code="500">Internal Server Error</response>
        [HttpGet("{productId}/sizes")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<CollectionResponse<LabelSize>>> GetProductSizes(string productId) {
            var result = await _productDataService.GetProduct(productId);
            if (result == null) {
                return new NotFoundResult();
            }

            if (result.ProductPartArray == null)
                return new NoContentResult();

            var sizeArray = result.ProductPartArray.Where(p => p.ApparelSize != null).Select(p => p.ApparelSize);
            var sizeList = sizeArray.Select(p => p.labelSize).Distinct().ToList();
            return new CollectionResponse<LabelSize>(sizeList);
        }

        /// <summary>
        /// Provides the parts of a specific ProductId provided in the request.
        /// </summary>
        /// <param name="productId">The supplier's ID for a given product</param>
        /// <remarks>
        /// </remarks>
        /// <response code="200">Returns a collection of product parts</response>
        /// <response code="204">Product does not have parts</response>
        /// <response code="404">Product using productId is not found</response>
        /// <response code="500">Internal Server Error</response>
        [HttpGet("{productId}/parts")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<CollectionResponse<string>>> GetProductParts(string productId) {
            var result = await _productDataService.GetProduct(productId);
            if (result == null) {
                return new NotFoundResult();
            }

            if (result.ProductPartArray == null)
                return new NoContentResult();

            var partList = result.ProductPartArray.Select(p => p.partId).ToList();
            return new CollectionResponse<string>(partList);
        }

        /// <summary>
        /// Provides the inventory levels of a specific ProductId provided in the request.
        /// </summary>
        /// <param name="productId">The supplier's ID for a given product</param>
        /// <param name="parts">List of partIds to filter on</param>
        /// <param name="colors">List of colors to filter on</param>
        /// <param name="sizes">List of sizes to filter on</param>
        /// <remarks>
        /// </remarks>
        /// <response code="200">Returns inventory levels</response>
        /// <response code="204">Product does not have inventory levels</response>
        /// <response code="404">Product using productId is not found</response>
        /// <response code="500">Internal Server Error</response>
        [HttpGet("{productId}/inventory")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<CollectionResponse<PartInventory>>> GetInventoryLevels(
            String productId, [FromQuery] String[]? parts, [FromQuery] String[]? colors, [FromQuery] String[]? sizes)
        {
            try
            {
                if (string.IsNullOrEmpty(productId))
                {
                    return BadRequest("ProductId Required");
                }
                var response = await _inventoryService.GetInventoryLevels(productId, parts, colors, sizes);
                if (response == null)
                {
                    return new NoContentResult();
                }
                return Ok(response);
            }
            catch (Exception ex)
            {
                return new StatusCodeResult(StatusCodes.Status500InternalServerError);
            }
        }

    }
}