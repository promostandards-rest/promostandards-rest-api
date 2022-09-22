namespace PromoStandards.REST.Core.ProductPricingConfiguration.ServiceReference;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.promostandards.org/WSDL/PricingAndConfiguration/1.0.0/")]
public partial class AvailableCharge
{
    
    private int chargeIdField;
    
    private string chargeNameField;
    
    private string chargeDescriptionField;
    
    private chargeType chargeTypeField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.promostandards.org/WSDL/PricingAndConfiguration/1.0.0/SharedObjects/", Order=0)]
    public int chargeId
    {
        get
        {
            return this.chargeIdField;
        }
        set
        {
            this.chargeIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.promostandards.org/WSDL/PricingAndConfiguration/1.0.0/SharedObjects/", DataType="token", Order=1)]
    public string chargeName
    {
        get
        {
            return this.chargeNameField;
        }
        set
        {
            this.chargeNameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.promostandards.org/WSDL/PricingAndConfiguration/1.0.0/SharedObjects/", DataType="token", Order=2)]
    public string chargeDescription
    {
        get
        {
            return this.chargeDescriptionField;
        }
        set
        {
            this.chargeDescriptionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.promostandards.org/WSDL/PricingAndConfiguration/1.0.0/SharedObjects/", Order=3)]
    public chargeType chargeType
    {
        get
        {
            return this.chargeTypeField;
        }
        set
        {
            this.chargeTypeField = value;
        }
    }
}