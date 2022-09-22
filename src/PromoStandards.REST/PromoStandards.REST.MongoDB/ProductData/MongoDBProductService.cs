using System.Text.Json;
using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;
using PromoStandards.REST.Abstraction;
using PromoStandards.REST.Core.ProductData.Models;
using PromoStandards.REST.Core.ProductData.ServiceReference;
using Product = PromoStandards.REST.Core.ProductPricingConfiguration.ServiceReference.Product;

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

        public async Task<CollectionResponse<Product>> GetProducts(bool? isSellable = null, bool? isCloseout = null, DateTime? modifiedDate = null, int? page = 0, int? pageSize = 20, Dictionary<string, string>? additionalParameters = null)
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
                page = page ?? 0,
                pageSize = pageSize ?? 20
            };
        }

        public async Task<Product?> GetProduct(string id)
        {
            var collection = GetCollection(_config.DatabaseName, _config.ProductCollectionName);
            var filters = new ExpressionFilterDefinition<ProductExtended>(p => p.productId == id);
            var result = await collection.FindAsync(filters, new FindOptions<ProductExtended>()
            {
                Skip = 0,
                Limit = 1
            });
            var product = await result.FirstOrDefaultAsync();
            return JsonSerializer.Deserialize<Product>(JsonSerializer.Serialize(product));
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

        public async Task<List<ProductExtended>> GetAll()
        {
            var collection = GetCollection(_config.DatabaseName, _config.ProductCollectionName);
            var result = await collection.FindAsync(Builders<ProductExtended>.Filter.Empty);
            return await result.ToListAsync();
        }
    }
}