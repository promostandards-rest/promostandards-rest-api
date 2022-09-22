using System.Linq;
using System.Text.Json;
using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;
using PromoStandards.REST.Abstraction;
using PromoStandards.REST.Core.Inventory;
using PromoStandards.REST.Core.ProductData.Models;

namespace PromoStandards.REST.MongoDB.Inventory
{
    public class MongoDBInventoryService : IInventoryService
    {
        private readonly IMongoClient _client;
        private readonly MongoDBInventoryServiceConfiguration _config;

        public MongoDBInventoryService(IOptions<MongoDBInventoryServiceConfiguration> config, IMongoClient client)
        {
            _client = client;
            _config = config.Value;
        }

        public async Task<CollectionResponse<PartInventory>> GetInventoryLevels(String productId, String[]? parts, String[]? colors, String[]? sizes)
        {
            var inventory = await GetInventory(productId);
            if (inventory == null || inventory.PartInventoryArray == null) return null;

            IEnumerable<PartInventory> results = inventory.PartInventoryArray;
            if (parts != null)
            {
                results = results.Where(x => parts.Contains(x.partId));
            }
            if (colors != null)
            {
                results = results.Where(x => colors.Contains(x.partColor));
            }
            if (sizes != null)
            {
                results = results.Where(x => sizes.Contains(x.labelSize.ToString()));
            }
            
            return new CollectionResponse<PartInventory>(results.ToList());
        }

        private async Task<Core.Inventory.Inventory?> GetInventory(string prodcutId)
        {
            var collection = GetCollection(_config.DatabaseName, _config.InventoryCollectionName);
            var filters = new ExpressionFilterDefinition<InventoryExtended>(x => x.MyProductId == prodcutId);
            var results = await collection.FindAsync(filters, new FindOptions<InventoryExtended>());
            var entity = results.FirstOrDefault();
            if (entity == null)
            {
                return null;
            }
            else
            {
                return entity.Value.Inventory;
            }
        }

        public virtual IMongoCollection<InventoryExtended> GetCollection(string databaseName, string collectionName)
        {
            return _client.GetDatabase(databaseName).GetCollection<InventoryExtended>(collectionName);
        }

  
        //public async Task<List<InventoryExtended>> GetAll()
        //{
        //    var collection = GetCollection(_config.DatabaseName, _config.InventoryCollectionName);
        //    var result = await collection.FindAsync(Builders<InventoryExtended>.Filter.Empty);
        //    return await result.ToListAsync();
        //}

        public GetFilterValuesResponse GetFilterValues(GetFilterValuesRequest request)
        {
            throw new NotImplementedException();
        }


    }
}