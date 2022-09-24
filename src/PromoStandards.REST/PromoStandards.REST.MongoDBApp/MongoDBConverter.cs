using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text.Json;
using Microsoft.Extensions.Options;
using System.Threading.Tasks;
using PromoStandards.REST.MongoDB.MediaContent;
using PromoStandards.REST.MongoDB.ProductData;
using PromoStandards.REST.MongoDBApp.ProductData.ServiceReference;

namespace PromoStandards.REST.MongoDBApp
{
    public class MongoDBConverter
    {
        private readonly MongoDBProductService _productService;
        private readonly MongoDBMediaContentService _mediaContentService;
        //private readonly MongoDBInventoryService _inventoryService;
        private readonly MongoDBConverterConfig _config;
        private static BasicHttpsBinding BasicHttpsBinding = new BasicHttpsBinding()
        {
            MaxReceivedMessageSize = int.MaxValue,
            MaxBufferPoolSize = int.MaxValue,
            MaxBufferSize = int.MaxValue,
        };

        public MongoDBConverter(IOptions<MongoDBConverterConfig> config, MongoDBProductService productService, MongoDBMediaContentService mediaContentService) //, MongoDBInventoryService inventoryService)
        {
            _productService = productService;
            _mediaContentService = mediaContentService;
            //_inventoryService = inventoryService;
            _config = config.Value;
        }

        public async Task Process()
        {
            //await ProductData();
            //await Inventory();
            await MediaContent();
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
        private async Task MediaContent()
        {
            var client = new ProductDataServiceClient(BasicHttpsBinding, new EndpointAddress(_config.Endpoint));
            var mediaClient = new MediaContentServiceClient(BasicHttpsBinding, new EndpointAddress(_config.MediaEndpoint));

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
                    await PopulateMedia(mediaClient, productId, mediaTypeType.Image);
                    await PopulateMedia(mediaClient, productId, mediaTypeType.Video);
                    await PopulateMedia(mediaClient, productId, mediaTypeType.Document);
                    await PopulateMedia(mediaClient, productId, mediaTypeType.Audio);
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

        private async Task PopulateMedia(MediaContentServiceClient mediaClient, string productId, mediaTypeType type)
        {
            var images = await mediaClient.getMediaContentAsync(new GetMediaContentRequest()
            {
                wsVersion = "1.0.0",
                id = _config.Id,
                password = _config.Password,
                productId = productId,
                mediaType = type
            });
            var list = new List<Core.MediaContent.ServiceReference.MediaContent>();
            if (images?.GetMediaContentResponse?.MediaContentArray != null)
            {
                if (images?.GetMediaContentResponse?.MediaContentArray.Length > 0)
                {
                    foreach (var item in images?.GetMediaContentResponse?.MediaContentArray)
                    {
                        list.Add(JsonSerializer.Deserialize<Core.MediaContent.ServiceReference.MediaContent>(
                            JsonSerializer.Serialize(item)));
                    }
                    Enum.TryParse<Core.MediaContent.ServiceReference.mediaTypeType>(type.ToString(), out var mediaType);
                    var extendedProduct = new MediaContentExtended()
                    {
                        MediaContent = list,
                        MediaType = mediaType,
                        ProductId = productId
                    };
                    await _mediaContentService.InsertUpdate(extendedProduct);
                }
            }
        }

        //private async Task Inventory()
        //{
        //    var productClient = new ProductDataServiceClient(BasicHttpsBinding, new EndpointAddress(_config.Endpoint));
        //    var client = new InventoryServiceClient(BasicHttpsBinding, new EndpointAddress(_config.InventoryEndpoint));

        //    var sellable = await productClient.getProductSellableAsync(new GetProductSellableRequest()
        //    {
        //        wsVersion = _config.WsVersion,
        //        id = _config.Id,
        //        password = _config.Password,
        //        isSellable = true,
        //        localizationCountry = _config.LocalizationCountry,
        //        localizationLanguage = _config.LocalizationLanguage
        //    });
        //    var sellableIds = sellable.GetProductSellableResponse.ProductSellableArray.Select(p => p.productId).ToList();
        //    foreach (var productId in sellableIds)
        //    {
        //        try
        //        {
        //            var product = await client.getInventoryLevelsAsync(new GetInventoryLevelsRequest()
        //            {
        //                wsVersion = wsVersion.Item200,
        //                id = _config.Id,
        //                password = _config.Password,
        //                productId = productId
        //            });

        //            if (product.GetInventoryLevelsResponse?.Inventory != null)
        //            {
        //                var partArray = new List<PartInventory>();
        //                if (product.GetInventoryLevelsResponse?.Inventory?.PartInventoryArray != null)
        //                {
        //                    foreach (var part in product.GetInventoryLevelsResponse.Inventory.PartInventoryArray)
        //                    {
        //                        var inventoryLocationArray = new List<InventoryLocation>();
        //                        if (part.InventoryLocationArray != null)
        //                        {
        //                            foreach (var location in part.InventoryLocationArray)
        //                            {
        //                                var futureAvailabilityArray = new List<FutureAvailability>();
        //                                if (location.FutureAvailabilityArray != null)
        //                                {
        //                                    foreach (var availability in location.FutureAvailabilityArray)
        //                                    {
        //                                        Enum.TryParse(availability.Quantity.uom.ToString(), out QuantityUom uom);
        //                                        var futureAvailability = new FutureAvailability
        //                                        {
        //                                            Quantity = new PromoStandards.REST.Core.Inventory.Quantity
        //                                            {
        //                                                uom = uom,
        //                                                value = availability.Quantity?.value ?? 0
        //                                            },
        //                                            availableOn = availability.availableOn
        //                                        };
        //                                        futureAvailabilityArray.Add(futureAvailability);
        //                                    }
        //                                }
        //                                Enum.TryParse(location.country.ToString(), out InventoryLocationCountry country);
        //                                Enum.TryParse(location.inventoryLocationQuantity.Quantity.uom.ToString(), out QuantityUom locationUom);
        //                                var inventoryLocation = new InventoryLocation
        //                                {
        //                                    inventoryLocationId = location.inventoryLocationId,
        //                                    inventoryLocationName = location.inventoryLocationName,
        //                                    postalCode = location.postalCode,
        //                                    country = country,
        //                                    inventoryLocationQuantity = new PromoStandards.REST.Core.Inventory.Quantity()
        //                                    {
        //                                        uom = locationUom,
        //                                        value = location.inventoryLocationQuantity.Quantity.value
        //                                    },
        //                                    FutureAvailabilityArray = futureAvailabilityArray.ToArray()
        //                                };
        //                                inventoryLocationArray.Add(inventoryLocation);
        //                            }
        //                        }
        //                        Enum.TryParse(part.quantityAvailable.Quantity.uom.ToString(), out QuantityUom partUom);
        //                        Enum.TryParse(part.labelSize.ToString(), out labelSize labelSize);
        //                        partArray.Add(new PartInventory
        //                        {
        //                            partId = part.partId,
        //                            mainPart = part.mainPart,
        //                            partColor = part.partColor,
        //                            labelSize = labelSize,
        //                            partDescription = part.partDescription,
        //                            quantityAvailable = new PromoStandards.REST.Core.Inventory.Quantity()
        //                            {
        //                                uom = partUom,
        //                                value = part.quantityAvailable.Quantity.value
        //                            },
        //                            manufacturedItem = part.manufacturedItem,
        //                            buyToOrder = part.buyToOrder,
        //                            replenishmentLeadTime = part.replenishmentLeadTime,
        //                            attributeSelection = part.attributeSelection,
        //                            InventoryLocationArray = inventoryLocationArray.ToArray(),
        //                            lastModified = part.lastModified
        //                        });
        //                    }
        //                }
        //                var extendedProduct = new InventoryExtended()
        //                {
        //                    Inventory = new Core.Inventory.Inventory
        //                    {
        //                        productId = product.GetInventoryLevelsResponse.Inventory.productId,
        //                        PartInventoryArray = partArray.ToArray()
        //                    }
        //                };
        //                await _inventoryService.InsertUpdate(extendedProduct);
        //            }
        //        }
        //        catch (Exception e)
        //        {
        //            Console.WriteLine(e);
        //        }
        //    }
        //}

    }
}