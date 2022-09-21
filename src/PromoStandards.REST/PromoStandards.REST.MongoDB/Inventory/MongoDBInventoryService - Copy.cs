using System.Text.Json;
using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;
using PromoStandards.REST.Abstraction;
using PromoStandards.REST.Core.Inventory;

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

        public async Task<Core.Inventory.Inventory?> GetInventoryLevels(GetInventoryLevelsRequest request)
        {
            var inventory = await GetInventory(request.id);
            if (inventory == null) return inventory;

            var filters = Builders<Core.Inventory.PartInventory>.Filter.Empty;
            if (request.Filter != null)
            {
                if (request.Filter.partIdArray != null)
                {
                    filters &= new ExpressionFilterDefinition<Core.Inventory.PartInventory>(x => request.Filter.partIdArray.Contains(x.partId));
                }
                if (request.Filter.PartColorArray != null)
                {
                    filters &= new ExpressionFilterDefinition<Core.Inventory.PartInventory>(x => request.Filter.PartColorArray.Contains(x.partColor));
                }
                if (request.Filter.partIdArray != null)
                {
                    filters &= new ExpressionFilterDefinition<Core.Inventory.PartInventory>(x => request.Filter.LabelSizeArray.Contains(x.labelSize));
                }
            }

            var results = inventory.PartInventoryArray.FindAsync(filters, new FindOptions<Core.Inventory.PartInventory>);
            inventory.PartInventoryArray = results;

            return results;
        }

        private async Task<Core.Inventory.Inventory?> GetInventory(string id)
        {
            var collection = GetCollection(_config.DatabaseName, _config.InventoryCollectionName);
            var filters = new ExpressionFilterDefinition<InventoryExtended>(p => p.productId == id);
            var result = await collection.FindAsync(filters, new FindOptions<InventoryExtended>()
            {
                Skip = 0,
                Limit = 1
            });
            var inventory = await result.FirstOrDefaultAsync();
            return JsonSerializer.Deserialize<Core.Inventory.Inventory>(JsonSerializer.Serialize(inventory));
        }

        public virtual IMongoCollection<InventoryExtended> GetCollection(string databaseName, string collectionName)
        {
            return _client.GetDatabase(databaseName).GetCollection<InventoryExtended>(collectionName);
        }

        public async Task InsertUpdateProduct(InventoryExtended inventory)
        {
            var collection = GetCollection(_config.DatabaseName, _config.InventoryCollectionName);
            var filter = new ExpressionFilterDefinition<InventoryExtended>(p => p.productId == inventory.productId);
            var existingFind = await collection.FindAsync(filter);
            var existing = await existingFind.FirstOrDefaultAsync();
            if (existing == null)
            {
                await collection.InsertOneAsync(inventory);
            }
            else
            {
                inventory.Id = existing.Id;
                await collection.ReplaceOneAsync(filter, inventory);
            }
        }

        public async Task<List<InventoryExtended>> GetAll()
        {
            var collection = GetCollection(_config.DatabaseName, _config.InventoryCollectionName);
            var result = await collection.FindAsync(Builders<InventoryExtended>.Filter.Empty);
            return await result.ToListAsync();
        }

        public GetFilterValuesResponse GetFilterValues(GetFilterValuesRequest request)
        {
            throw new NotImplementedException();
        }


    }
}