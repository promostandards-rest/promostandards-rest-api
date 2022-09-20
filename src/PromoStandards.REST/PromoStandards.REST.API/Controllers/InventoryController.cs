using System;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Hosting;
using PromoStandards.REST.Core.Inventory;
using PromoStandards.REST.Abstraction;

namespace PromoStandards.REST.API.Controllers
{
    [Produces("application/json")]
    [ApiController]
    [Route("api/[controller]")]
    public class InventoryController : ControllerBase
    {
        private readonly ILogger<InventoryController> _logger;
        private readonly IInventoryService _staticInventoryService;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public InventoryController(ILogger<InventoryController> logger,
                                   IInventoryService staticInventoryService,
                                   IWebHostEnvironment webHostEnvironment)
        {
            _logger = logger;
            _staticInventoryService = staticInventoryService;
            _webHostEnvironment = webHostEnvironment;
        }

        /// <summary>
        /// Get Inventory Filter Values
        /// </summary>
        /// <returns>getFilterValuesRequest</returns>   
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(GetFilterValuesResponse))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpGet("getFilterValues")]
        public IActionResult getFilterValues(wsVersion wsVersion, string productId)
        {
            _logger.LogInformation("getFilterValues");

            try
            {
                var request = new GetFilterValuesRequest() { wsVersion = wsVersion, productId = productId };
                var response = _staticInventoryService.GetFilterValues(request);

                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return new StatusCodeResult(StatusCodes.Status500InternalServerError);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(GetFilterValuesResponse))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpGet("GetInventoryLevels")]
        public IActionResult GetInventoryLevels(wsVersion wsVersion, string productId)
        {
            _logger.LogInformation("GetInventoryLevelsResponse");

            try
            {
                var request = new GetInventoryLevelsRequest() { wsVersion = wsVersion, productId = productId };
                var response = _staticInventoryService.GetInventoryLevels(request);
                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return new StatusCodeResult(StatusCodes.Status500InternalServerError);
            }
        }

    }
}
