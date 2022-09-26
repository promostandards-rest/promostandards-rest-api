using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using PromoStandards.REST.API.Common;
using System.Net;
using Newtonsoft.Json.Schema;
using Newtonsoft.Json.Schema.Generation;
using PromoStandards.REST.Core.Inventory;
using PromoStandards.REST.Core.ProductData.ServiceReference;

namespace PromoStandards.REST.API.Services {
    public interface ISchemaService {
        ProblemDetails ProblemDetails { get; set; }
        string? Get(string schemaId);
        string? Generate(string schemaId);
        Task<ValidationResult?> Validate(ValidationRequest request);
    }
    public class SchemaService : ISchemaService {
        public ProblemDetails ProblemDetails { get; set; }
        private string _dir;

        public SchemaService(IHostEnvironment environment) {
            _dir = environment.ContentRootPath + @"\App_Data";
            if (!Directory.Exists(_dir)) {
                Directory.CreateDirectory(_dir);
            }
        }

        public string? Get(string schemaId) {
            ProblemDetails = new ProblemDetails() { Status = (int) HttpStatusCode.OK };
            try {
                if (string.IsNullOrEmpty(schemaId)) {
                    ProblemDetails.Status = (int) HttpStatusCode.BadRequest;
                    ProblemDetails.Title = "Schema ID is required";
                    return null;
                }

                var fileName = Path.Combine(_dir, schemaId + ".json");
                if (!File.Exists(fileName)) {
                    ProblemDetails.Status = (int) HttpStatusCode.BadRequest;
                    ProblemDetails.Title = "Schema not found";
                    return null;
                }

                var schema = JSchema.Parse(File.ReadAllText(fileName));
                return schema.ToString();
            } catch (Exception ex) {
                ProblemDetails.Status = (int) HttpStatusCode.InternalServerError;
                ProblemDetails.Title = "Error getting schema";
                ProblemDetails.Detail = ex.Message;
                return null;
            }
        }


        public string? Generate(string schemaId) {
            ProblemDetails = new ProblemDetails() { Status = (int) HttpStatusCode.OK };
            try {
                if (string.IsNullOrEmpty(schemaId)) {
                    ProblemDetails.Status = (int) HttpStatusCode.BadRequest;
                    ProblemDetails.Title = "Schema ID is required";
                    return null;
                }

                var ids = Enum.GetNames(typeof(SchemaIds));
                ids = ids.Select(x => x.ToLower()).ToArray();

                //// Some schemas are modified manually
                //// Accidentally override protection
                //if (ids.Contains(schemaId.ToLower())) {
                //    ProblemDetails.Status = (int) HttpStatusCode.BadRequest;
                //    ProblemDetails.Title = "Specified Schema Already Exists";
                //    return null;
                //}

                var fileName = Path.Combine(_dir, schemaId + ".json");
                if (File.Exists(fileName)) {
                    ProblemDetails.Status = (int) HttpStatusCode.BadRequest;
                    ProblemDetails.Title = "Specified Schema Already Exists";
                    return null;
                }

                var generator = new JSchemaGenerator();

                // change contract resolver so property names are camel case
                generator.ContractResolver = new CamelCasePropertyNamesContractResolver();

                // change Zone enum to generate a string
                generator.GenerationProviders.Add(new StringEnumGenerationProvider());

                JSchema schema;
                var schemaName = ids.FirstOrDefault(x => x == schemaId.ToLower());
                switch (schemaName) {
                    case "inventory":
                        schema = generator.Generate(typeof(Inventory));
                        break;
                    case "product":
                        schema = generator.Generate(typeof(Product));
                        break;
                    case "filtervalues":
                        schema = generator.Generate(typeof(GetFilterValuesResponse));
                        break;
                    default:
                        ProblemDetails.Status = (int) HttpStatusCode.BadRequest;
                        ProblemDetails.Title = "Not Support yet, please update the code";
                        return null;
                }

                // serialize JSchema to a string and then write string to a file
                File.WriteAllText(fileName, schema.ToString());
                return schema.ToString();
            } catch (Exception ex) {
                ProblemDetails.Status = (int) HttpStatusCode.InternalServerError;
                ProblemDetails.Title = "Error generating schema: " + schemaId;
                ProblemDetails.Detail = ex.Message;
                return null;
            }

        }


        public async Task<ValidationResult?> Validate(ValidationRequest request) {
            ProblemDetails = new ProblemDetails() { Status = (int) HttpStatusCode.OK };
            var requestValid = ValidateRequest(request);
            if (requestValid != null) {
                ProblemDetails.Status = (int) HttpStatusCode.BadRequest;
                ProblemDetails.Title = requestValid;
                return null;
            }

            try {
                //if (request.SchemaId.ToLower().Trim() != "product") {
                //    ProblemDetails.Status = (int) HttpStatusCode.BadRequest;
                //    ProblemDetails.Title = "Specified Schema Does Not Supported, for now, we support: product";
                //    return null;
                //}

                // load JSchema directly from a file
                JToken obj = JToken.Parse(request.JsonData);

                // Get Schema
                var fileName = Path.Combine(_dir, request.SchemaId.ToLower() + ".json");

                if (!File.Exists(fileName)) {
                    ProblemDetails.Status = (int) HttpStatusCode.BadRequest;
                    ProblemDetails.Title = "Schema not found";
                    return null;
                }

                var schema = JSchema.Parse(File.ReadAllText(fileName));

                bool isValid = obj.IsValid(schema, out IList<string> errorMessages);

                var response = new ValidationResult() {
                    IsValid = isValid,
                };
                if (!isValid) {
                    response.Messages = errorMessages;
                }
                return response;

            } catch (JsonReaderException jrException) {
                ProblemDetails.Status = (int) HttpStatusCode.BadRequest;
                ProblemDetails.Title = "JsonReaderException";
                ProblemDetails.Detail = jrException.Message;
                return null;
            } catch (Exception ex) {
                ProblemDetails.Status = (int) HttpStatusCode.InternalServerError;
                ProblemDetails.Title = "Error validating json";
                ProblemDetails.Detail = ex.Message;
                return null;
            }
        }

        private string? ValidateRequest(ValidationRequest request) {
            if (request == null) {
                return "ValidationRequest is null";
            }
            if (request.SchemaId == null) {
                return "SchemaId is null";
            }
            if (request.JsonData == null) {
                return "JsonData is null";
            }
            if (request.JsonData.Length == 0) {
                return "Invalid JsonData";
            }

            return null;
        }
    }
}
