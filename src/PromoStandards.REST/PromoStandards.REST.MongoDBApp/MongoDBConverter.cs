using System;
using System.Linq;
using System.ServiceModel;
using System.Text.Json;
using Microsoft.Extensions.Options;
using System.Threading.Tasks;
using PromoStandards.REST.MongoDB.Inventory;
using PromoStandards.REST.MongoDB.ProductData;
using PromoStandards.REST.MongoDBApp.Inventory.ServiceReference;

namespace PromoStandards.REST.MongoDBApp
{
    public class MongoDBConverter
    {
        private readonly MongoDBProductService _productService;
        private readonly MongoDBInventoryService _inventoryService;
        private readonly MongoDBConverterConfig _config;
        private static BasicHttpsBinding BasicHttpsBinding = new BasicHttpsBinding()
        {
            MaxReceivedMessageSize = int.MaxValue,
            MaxBufferPoolSize = int.MaxValue,
            MaxBufferSize = int.MaxValue,
        };

        public MongoDBConverter(IOptions<MongoDBConverterConfig> config, MongoDBProductService productService, MongoDBInventoryService inventoryService)
        {
            _productService = productService;
            _inventoryService = inventoryService;
            _config = config.Value;
        }

        public async Task Process()
        {
            //await ProductData();
            await Inventory();
        }

        private async Task ProductData()
        {
            var client = new ProductDataServiceClient(BasicHttpsBinding, new EndpointAddress(_config.Endpoint));

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
                    var extendedProduct =
                        JsonSerializer.Deserialize<ProductExtended>(
                            JsonSerializer.Serialize(product.GetProductResponse.Product));
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


        private async Task Inventory()
        {
            var productClient = new ProductDataServiceClient(BasicHttpsBinding, new EndpointAddress(_config.Endpoint));
            var client = new InventoryServiceClient(BasicHttpsBinding, new EndpointAddress(_config.InventoryEndpoint));

            var sellable = await productClient.getProductSellableAsync(new GetProductSellableRequest()
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
                    var product = await client.getInventoryLevelsAsync(new GetInventoryLevelsRequest()
                    {
                        wsVersion = wsVersion.Item200,
                        id = _config.Id,
                        password = _config.Password,
                        productId = productId
                    });
                    var extendedProduct =
                        JsonSerializer.Deserialize<InventoryExtended>(
                            JsonSerializer.Serialize(product.GetInventoryLevelsResponse.Inventory));
                    await _inventoryService.InsertUpdate(extendedProduct);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }
    }
}