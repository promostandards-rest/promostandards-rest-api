using System.Net;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PromoStandards.REST.Validator.API.Models;
using PromoStandards.REST.Validator.API.Service;

namespace PromoStandards.REST.Validator.API.Controllers
{
    [ApiController]
    [Tags("Product Data Validation")]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ISchemaService _schemaService;
        private readonly ILogger<ProductController> _logger;
        private string _dir;
        public ProductController(IHostEnvironment environment, ISchemaService schemaService, ILogger<ProductController> logger)
        {
            _dir = environment.ContentRootPath + @"App_Data";
            _schemaService = schemaService;
            _logger = logger;
        }

        /// <summary>
        /// Get JSON Schema
        /// </summary>
        /// <param name="schemaId"> Product, Inventory, FilterValues </param>
        /// <returns></returns>
        [HttpGet("/{schemaId}")]
        public IActionResult Get(string schemaId)
        {
            try
            {
                var schema = _schemaService.Get(schemaId);
                if (_schemaService.ProblemDetails.Status == (int)HttpStatusCode.OK)
                {
                    return Ok(schema);
                }
                else if (_schemaService.ProblemDetails.Status == (int)HttpStatusCode.InternalServerError)
                {
                    _logger.LogWarning("ProductController-Get, SchemaId:+ schemaId, Error: " + _schemaService.ProblemDetails.Detail);
                    return new StatusCodeResult(StatusCodes.Status500InternalServerError);
                }
                else
                {
                    //ObjectResult Problem(string? detail = null, string? instance = null, int? statusCode = null,   string? title = null, string? type = null);
                    return Problem(_schemaService.ProblemDetails.Detail, null, _schemaService.ProblemDetails.Status, _schemaService.ProblemDetails.Title, null);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "ProductController-Get, SchemaId {0}", schemaId);
                return new StatusCodeResult(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpPost("/Generate/{schemaId}")]
        public IActionResult Generate(string schemaId)
        {
            try
            {
                var schema = _schemaService.Generate(schemaId);
                if (_schemaService.ProblemDetails.Status == (int)HttpStatusCode.OK)
                {
                    var createdSchema = new GeneratedSchema() { Id = schemaId, Schema = schema };
                    return Created("schemaId", createdSchema);
                }
                else if (_schemaService.ProblemDetails.Status == (int)HttpStatusCode.InternalServerError)
                {
                    _logger.LogWarning("ProductController-Generate, SchemaId:+ schemaId, Error: " + _schemaService.ProblemDetails.Detail);
                    return new StatusCodeResult(StatusCodes.Status500InternalServerError);
                }
                else
                {
                    return Problem(_schemaService.ProblemDetails.Detail, null, _schemaService.ProblemDetails.Status, _schemaService.ProblemDetails.Title, null);
                }

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Product-Generate, Error while processing SchemaId {0}", schemaId);
                return new StatusCodeResult(StatusCodes.Status500InternalServerError);
            }

        }

        /// <summary>
        /// Valiadte JSON data
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("/Validate")]
        public async Task<IActionResult> Validate([FromForm] ValidationRequest request)
        {
            try
            {
                var response = await _schemaService.Validate(request);
                if (_schemaService.ProblemDetails.Status == (int)HttpStatusCode.OK)
                {
                    return Ok(response);

                }
                else if (_schemaService.ProblemDetails.Status == (int)HttpStatusCode.InternalServerError)
                {
                    _logger.LogWarning("ProductController-Validate, Request: " + JsonConvert.SerializeObject(request) + ", Error: " + _schemaService.ProblemDetails.Detail);
                    return new StatusCodeResult(StatusCodes.Status500InternalServerError);
                }
                else
                {
                    return Problem(_schemaService.ProblemDetails.Detail, null, _schemaService.ProblemDetails.Status, _schemaService.ProblemDetails.Title, null);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "ProductController - Validate, Request: " + JsonConvert.SerializeObject(request));
                return new StatusCodeResult(StatusCodes.Status500InternalServerError);
            }
        }
    }
}

