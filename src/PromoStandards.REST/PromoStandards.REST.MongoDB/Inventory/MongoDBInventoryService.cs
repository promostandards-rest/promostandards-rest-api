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

        public async Task<CollectionResponse<PartInventory>> GetInventoryLevels(GetInventoryLevelsRequest request)
        {
            var inventory = await GetInventory(request.productId);
            if (inventory == null || inventory.PartInventoryArray == null) return null;

            IEnumerable<PartInventory> results = inventory.PartInventoryArray;
            if (request.Filter.partIdArray != null)
            {
                results = results.Where(x => request.Filter.partIdArray.Contains(x.partId));
            }
            if (request.Filter.PartColorArray != null)
            {
                results = results.Where(x => request.Filter.PartColorArray.Contains(x.partColor));
            }
            if (request.Filter.LabelSizeArray != null)
            {
                results = results.Where(x => request.Filter.LabelSizeArray.Contains(x.labelSize));
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

        public GetFilterValuesResponse GetFilterValues(GetFilterValuesRequest request)
        {
            throw new NotImplementedException();
        }
    }
}