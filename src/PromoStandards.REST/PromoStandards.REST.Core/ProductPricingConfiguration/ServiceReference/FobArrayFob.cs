namespace PromoStandards.REST.Core.ProductPricingConfiguration.ServiceReference;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.promostandards.org/WSDL/PricingAndConfiguration/1.0.0/SharedObjects/")]
public partial class FobArrayFob
{
    
    private string fobIdField;
    
    private string fobPostalCodeField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=0)]
    public string fobId
    {
        get
        {
            return this.fobIdField;
        }
        set
        {
            this.fobIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public string fobPostalCode
    {
        get
        {
            return this.fobPostalCodeField;
        }
        set
        {
            this.fobPostalCodeField = value;
        }
    }
}