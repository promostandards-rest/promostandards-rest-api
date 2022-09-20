using System;
using System.IO;

namespace PromoStandards.Org.API.Models
{
    public class MockDataContext
    {
        public string ErrorMessage { get; set; }
        public GetFilterValuesResponse GetGetFilterValuesResponse(string filePath)
        {
            try
            {
                var serializer = new Newtonsoft.Json.JsonSerializer();
                var streamReader = File.OpenText(filePath);
                var reader = new Newtonsoft.Json.JsonTextReader(streamReader);
                var results = serializer.Deserialize<GetFilterValuesResponse>(reader);

                reader.Close();
                streamReader.Close();

                return results;
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
                return null;
            }
        }

        public GetInventoryLevelsResponse GetGetInventoryLevelsResponse(string filePath)
        {
            try
            {
                var serializer = new Newtonsoft.Json.JsonSerializer();
                var streamReader = File.OpenText(filePath);
                var reader = new Newtonsoft.Json.JsonTextReader(streamReader);
                var results = serializer.Deserialize<GetInventoryLevelsResponse>(reader);

                reader.Close();
                streamReader.Close();

                return results;
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
                return null;
            }
        }
    }
}
