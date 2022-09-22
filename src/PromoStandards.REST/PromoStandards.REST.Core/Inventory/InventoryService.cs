namespace PromoStandards.REST.Core.Inventory;

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(Namespace="http://www.promostandards.org/WSDL/Inventory/2.0.0/", ConfigurationName="InventoryService")]
public interface InventoryService
{
        
    // CODEGEN: Generating message contract since the operation getFilterValues is neither RPC nor document wrapped.
    [System.ServiceModel.OperationContractAttribute(Action="getFilterValues")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    getFilterValuesResponse1 getFilterValues(getFilterValuesRequest1 request);
        
    // CODEGEN: Generating message contract since the operation getInventoryLevels is neither RPC nor document wrapped.
    [System.ServiceModel.OperationContractAttribute(Action="getInventoryLevels")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    getInventoryLevelsResponse1 getInventoryLevels(getInventoryLevelsRequest1 request);
}