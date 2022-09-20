/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.promostandards.org/WSDL/ProductDataService/2.0.0/")]
public partial class GetProductSellableResponse
{
    
    private GetProductSellableResponseProductSellable[] productSellableArrayField;
    
    private ServiceMessage[] serviceMessageArrayField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Order=0)]
    [System.Xml.Serialization.XmlArrayItemAttribute("ProductSellable", IsNullable=false)]
    public GetProductSellableResponseProductSellable[] ProductSellableArray
    {
        get
        {
            return this.productSellableArrayField;
        }
        set
        {
            this.productSellableArrayField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Namespace="http://www.promostandards.org/WSDL/ProductDataService/2.0.0/SharedObjects/", Order=1)]
    [System.Xml.Serialization.XmlArrayItemAttribute("ServiceMessage", IsNullable=false)]
    public ServiceMessage[] ServiceMessageArray
    {
        get
        {
            return this.serviceMessageArrayField;
        }
        set
        {
            this.serviceMessageArrayField = value;
        }
    }
}