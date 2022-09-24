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
    [Tags("Media Content")]
    [Route("api/products")]
    public class MediaController : ControllerBase
    {
        private readonly IProductDataService _productDataService;
        private readonly IMyInventoryService _inventoryService;
        private readonly IMyInventoryFilterService _inventoryFilterService;
        private readonly IMediaContentService _mediaContentService;

        public MediaController(IProductDataService productDataService, IMyInventoryService inventoryService, IMediaContentService mediaContentService, IMyInventoryFilterService inventoryFilterService)
        {
            _productDataService = productDataService;
            _inventoryService = inventoryService;
            _inventoryFilterService = inventoryFilterService;
            _mediaContentService = mediaContentService;
        }
       
        /// <summary>
        /// Provides the images of a specific ProductId provided in the request.
        /// </summary>
        /// <param name="productId">The supplier's ID for a given product</param>
        /// <param name="cultureName"></param>
        /// <param name="partId"></param>
        /// <param name="classType"></param>
        /// <param name="lastModifiedDate"></param>
        /// <remarks>
        /// </remarks>
        /// <response code="200">Returns product images</response>
        /// <response code="204">Product does not have any images</response>
        /// <response code="404">Product using productId is not found</response>
        /// <response code="500">Internal Server Error</response>
        [HttpGet("{productId}/images")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<CollectionResponse<MediaContent>>> GetImages(String productId, String? cultureName, String? partId, int? classType, DateTime? lastModifiedDate)
        {
            try
            {
                if (string.IsNullOrEmpty(productId))
                {
                    return BadRequest("ProductId Required");
                }
                var response = await _mediaContentService.GetProductMedia(
                    productId,
                    mediaTypeType.Image,
                    partId,
                    cultureName,
                    classType,
                    lastModifiedDate
                );
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

        /// <summary>
        /// Provides the audios of a specific ProductId provided in the request.
        /// </summary>
        /// <param name="productId">The supplier's ID for a given product</param>
        /// <param name="cultureName"></param>
        /// <param name="partId"></param>
        /// <param name="classType"></param>
        /// <param name="lastModifiedDate"></param>
        /// <remarks>
        /// </remarks>
        /// <response code="200">Returns product audios</response>
        /// <response code="204">Product does not have any audios</response>
        /// <response code="404">Product using productId is not found</response>
        /// <response code="500">Internal Server Error</response>
        [HttpGet("{productId}/audios")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<CollectionResponse<MediaContent>>> GetAudios(String productId, String? cultureName, String? partId, int? classType, DateTime? lastModifiedDate)
        {
            try
            {
                if (string.IsNullOrEmpty(productId))
                {
                    return BadRequest("ProductId Required");
                }
                var response = await _mediaContentService.GetProductMedia(
                    productId,
                    mediaTypeType.Audio,
                    partId,
                    cultureName,
                    classType,
                    lastModifiedDate
                );
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


        /// <summary>
        /// Provides the documents of a specific ProductId provided in the request.
        /// </summary>
        /// <param name="productId">The supplier's ID for a given product</param>
        /// <param name="cultureName"></param>
        /// <param name="partId"></param>
        /// <param name="classType"></param>
        /// <param name="lastModifiedDate"></param>
        /// <remarks>
        /// </remarks>
        /// <response code="200">Returns product documents</response>
        /// <response code="204">Product does not have any documents</response>
        /// <response code="404">Product using productId is not found</response>
        /// <response code="500">Internal Server Error</response>
        [HttpGet("{productId}/documents")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<CollectionResponse<MediaContent>>> GetDocuments(String productId, String? cultureName, String? partId, int? classType, DateTime? lastModifiedDate)
        {
            try
            {
                if (string.IsNullOrEmpty(productId))
                {
                    return BadRequest("ProductId Required");
                }
                var response = await _mediaContentService.GetProductMedia(
                    productId,
                    mediaTypeType.Document,
                    partId,
                    cultureName,
                    classType,
                    lastModifiedDate
                );
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

        /// <summary>
        /// Provides the videos of a specific ProductId provided in the request.
        /// </summary>
        /// <param name="productId">The supplier's ID for a given product</param>
        /// <param name="cultureName"></param>
        /// <param name="partId"></param>
        /// <param name="classType"></param>
        /// <param name="lastModifiedDate"></param>
        /// <remarks>
        /// </remarks>
        /// <response code="200">Returns product videos</response>
        /// <response code="204">Product does not have any videos</response>
        /// <response code="404">Product using productId is not found</response>
        /// <response code="500">Internal Server Error</response>
        [HttpGet("{productId}/videos")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<CollectionResponse<MediaContent>>> GetVideos(String productId, String? cultureName, String? partId, int? classType, DateTime? lastModifiedDate)
        {
            try
            {
                if (string.IsNullOrEmpty(productId))
                {
                    return BadRequest("ProductId Required");
                }
                var response = await _mediaContentService.GetProductMedia(
                    productId,
                    mediaTypeType.Video,
                    partId,
                    cultureName,
                    classType,
                    lastModifiedDate
                );
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