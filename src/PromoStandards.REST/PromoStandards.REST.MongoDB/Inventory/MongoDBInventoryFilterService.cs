using System.Text.Json;
using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;
using PromoStandards.REST.Abstraction;
using PromoStandards.REST.Core.Inventory;

namespace PromoStandards.REST.MongoDB.Inventory
{
    public class MongoDBInventoryFilterService : IInventoryFilterService
    {
        private readonly IMongoClient _client;
        private readonly MongoDBInventoryServiceConfiguration _config;

        public MongoDBInventoryFilterService(IOptions<MongoDBInventoryServiceConfiguration> config, IMongoClient client)
        {
            _client = client;
            _config = config.Value;
        }

        public async Task<Core.Inventory.GetFilterValuesResponse?> GetFilterValues(wsVersion wsVersion, string prodcutId)
        {
            var collection = GetCollection(_config.DatabaseName, _config.InventoryFilterCollectionName);
            var filters = new ExpressionFilterDefinition<InventoryFilterExtended>(x => x.MyProductId == prodcutId);
            var results = await collection.FindAsync(filters, new FindOptions<InventoryFilterExtended>());
            
            var entities = await results.ToListAsync();
            var entity = entities.FirstOrDefault();
            if (entity == null)
            {
                return null;
            }
            else
            {
                return entity.Value;
            }
        }

        
        public virtual IMongoCollection<InventoryFilterExtended> GetCollection(string databaseName, string collectionName)
        {
            return _client.GetDatabase(databaseName).GetCollection<InventoryFilterExtended>(collectionName);
        }

    }
}