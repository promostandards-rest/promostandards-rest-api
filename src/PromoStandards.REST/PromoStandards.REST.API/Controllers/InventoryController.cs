using Microsoft.AspNetCore.Mvc;
using PromoStandards.REST.Abstraction;
using PromoStandards.REST.API.Common;
using PromoStandards.REST.Core.Inventory;
using PromoStandards.REST.Core.MediaContent.ServiceReference;
using PromoStandards.REST.Core.ProductData.Models;
using PromoStandards.REST.Core.ProductData.ServiceReference;

namespace PromoStandards.REST.API.Controllers {
    [ApiController]
    [Tags("Inventory")]
    [Route("api/products")]
    public class InventoryController : ControllerBase {
        private readonly IProductDataService _productDataService;
        private readonly IMyInventoryService _inventoryService;
        private readonly IMyInventoryFilterService _inventoryFilterService;
        private readonly IMediaContentService _mediaContentService;

        public InventoryController(IProductDataService productDataService, IMyInventoryService inventoryService, IMediaContentService mediaContentService, IMyInventoryFilterService inventoryFilterService) {
            _productDataService = productDataService;
            _inventoryService = inventoryService;
            _inventoryFilterService = inventoryFilterService;
            _mediaContentService = mediaContentService;
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
        public async Task<ActionResult<CollectionResponse<Color>>> GetProductColors(string productId) {
            var result = await _productDataService.GetProduct(new GetProductRequest() {
                productId = productId
            });
            if (result == null)
                return new NoContentResult();

            if (result?.Product?.ProductPartArray == null)
                return new NoContentResult();

            var colorArray = result.Product.ProductPartArray.Where(p => p.ColorArray != null).SelectMany(p => p.ColorArray).ToList();
            //var colorList = colorArray.Select(p => p.colorName).Where(p => !string.IsNullOrWhiteSpace(p)).Distinct().ToList();
            return new CollectionResponse<Color>(colorArray);
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
        public async Task<ActionResult<CollectionResponse<ApparelSize>>> GetProductSizes(string productId) {
            var result = await _productDataService.GetProduct(new GetProductRequest() {
                productId = productId
            });
            if (result == null)
                return new NoContentResult();

            if (result.Product.ProductPartArray == null)
                return new NoContentResult();
            //ApparelSizeLabelSize
            var sizeArray = result.Product.ProductPartArray.Where(p => p.ApparelSize != null).Select(p => p.ApparelSize).ToList();
            //var sizeList = sizeArray.Select(p => p.labelSize).Distinct().ToList();
            return new CollectionResponse<ApparelSize>(sizeArray);
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
            var result = await _productDataService.GetProduct(new GetProductRequest() {
                productId = productId
            });
            if (result == null)
                return new NoContentResult();

            if (result.Product?.ProductPartArray == null)
                return new NoContentResult();

            var partList = result.Product.ProductPartArray.Select(p => p.partId).ToList();
            return new CollectionResponse<string>(partList);
        }

        #region  ------------------------------------  Inventory ------------------------------------


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
        public async Task<ActionResult<CollectionResponse<PartInventoryArrayPartInventory>>> GetInventoryLevels(string productId, [FromQuery] GetInventoryFilter filter) {
            try {
                if (string.IsNullOrEmpty(productId)) {
                    return BadRequest("ProductId Required");
                }
                var request = new GetInventoryLevelsRequest() {
                    wsVersion = wsVersion.Item200,
                    productId = productId.ToUpper(),
                    Filter = new Filter()
                };

                var filterPartIds = Helpers.GetStringList(filter.PartIds);
                var filterColors = Helpers.GetStringList(filter.PartColors);
                //var filterSizes = Helpers.GetStringList(filter.PartSizes);

                if (Helpers.ObjectsAny(filterPartIds) | Helpers.ObjectsAny(filterColors)) {
                    var validatorFilter = await _inventoryFilterService.GetFilterValues(wsVersion.Item200, productId.Trim().ToUpper());
                    if (validatorFilter != null) {
                        if (validatorFilter.FilterValues == null || validatorFilter.FilterValues.Filter == null) {
                            return BadRequest("FilterValues.Filter not supported for this product");
                        }

                        if (Helpers.ObjectsAny(filterPartIds)) {
                            var validatorPartIds = validatorFilter.FilterValues.Filter.partIdArray;
                            if (!Helpers.ObjectsAny(validatorPartIds)) {
                                return BadRequest("Invalid PartIds");
                            }

                            var invalidPartIds = filterPartIds.Except(validatorPartIds);
                            if (Helpers.ObjectsAny(invalidPartIds)) {
                                return BadRequest("Invalid PartIds: " + string.Join(",", invalidPartIds));
                            }
                            request.Filter.partIdArray = filterPartIds.ToArray();
                        }


                        if (Helpers.ObjectsAny(filterColors)) {
                            var validatorColors = validatorFilter.FilterValues.Filter.PartColorArray;

                            if (!Helpers.ObjectsAny(validatorColors)) {
                                return BadRequest("Invalid Colors");
                            }
                            var upercaseColors = validatorColors.Select(x => x.ToUpperInvariant()).ToArray();

                            var invalidColors = filterColors.Except(upercaseColors);

                            if (Helpers.ObjectsAny(invalidColors)) {
                                return BadRequest("Invalid Colors: " + string.Join(",", invalidColors));
                            }

                            request.Filter.PartColorArray = validatorColors.Where(x => filterColors.Contains(x.ToUpper())).ToArray();
                        }
                    }
                }

                var response = await _inventoryService.GetInventoryLevels(request);
                if (response == null) {
                    //return new StatusCodeResult(StatusCodes.Status204NoContent);
                    return Ok("No Content for the Specified Product");
                }
                return Ok(new CollectionResponse<PartInventoryArrayPartInventory>(response.PartInventoryArray.ToList()));
            } catch (Exception ex) {
                return new StatusCodeResult(StatusCodes.Status500InternalServerError);
            }
        }


        ///// <summary>
        ///// Provides the inventory filters of a specific ProductId provided in the request.
        ///// </summary>
        ///// <param name="productId">The supplier's ID for a given product</param>
        ///// <remarks>
        ///// </remarks>
        /////
        //[HttpGet("{productId}/inventory/filterValues")]
        //[ProducesResponseType(StatusCodes.Status200OK)]
        //[ProducesResponseType(StatusCodes.Status204NoContent)]
        //[ProducesResponseType(StatusCodes.Status400BadRequest)]
        //[ProducesResponseType(StatusCodes.Status401Unauthorized)]
        //[ProducesResponseType(StatusCodes.Status500InternalServerError)]
        //public async Task<IActionResult> GetInventoryFilterValues(string productId)
        //{
        //    try
        //    {
        //        if (string.IsNullOrEmpty(productId))
        //        {
        //            return BadRequest("ProductId Required");
        //        }

        //        var response = await _inventoryFilterService.GetFilterValues(wsVersion.Item200, productId.Trim().ToUpper());
        //        if (response == null)
        //        {
        //            return new StatusCodeResult(StatusCodes.Status204NoContent);
        //        }
        //        return Ok(response);
        //    }
        //    catch (Exception ex)
        //    {
        //        return new StatusCodeResult(StatusCodes.Status500InternalServerError);
        //    }
        //}

        #endregion


    }
}