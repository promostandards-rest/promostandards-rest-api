namespace PromoStandards.REST.Core.ProductPricingConfiguration.ServiceReference;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.promostandards.org/WSDL/PricingAndConfiguration/1.0.0/")]
public partial class Configuration
{
    
    private Part[] partArrayField;
    
    private Location[] locationArrayField;
    
    private string productIdField;
    
    private CurrencyCodeType currencyField;
    
    private FobArrayFob[] fobArrayField;
    
    private priceType priceTypeField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Order=0)]
    [System.Xml.Serialization.XmlArrayItemAttribute("Part", IsNullable=false)]
    public Part[] PartArray
    {
        get
        {
            return this.partArrayField;
        }
        set
        {
            this.partArrayField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Order=1)]
    [System.Xml.Serialization.XmlArrayItemAttribute("Location", IsNullable=false)]
    public Location[] LocationArray
    {
        get
        {
            return this.locationArrayField;
        }
        set
        {
            this.locationArrayField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.promostandards.org/WSDL/PricingAndConfiguration/1.0.0/SharedObjects/", DataType="token", Order=2)]
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
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.promostandards.org/WSDL/PricingAndConfiguration/1.0.0/SharedObjects/", Order=3)]
    public CurrencyCodeType currency
    {
        get
        {
            return this.currencyField;
        }
        set
        {
            this.currencyField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Namespace="http://www.promostandards.org/WSDL/PricingAndConfiguration/1.0.0/SharedObjects/", Order=4)]
    [System.Xml.Serialization.XmlArrayItemAttribute("Fob", IsNullable=false)]
    public FobArrayFob[] FobArray
    {
        get
        {
            return this.fobArrayField;
        }
        set
        {
            this.fobArrayField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.promostandards.org/WSDL/PricingAndConfiguration/1.0.0/SharedObjects/", Order=5)]
    public priceType priceType
    {
        get
        {
            return this.priceTypeField;
        }
        set
        {
            this.priceTypeField = value;
        }
    }
}