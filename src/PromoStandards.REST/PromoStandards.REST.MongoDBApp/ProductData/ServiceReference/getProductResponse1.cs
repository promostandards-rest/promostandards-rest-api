namespace PromoStandards.REST.MongoDBApp.ProductData.ServiceReference;

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
public partial class getProductResponse1
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.promostandards.org/WSDL/ProductDataService/2.0.0/", Order=0)]
    public GetProductResponse GetProductResponse;
    
    public getProductResponse1()
    {
    }
    
    public getProductResponse1(GetProductResponse GetProductResponse)
    {
        this.GetProductResponse = GetProductResponse;
    }
}