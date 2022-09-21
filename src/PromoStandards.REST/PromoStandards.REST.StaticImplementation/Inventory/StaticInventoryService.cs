using PromoStandards.REST.Abstraction;
using PromoStandards.REST.Core.Inventory;

namespace PromoStandards.REST.StaticImplementation.Inventory;

public class StaticInventoryService : IInventoryService
{
    public GetFilterValuesResponse GetFilterValues(GetFilterValuesRequest request)
    {
        const string fileName = "GetInventoryFilterValuesResponse.json";
        try
        {
            var dir = System.AppDomain.CurrentDomain.BaseDirectory;
            var filePath = Path.Combine(dir,"StaticData", fileName);

            var serializer = new Newtonsoft.Json.JsonSerializer();
            var streamReader = File.OpenText(filePath);
            var reader = new Newtonsoft.Json.JsonTextReader(streamReader);
            var response = serializer.Deserialize<GetFilterValuesResponse>(reader);

            reader.Close();
            streamReader.Close();

            return response;
        }
        catch (Exception ex)
        {
            // Log  ex

            var sm = new PromoStandards.REST.Core.Inventory.ServiceMessage()
            {
                code = 999,
                description = "General Error – Contact the System Service Provider Details: " + request.productId,
                severity = PromoStandards.REST.Core.Inventory.ServiceMessageSeverity.Error
            };
            return new GetFilterValuesResponse() { ServiceMessageArray = new PromoStandards.REST.Core.Inventory.ServiceMessage[] { sm } };
        }
    }

    //public GetInventoryLevelsResponse GetInventoryLevels(GetInventoryLevelsRequest request)
    //{
    //    const string fileName = "GetInventoryFilterValuesResponse.json";
    //    try
    //    {
    //        var dir = System.AppDomain.CurrentDomain.BaseDirectory;
    //        var filePath = Path.Combine(dir, "StaticData", fileName);

    //        var serializer = new Newtonsoft.Json.JsonSerializer();
    //        var streamReader = File.OpenText(filePath);
    //        var reader = new Newtonsoft.Json.JsonTextReader(streamReader);
    //        var response = serializer.Deserialize<GetInventoryLevelsResponse>(reader);

    //        reader.Close();
    //        streamReader.Close();

    //        return response;
    //    }
    //    catch (Exception ex)
    //    {
    //        var sm = new PromoStandards.REST.Core.Inventory.ServiceMessage()
    //        {
    //            code = 999,
    //            description = "General Error – Contact the System Service Provider Details: " + request.productId,
    //            severity = PromoStandards.REST.Core.Inventory.ServiceMessageSeverity.Error
    //        };
    //        return new GetInventoryLevelsResponse() { ServiceMessageArray = new PromoStandards.REST.Core.Inventory.ServiceMessage[] { sm } };
    //    }
    //}

    Task<Core.Inventory.Inventory?> IInventoryService.GetInventoryLevels(GetInventoryLevelsRequest request)
    {
        throw new NotImplementedException();
    }
}