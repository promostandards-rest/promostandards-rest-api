using Microsoft.AspNetCore.Mvc;
using PromoStandards.REST.Abstraction;
using PromoStandards.REST.Core.Inventory;
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
        private readonly IInventoryService _inventoryService;

        public ProductDataController(IProductDataService productDataService, IInventoryService inventoryService)
        {
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
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<CollectionResponse<Product>> GetProducts(DateTime? dateModified, bool? closeOut, bool? sellable, int page = 0, int pageSize = 20)
        {
            var result = await _productDataService.GetProducts(sellable, closeOut, dateModified, page, pageSize);
            return result;
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
        public async Task<GetProductResponse?> GetProduct(string productId)
        {
            var result = await _productDataService.getProductAsync(new getProductRequest1(new GetProductRequest()
            {
                productId = productId
            }));
            if (result == null)
            {
                Response.StatusCode = 404;
                return null;
            }

            return result.GetProductResponse;
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
        public async Task<IEnumerable<string>> GetProductColors(string productId)
        {
            var result = await _productDataService.getProductAsync(new getProductRequest1(new GetProductRequest()
            {
                productId = productId
            }));
            if (result == null)
            {
                Response.StatusCode = 404;
                return null;
            }

            if (result.GetProductResponse.Product.ProductPartArray == null)
                return new List<string>();

            var colorArray = result.GetProductResponse.Product.ProductPartArray.Where(p => p.ColorArray != null).SelectMany(p => p.ColorArray);
            var colorList = colorArray.Select(p => p.colorName).Where(p => !string.IsNullOrWhiteSpace(p)).Distinct().ToList();
            return colorList;
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
        public async Task<IEnumerable<ApparelStyle>> GetProductSizes(string productId)
        {
            var result = await _productDataService.getProductAsync(new getProductRequest1(new GetProductRequest()
            {
                productId = productId
            }));
            if (result == null)
            {
                Response.StatusCode = 404;
                return null;
            }

            if (result.GetProductResponse.Product.ProductPartArray == null)
                return new List<ApparelStyle>();

            var sizeArray = result.GetProductResponse.Product.ProductPartArray.Where(p => p.ApparelSize != null).Select(p => p.ApparelSize);
            var sizeList = sizeArray.Select(p => p.apparelStyle).Distinct().ToList();
            return sizeList;
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
        public  async Task<IEnumerable<string>> GetProductParts(string productId)
        {
            var result = await _productDataService.getProductAsync(new getProductRequest1(new GetProductRequest()
            {
                productId = productId
            }));
            if (result == null)
            {
                Response.StatusCode = 404;
                return null;
            }

            if (result.GetProductResponse.Product.ProductPartArray == null)
                return new List<string>();

            var partList = result.GetProductResponse.Product.ProductPartArray.Select(p => p.partId).ToList();
            return partList;
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
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetInventoryLevels(string productId)
        {
            try
            {
                if (string.IsNullOrEmpty(productId))
                {
                    return BadRequest("ProductId Required");
                }
                var request = new GetInventoryLevelsRequest() { wsVersion = wsVersion.Item200, productId = productId.ToUpper() };
                var response = await _inventoryService.GetInventoryLevels(request);
                if (response == null)
                {
                    return new StatusCodeResult(StatusCodes.Status204NoContent);
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