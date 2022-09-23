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
            var inventory = await GetInventory(request.productId);
            if (inventory == null) return null;

            IEnumerable<PartInventoryArrayPartInventory> results = inventory.PartInventoryArray;
            if (request.Filter != null)
            {
                if (request.Filter.partIdArray != null)
                {
                   results = results.Where(x => request.Filter.partIdArray.Contains(x.partId));
                }
                if (request.Filter.PartColorArray != null)
                {
                   results= results.Where(x => request.Filter.PartColorArray.Contains(x.partColor));
                }
                if (request.Filter.LabelSizeArray != null)
                {
                   results = results.Where(x => request.Filter.LabelSizeArray.Contains(x.labelSize));
                }
            }
            if (inventory.PartInventoryArray != null)
            {
                inventory.PartInventoryArray = results.ToArray();
            }
            else
            {
                return null;
            }

            return inventory;
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

        


    }
}