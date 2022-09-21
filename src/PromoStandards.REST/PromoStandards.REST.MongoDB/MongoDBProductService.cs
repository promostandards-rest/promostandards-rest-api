using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;
using PromoStandards.REST.Core.Inventory;
using PromoStandards.REST.Core.ProductData.Models;

namespace PromoStandards.REST.MongoDB
{
    public class MongoDBProductService
    {
        private readonly IMongoClient _client;
        private readonly MongoDBProductServiceConfiguration _config;

        public MongoDBProductService(IOptions<MongoDBProductServiceConfiguration> config, IMongoClient client, IClientSessionHandle clientSessionHandle, IHttpContextAccessor httpContextAccessor)
        {
            _client = client;
            _config = config.Value;
        }

        public async Task<GetProductsResponse> GetProducts(bool? isSellable = null, bool? isCloseout = null, DateTime? modifiedDate = null, int page = 0, int pageSize = 20, Dictionary<string, string>? additionalParameters = null)
        {
            var collection = GetCollection(_config.DatabaseName, _config.CollectionName);
            var filters = Builders<Product>.Filter.Empty;
            if (isCloseout != null)
                filters &= new ExpressionFilterDefinition<Product>(p => p.isCloseout == isCloseout);
            if (isSellable != null)
                filters &= new ExpressionFilterDefinition<Product>(p => p.isSellable == isSellable);
            if (modifiedDate != null)
                filters &= new ExpressionFilterDefinition<Product>(p => p.lastChangeDate > modifiedDate);

            if (additionalParameters != null)
                foreach (var additionalParameter in additionalParameters)
                    filters &= new BsonDocumentFilterDefinition<Product>(new BsonDocument(additionalParameter.Key, additionalParameter.Value));

            var skip = page * pageSize;
            var result = await collection.FindAsync(filters, new FindOptions<Product>()
            {
                Skip = skip,
                Limit = pageSize
            });
            var list = await result.ToListAsync();

            var countResult = await collection.CountDocumentsAsync(filters);

            return new GetProductsResponse()
            {
                Products = list,
                Total = countResult
            };
        }

        public async Task<Product> GetProduct(string id)
        {
            var collection = GetCollection(_config.DatabaseName, _config.CollectionName);
            var filters = new ExpressionFilterDefinition<Product>(p => p.productId == id);
            var result = await collection.FindAsync(filters, new FindOptions<Product>()
            {
                Skip = 0,
                Limit = 1
            });
            return await result.FirstOrDefaultAsync();
        }

        public virtual IMongoCollection<Product> GetCollection(string databaseName, string collectionName)
        {
            return _client.GetDatabase(databaseName).GetCollection<Product>(collectionName);
        }
    }
}