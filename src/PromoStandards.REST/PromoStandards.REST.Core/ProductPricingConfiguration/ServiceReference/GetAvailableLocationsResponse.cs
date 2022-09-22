namespace PromoStandards.REST.Core.ProductPricingConfiguration.ServiceReference;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.promostandards.org/WSDL/PricingAndConfiguration/1.0.0/")]
public partial class GetAvailableLocationsResponse
{
    
    private AvailableLocation[] availableLocationArrayField;
    
    private ErrorMessage errorMessageField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Order=0)]
    [System.Xml.Serialization.XmlArrayItemAttribute("AvailableLocation", IsNullable=false)]
    public AvailableLocation[] AvailableLocationArray
    {
        get
        {
            return this.availableLocationArrayField;
        }
        set
        {
            this.availableLocationArrayField = value;
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