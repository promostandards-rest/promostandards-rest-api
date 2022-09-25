using System.Net;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using Newtonsoft.Json.Schema.Generation;
using Newtonsoft.Json.Serialization;
using PromoStandards.REST.Core.Inventory;
using PromoStandards.REST.Core.ProductData.ServiceReference;
using PromoStandards.REST.Validator.API.Models;

namespace PromoStandards.REST.Validator.API.Service
{
    public interface ISchemaService
    {
        ProblemDetails ProblemDetails { get; set; }
        string? Get(string schemaId);
        string? Generate(string schemaId);
        Task<ValidationResult?> Validate(ValidationRequest request);
    }
    public class SchemaService: ISchemaService
    {
        public ProblemDetails ProblemDetails { get; set; }
        private string _dir;

        public SchemaService(IHostEnvironment environment)
        {
            _dir = environment.ContentRootPath + @"App_Data";
        }

        public string? Get(string schemaId)
        {
            ProblemDetails = new ProblemDetails() { Status = (int)HttpStatusCode.OK };
            try
            {
                if (string.IsNullOrEmpty(schemaId))
                {
                    ProblemDetails.Status = (int)HttpStatusCode.BadRequest;
                    ProblemDetails.Title = "Schema ID is required";
                    return null;
                }

                var fileName = Path.Combine(_dir, schemaId + ".json");
                if (!System.IO.File.Exists(fileName))
                {
                    ProblemDetails.Status = (int)HttpStatusCode.BadRequest;
                    ProblemDetails.Title = "Schema not found";
                    return null;
                }

                var schema = JSchema.Parse(System.IO.File.ReadAllText(fileName));
                return schema.ToString();
            }
            catch (Exception ex)
            {
                ProblemDetails.Status = (int)HttpStatusCode.InternalServerError;
                ProblemDetails.Title = "Error getting schema";
                ProblemDetails.Detail = ex.Message;
                return null;
            }
        }

        
        public string? Generate(string schemaId)
        {
            ProblemDetails = new ProblemDetails() { Status = (int)HttpStatusCode.OK };
            try
            {
                if (string.IsNullOrEmpty(schemaId))
                {
                    ProblemDetails.Status = (int)HttpStatusCode.BadRequest;
                    ProblemDetails.Title = "Schema ID is required";
                    return null;
                }

                // Some schemas are modified manually
                // Accidentally override protection
                var ids = Enum.GetNames(typeof(SchemaIds));
                ids = ids.Select(x => x.ToLower()).ToArray();
                if (ids.Contains(schemaId.ToLower()))
                {
                    ProblemDetails.Status = (int)HttpStatusCode.BadRequest;
                    ProblemDetails.Title = "Specified Schema Already Exists";
                    return null;
                }

                var fileName = Path.Combine(_dir, schemaId + ".json");
                if (System.IO.File.Exists(fileName))
                {
                    ProblemDetails.Status = (int)HttpStatusCode.BadRequest;
                    ProblemDetails.Title = "Specified Schema Already Exists";
                    return null;
                }

                var generator = new JSchemaGenerator();

                // change contract resolver so property names are camel case
                generator.ContractResolver = new CamelCasePropertyNamesContractResolver();

                // change Zone enum to generate a string
                generator.GenerationProviders.Add(new StringEnumGenerationProvider());

                JSchema schema;
                var schemaName = ids.First(x => x == schemaId.ToLower());
                switch (schemaName)
                {
                    case "inventory":
                        schema = generator.Generate(typeof(Inventory));
                        break;
                    case "productdata":
                        schema = generator.Generate(typeof(Product));
                        break;
                    case "filtervalues":
                        schema = generator.Generate(typeof(GetFilterValuesResponse));
                        break;
                    default:
                        ProblemDetails.Status = (int)HttpStatusCode.BadRequest;
                        ProblemDetails.Title = "Not Support yet, please update the code";
                        return null;
                }

                // serialize JSchema to a string and then write string to a file
                System.IO.File.WriteAllText(fileName, schema.ToString());
                return schema.ToString();
            }
            catch (Exception ex)
            {
                ProblemDetails.Status = (int)HttpStatusCode.InternalServerError;
                ProblemDetails.Title = "Error generating schema: " + schemaId;
                ProblemDetails.Detail = ex.Message;
                return null;
            }

        }
        
        
        public async Task<ValidationResult?> Validate(ValidationRequest request)
        {
            ProblemDetails = new ProblemDetails() { Status = (int)HttpStatusCode.OK };
            var requestValid = ValidateRequest(request);
            if (requestValid != null)
            {
                ProblemDetails.Status = (int)HttpStatusCode.BadRequest;
                ProblemDetails.Title = requestValid;
                return null;
            }

            // Full path to file in temp location
            var filePath = Path.GetTempFileName();

            try
            {
                if (request.SchemaId.ToLower().Trim() != "product")
                {
                    ProblemDetails.Status = (int)HttpStatusCode.BadRequest;
                    ProblemDetails.Title = "Specified Schema Does Not Supported, for now, we support: product";
                    return null;
                }

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await request.JsonFile.CopyToAsync(stream);
                }

                // load JSchema directly from a file
                JToken obj = JToken.Parse(System.IO.File.ReadAllText(filePath));

                // Get Schema
                var fileName = Path.Combine(_dir, request.SchemaId.ToLower() + ".json");

                if (!System.IO.File.Exists(fileName))
                {
                    ProblemDetails.Status = (int)HttpStatusCode.BadRequest;
                    ProblemDetails.Title = "Schema not found";
                    return null;
                }

                var schema = JSchema.Parse(System.IO.File.ReadAllText(fileName));

                bool isValid = obj.IsValid(schema, out IList<string> errorMessages);

                var response = new ValidationResult()
                {
                    IsValid = isValid,
                };
                if (!isValid)
                {
                    response.Messages = errorMessages;
                }
                return response;

            }
            catch (JsonReaderException jrException)
            {
                ProblemDetails.Status = (int)HttpStatusCode.BadRequest;
                ProblemDetails.Title = "JsonReaderException";
                ProblemDetails.Detail = jrException.Message;
                return null;
            }
            catch (Exception ex)
            {
                ProblemDetails.Status = (int)HttpStatusCode.InternalServerError;
                ProblemDetails.Title = "Error validating json";
                ProblemDetails.Detail = ex.Message;
                return null;
            }
        }

        private string? ValidateRequest(ValidationRequest request)
        {
            if (request == null)
            {
                return "ValidationRequest is null";
            }
            if (request.SchemaId == null)
            {
                return "SchemaId is null";
            }
            if (request.JsonFile == null)
            {
                return "JsonFile is null";
            }
            if (request.JsonFile.Length == 0)
            {
                return "Invalid JsonFile";
            }

            return null;
        }
    }

}

