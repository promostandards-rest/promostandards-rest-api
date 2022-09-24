using System.Text.Json;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;
using PromoStandards.REST.Abstraction;
using PromoStandards.REST.Core.MediaContent.ServiceReference;
using PromoStandards.REST.Core.ProductData.Models;
using PromoStandards.REST.Core.ProductData.ServiceReference;

namespace PromoStandards.REST.MongoDB.MediaContent
{
    public class MongoDBMediaContentService : IMediaContentService
    {
        private readonly IMongoClient _client;
        private readonly MongoDBMediaContentServiceConfiguration _config;

        public MongoDBMediaContentService(IOptions<MongoDBMediaContentServiceConfiguration> config, IMongoClient client)
        {
            _client = client;
            _config = config.Value;
        }

        public virtual IMongoCollection<MediaContentExtended> GetCollection(string databaseName, string collectionName)
        {
            return _client.GetDatabase(databaseName).GetCollection<MediaContentExtended>(collectionName);
        }

        public async Task InsertUpdate(MediaContentExtended product)
        {
            var collection = GetCollection(_config.DatabaseName, _config.MediaCollectionName);
            var filter = new ExpressionFilterDefinition<MediaContentExtended>(p => p.ProductId == product.ProductId);
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

        public async Task<CollectionResponse<Core.MediaContent.ServiceReference.MediaContent>> GetProductMedia(string productId, mediaTypeType mediaType, string? partId, string? cultureName, int? classType, DateTime? lastModifiedDate)
        {
            var collection = GetCollection(_config.DatabaseName, _config.MediaCollectionName);
            var filters = new ExpressionFilterDefinition<MediaContentExtended>(p => p.ProductId == productId && p.MediaType == mediaType);
            var result = await collection.FindAsync(filters, new FindOptions<MediaContentExtended>()
            {
                Skip = 0,
                Limit = 1
            });
            var product = await result.FirstOrDefaultAsync();
            var response = new CollectionResponse<Core.MediaContent.ServiceReference.MediaContent>(product.MediaContent);
            return response;
        }
    }
}