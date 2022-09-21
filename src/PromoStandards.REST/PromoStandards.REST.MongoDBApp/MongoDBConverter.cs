using System;
using System.Linq;
using System.ServiceModel;
using System.Text.Json;
using Microsoft.Extensions.Options;
using System.Threading.Tasks;
using PromoStandards.REST.Core.ProductData.Models;
using PromoStandards.REST.MongoDB;

namespace PromoStandards.REST.MongoDBApp
{
    public class MongoDBConverter
    {
        private readonly MongoDBProductService _productService;
        private readonly MongoDBConverterConfig _config;

        public MongoDBConverter(IOptions<MongoDBConverterConfig> config, MongoDBProductService productService)
        {
            _productService = productService;
            _config = config.Value;
        }

        public async Task Process()
        {
            var list = await _productService.GetAll();
            var basicHttpsBinding = new BasicHttpsBinding()
            {
                MaxReceivedMessageSize = int.MaxValue,
                MaxBufferPoolSize = int.MaxValue,
                MaxBufferSize = int.MaxValue,
            };

            var client = new ProductDataServiceClient(basicHttpsBinding, new EndpointAddress(_config.Endpoint));

            var sellable = await client.getProductSellableAsync(new GetProductSellableRequest()
            {
                wsVersion = _config.WsVersion,
                id = _config.Id,
                password = _config.Password,
                isSellable = true,
                localizationCountry = _config.LocalizationCountry,
                localizationLanguage = _config.LocalizationLanguage
            });
            var sellableIds = sellable.GetProductSellableResponse.ProductSellableArray.Select(p => p.productId).ToList();
            foreach (var productId in sellableIds)
            {
                try
                {
                    var product = await client.getProductAsync(new GetProductRequest
                    {
                        wsVersion = _config.WsVersion,
                        id = _config.Id,
                        password = _config.Password,
                        localizationCountry = _config.LocalizationCountry,
                        localizationLanguage = _config.LocalizationLanguage,
                        productId = productId
                    });
                    var extendedProduct = JsonSerializer.Deserialize<ProductExtended>(JsonSerializer.Serialize(product.GetProductResponse.Product));
                    extendedProduct.isSellable = true;
                    await _productService.InsertUpdateProduct(extendedProduct);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
            var nonSellable = await client.getProductSellableAsync(new GetProductSellableRequest()
            {
                wsVersion = _config.WsVersion,
                id = _config.Id,
                password = _config.Password,
                isSellable = false,
                localizationCountry = _config.LocalizationCountry,
                localizationLanguage = _config.LocalizationLanguage
            });
            var nonSellableIds = nonSellable.GetProductSellableResponse.ProductSellableArray.Select(p => p.productId).ToList();
            foreach (var productId in nonSellableIds)
            {
                try
                {
                    var product = await client.getProductAsync(new GetProductRequest
                    {
                        wsVersion = _config.WsVersion,
                        id = _config.Id,
                        password = _config.Password,
                        localizationCountry = _config.LocalizationCountry,
                        localizationLanguage = _config.LocalizationLanguage,
                        productId = productId
                    });
                    var extendedProduct = JsonSerializer.Deserialize<ProductExtended>(JsonSerializer.Serialize(product));
                    extendedProduct.isSellable = false;
                    await _productService.InsertUpdateProduct(extendedProduct);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }
    }
}