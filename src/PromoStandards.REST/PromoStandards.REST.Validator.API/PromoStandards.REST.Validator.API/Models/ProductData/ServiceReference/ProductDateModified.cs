namespace PromoStandards.REST.Core.ProductData.ServiceReference;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.promostandards.org/WSDL/ProductDataService/2.0.0/")]
public class ProductDateModified
{
    
    private string productIdField;
    
    private string partIdField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.promostandards.org/WSDL/ProductDataService/2.0.0/SharedObjects/", DataType="token", Order=0)]
    public string productId
    {
        get
        {
            return this.productIdField;
        }
        set
        {
            this.productIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.promostandards.org/WSDL/ProductDataService/2.0.0/SharedObjects/", DataType="token", Order=1)]
    public string partId
    {
        get
        {
            return this.partIdField;
        }
        set
        {
            this.partIdField = value;
        }
    }
}