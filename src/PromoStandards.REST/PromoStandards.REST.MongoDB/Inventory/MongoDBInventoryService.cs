using System.Linq;
using System.Text.Json;
using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;
using PromoStandards.REST.Abstraction;
using PromoStandards.REST.Core.Inventory;
using PromoStandards.REST.Core.ProductData.Models;
using PromoStandards.REST.MongoDB.ProductData;

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

        public async Task<CollectionResponse<PartInventory>> GetInventoryLevels(GetInventoryLevelsRequest request)
        {
            var inventory = await GetInventory(request.productId);
            if (inventory == null || inventory.PartInventoryArray == null) return null;

            IEnumerable<PartInventory> results = inventory.PartInventoryArray;
            if (request.Filter?.partIdArray != null && request.Filter.partIdArray.Length > 0)
            {
                results = results.Where(x => request.Filter.partIdArray.Contains(x.partId));
            }
            if (request.Filter?.PartColorArray != null && request.Filter.PartColorArray.Length > 0)
            {
                results = results.Where(x => request.Filter.PartColorArray.Contains(x.partColor));
            }
            if (request.Filter?.LabelSizeArray != null && request.Filter.LabelSizeArray.Length > 0)
            {
                results = results.Where(x => request.Filter.LabelSizeArray.Contains(x.labelSize.ToString()));
            }
            
            return new CollectionResponse<PartInventory>(results.ToList());
        }

        private async Task<Core.Inventory.Inventory?> GetInventory(string prodcutId)
        {
            try
            {
                var collection = GetCollection(_config.DatabaseName, _config.InventoryCollectionName);
                var filters = new ExpressionFilterDefinition<InventoryExtended>(x => x.productId == prodcutId);
                var results = await collection.FindAsync(filters, new FindOptions<InventoryExtended>());
                var entity = results.FirstOrDefault();
                if (entity == null)
                {
                    return null;
                }
                else
                {
                    return JsonSerializer.Deserialize<Core.Inventory.Inventory>(JsonSerializer.Serialize(entity));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public virtual IMongoCollection<InventoryExtended> GetCollection(string databaseName, string collectionName)
        {
            return _client.GetDatabase(databaseName).GetCollection<InventoryExtended>(collectionName);
        }

        public async Task InsertUpdate(InventoryExtended inventory)
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

        public GetFilterValuesResponse GetFilterValues(GetFilterValuesRequest request)
        {
            throw new NotImplementedException();
        }
    }
}