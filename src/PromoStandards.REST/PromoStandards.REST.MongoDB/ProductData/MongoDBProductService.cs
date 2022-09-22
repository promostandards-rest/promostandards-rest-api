﻿using System.Text.Json;
using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;
using PromoStandards.REST.Abstraction;
using PromoStandards.REST.Core.ProductData.Models;
using PromoStandards.REST.Core.ProductData.ServiceReference;

namespace PromoStandards.REST.MongoDB.ProductData
{
    public class MongoDBProductService : IProductDataService
    {
        private readonly IMongoClient _client;
        private readonly MongoDBProductServiceConfiguration _config;

        public MongoDBProductService(IOptions<MongoDBProductServiceConfiguration> config, IMongoClient client)
        {
            _client = client;
            _config = config.Value;
        }


        public async Task<CollectionResponse<Product>> GetProducts(bool? isSellable = null, bool? isCloseout = null, DateTime? modifiedDate = null, int page = 0,
            int pageSize = 20, Dictionary<string, string>? additionalParameters = null)
        {
            var collection = GetCollection(_config.DatabaseName, _config.ProductCollectionName);
            var filters = Builders<ProductExtended>.Filter.Empty;
            if (isCloseout != null)
                filters &= new ExpressionFilterDefinition<ProductExtended>(p => p.isCloseout == isCloseout);
            if (modifiedDate != null)
                filters &= new ExpressionFilterDefinition<ProductExtended>(p => p.lastChangeDate > modifiedDate);

            if (additionalParameters != null)
                foreach (var additionalParameter in additionalParameters)
                    filters &= new BsonDocumentFilterDefinition<ProductExtended>(new BsonDocument(additionalParameter.Key, additionalParameter.Value));

            var skip = page * pageSize;
            var result = await collection.FindAsync(filters, new FindOptions<ProductExtended>()
            {
                Skip = skip,
                Limit = pageSize
            });
            var list = await result.ToListAsync();

            var countResult = await collection.CountDocumentsAsync(filters);

            var products = new List<Product>();
            foreach (var item in list)
            {
                products.Add(JsonSerializer.Deserialize<Product>(JsonSerializer.Serialize(item)));
            }
            return new CollectionResponse<Product>()
            {
                Data = products,
                Total = countResult,
                page = page,
                pageSize = pageSize
            };
        }

        public virtual IMongoCollection<ProductExtended> GetCollection(string databaseName, string collectionName)
        {
            return _client.GetDatabase(databaseName).GetCollection<ProductExtended>(collectionName);
        }

        public async Task InsertUpdateProduct(ProductExtended product)
        {
            var collection = GetCollection(_config.DatabaseName, _config.ProductCollectionName);
            var filter = new ExpressionFilterDefinition<ProductExtended>(p => p.productId == product.productId);
            var existingFind = await collection.FindAsync(filter);
            var existing = await existingFind.FirstOrDefaultAsync();
            if (existing == null)
            {
                await collection.InsertOneAsync(product);
            }
            else
            {
                product.Id = existing.Id;
                await collection.ReplaceOneAsync(filter, product);
            }
        }

        public async Task<getProductResponse1> getProductAsync(getProductRequest1 request)
        {
            var collection = GetCollection(_config.DatabaseName, _config.ProductCollectionName);
            var filters = new ExpressionFilterDefinition<ProductExtended>(p => p.productId == request.GetProductRequest.productId);
            var result = await collection.FindAsync(filters, new FindOptions<ProductExtended>()
            {
                Skip = 0,
                Limit = 1
            });
            var product = await result.FirstOrDefaultAsync();
            if (product != null)
                return new getProductResponse1(new GetProductResponse()
                {
                    Product = JsonSerializer.Deserialize<Product>(JsonSerializer.Serialize(product)),
                });
            return new getProductResponse1(new GetProductResponse()
            {
                ServiceMessageArray = new ServiceMessage[]
                {
                    new ServiceMessage()
                    {
                        code = 404,
                        description = "Product not found",
                        severity = ServiceMessageSeverity.Warning
                    }
                }
            });
        }

        public async Task<getProductDateModifiedResponse1> getProductDateModifiedAsync(getProductDateModifiedRequest1 request)
        {
            throw new NotImplementedException();
        }

        public async Task<getProductCloseOutResponse1> getProductCloseOutAsync(getProductCloseOutRequest1 request)
        {
            throw new NotImplementedException();
        }

        public async Task<getProductSellableResponse1> getProductSellableAsync(getProductSellableRequest1 request)
        {
            throw new NotImplementedException();
        }
    }
}