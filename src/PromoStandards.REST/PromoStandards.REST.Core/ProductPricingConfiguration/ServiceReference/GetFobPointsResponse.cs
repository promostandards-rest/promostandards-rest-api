namespace PromoStandards.REST.Core.ProductPricingConfiguration.ServiceReference;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.promostandards.org/WSDL/PricingAndConfiguration/1.0.0/")]
public partial class GetFobPointsResponse
{
    
    private FobPoint[] fobPointArrayField;
    
    private ErrorMessage errorMessageField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Order=0)]
    [System.Xml.Serialization.XmlArrayItemAttribute("FobPoint", IsNullable=false)]
    public FobPoint[] FobPointArray
    {
        get
        {
            return this.fobPointArrayField;
        }
        set
        {
            this.fobPointArrayField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.promostandards.org/WSDL/PricingAndConfiguration/1.0.0/SharedObjects/", Order=1)]
    public ErrorMessage ErrorMessage
    {
        get
        {
            return this.errorMessageField;
        }
        set
        {
            this.errorMessageField = value;
        }
    }
}