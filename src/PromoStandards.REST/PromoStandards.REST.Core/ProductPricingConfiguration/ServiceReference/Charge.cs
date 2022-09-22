namespace PromoStandards.REST.Core.ProductPricingConfiguration.ServiceReference;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.promostandards.org/WSDL/PricingAndConfiguration/1.0.0/")]
public partial class Charge
{
    
    private int chargeIdField;
    
    private string chargeNameField;
    
    private string chargeDescriptionField;
    
    private chargeType chargeTypeField;
    
    private ChargePrice[] chargePriceArrayField;
    
    private System.Nullable<bool> chargesAppliesLTMField;
    
    private System.Nullable<int> chargesPerLocationField;
    
    private System.Nullable<int> chargesPerColorField;
    
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
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Order=4)]
    [System.Xml.Serialization.XmlArrayItemAttribute("ChargePrice", IsNullable=false)]
    public ChargePrice[] ChargePriceArray
    {
        get
        {
            return this.chargePriceArrayField;
        }
        set
        {
            this.chargePriceArrayField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=5)]
    public System.Nullable<bool> chargesAppliesLTM
    {
        get
        {
            return this.chargesAppliesLTMField;
        }
        set
        {
            this.chargesAppliesLTMField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=6)]
    public System.Nullable<int> chargesPerLocation
    {
        get
        {
            return this.chargesPerLocationField;
        }
        set
        {
            this.chargesPerLocationField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=7)]
    public System.Nullable<int> chargesPerColor
    {
        get
        {
            return this.chargesPerColorField;
        }
        set
        {
            this.chargesPerColorField = value;
        }
    }
}