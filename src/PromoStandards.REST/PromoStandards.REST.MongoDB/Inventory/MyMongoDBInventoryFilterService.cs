using System.Text.Json;
using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;
using PromoStandards.REST.Abstraction;
using PromoStandards.REST.Core.Inventory;

namespace PromoStandards.REST.MongoDB.Inventory
{
    public class MyMongoDBInventoryFilterService : IMyInventoryFilterService
    {
        private readonly IMongoClient _client;
        private readonly MyMongoDBInventoryServiceConfiguration _config;

        public MyMongoDBInventoryFilterService(IOptions<MyMongoDBInventoryServiceConfiguration> config, IMongoClient client)
        {
            _client = client;
            _config = config.Value;
        }

        public async Task<Core.Inventory.GetFilterValuesResponse?> GetFilterValues(wsVersion wsVersion, string prodcutId)
        {
            var collection = GetCollection(_config.DatabaseName, _config.InventoryFilterCollectionName);
            var filters = new ExpressionFilterDefinition<MyInventoryFilterExtended>(x => x.MyProductId == prodcutId);
            var results = await collection.FindAsync(filters, new FindOptions<MyInventoryFilterExtended>());
            
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

        
        public virtual IMongoCollection<MyInventoryFilterExtended> GetCollection(string databaseName, string collectionName)
        {
            return _client.GetDatabase(databaseName).GetCollection<MyInventoryFilterExtended>(collectionName);
        }

    }
}