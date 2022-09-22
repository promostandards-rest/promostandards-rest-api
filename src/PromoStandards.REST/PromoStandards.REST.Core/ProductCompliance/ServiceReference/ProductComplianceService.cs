[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
[System.ServiceModel.ServiceContractAttribute(Namespace="http://www.promostandards.org/WSDL/ProductComplianceService/1.0.0/", ConfigurationName="ProductComplianceService")]
public interface ProductComplianceService
{
    
    [System.ServiceModel.OperationContractAttribute(Action="getProductsWithRegulations", ReplyAction="*")]
    [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
    System.Threading.Tasks.Task<getProductsWithRegulationsResponse1> getProductsWithRegulationsAsync(getProductsWithRegulationsRequest1 request);
    
    [System.ServiceModel.OperationContractAttribute(Action="getCompliance", ReplyAction="*")]
    [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
    System.Threading.Tasks.Task<getComplianceResponse1> getComplianceAsync(getComplianceRequest1 request);
}