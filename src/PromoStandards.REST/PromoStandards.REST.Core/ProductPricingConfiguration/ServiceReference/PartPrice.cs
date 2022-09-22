namespace PromoStandards.REST.Core.ProductPricingConfiguration.ServiceReference;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.promostandards.org/WSDL/PricingAndConfiguration/1.0.0/")]
public partial class PartPrice
{
    
    private int minQuantityField;
    
    private decimal priceField;
    
    private string discountCodeField;
    
    private PartPricePriceUom priceUomField;
    
    private System.Nullable<System.DateTime> priceEffectiveDateField;
    
    private System.Nullable<System.DateTime> priceExpiryDateField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public int minQuantity
    {
        get
        {
            return this.minQuantityField;
        }
        set
        {
            this.minQuantityField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public decimal price
    {
        get
        {
            return this.priceField;
        }
        set
        {
            this.priceField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public string discountCode
    {
        get
        {
            return this.discountCodeField;
        }
        set
        {
            this.discountCodeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    public PartPricePriceUom priceUom
    {
        get
        {
            return this.priceUomField;
        }
        set
        {
            this.priceUomField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=4)]
    public System.Nullable<System.DateTime> priceEffectiveDate
    {
        get
        {
            return this.priceEffectiveDateField;
        }
        set
        {
            this.priceEffectiveDateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=5)]
    public System.Nullable<System.DateTime> priceExpiryDate
    {
        get
        {
            return this.priceExpiryDateField;
        }
        set
        {
            this.priceExpiryDateField = value;
        }
    }
}