namespace PromoStandards.REST.MongoDBApp.ProductData.ServiceReference;

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
public partial class getProductDateModifiedResponse1
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.promostandards.org/WSDL/ProductDataService/2.0.0/", Order=0)]
    public GetProductDateModifiedResponse GetProductDateModifiedResponse;
    
    public getProductDateModifiedResponse1()
    {
    }
    
    public getProductDateModifiedResponse1(GetProductDateModifiedResponse GetProductDateModifiedResponse)
    {
        this.GetProductDateModifiedResponse = GetProductDateModifiedResponse;
    }
}