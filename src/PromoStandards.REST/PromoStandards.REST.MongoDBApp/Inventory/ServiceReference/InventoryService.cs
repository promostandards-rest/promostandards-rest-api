namespace PromoStandards.REST.MongoDBApp.Inventory.ServiceReference;

[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
[System.ServiceModel.ServiceContractAttribute(Namespace="http://www.promostandards.org/WSDL/Inventory/2.0.0/", ConfigurationName="InventoryService")]
public interface InventoryService
{
    
    [System.ServiceModel.OperationContractAttribute(Action="getFilterValues", ReplyAction="*")]
    [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
    System.Threading.Tasks.Task<getFilterValuesResponse1> getFilterValuesAsync(getFilterValuesRequest1 request);
    
    [System.ServiceModel.OperationContractAttribute(Action="getInventoryLevels", ReplyAction="*")]
    [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
    System.Threading.Tasks.Task<getInventoryLevelsResponse1> getInventoryLevelsAsync(getInventoryLevelsRequest1 request);
}