namespace PromoStandards.REST.Core.ProductPricingConfiguration.ServiceReference;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.promostandards.org/WSDL/PricingAndConfiguration/1.0.0/")]
public partial class ChargePrice
{
    
    private int xMinQtyField;
    
    private PartPricePriceUom xUomField;
    
    private int yMinQtyField;
    
    private decorationUom yUomField;
    
    private decimal priceField;
    
    private string discountCodeField;
    
    private decimal repeatPriceField;
    
    private string repeatDiscountCodeField;
    
    private System.Nullable<System.DateTime> priceEffectiveDateField;
    
    private System.Nullable<System.DateTime> priceExpiryDateField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public int xMinQty
    {
        get
        {
            return this.xMinQtyField;
        }
        set
        {
            this.xMinQtyField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public PartPricePriceUom xUom
    {
        get
        {
            return this.xUomField;
        }
        set
        {
            this.xUomField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public int yMinQty
    {
        get
        {
            return this.yMinQtyField;
        }
        set
        {
            this.yMinQtyField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    public decorationUom yUom
    {
        get
        {
            return this.yUomField;
        }
        set
        {
            this.yUomField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=4)]
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
    [System.Xml.Serialization.XmlElementAttribute(Order=5)]
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
    [System.Xml.Serialization.XmlElementAttribute(Order=6)]
    public decimal repeatPrice
    {
        get
        {
            return this.repeatPriceField;
        }
        set
        {
            this.repeatPriceField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=7)]
    public string repeatDiscountCode
    {
        get
        {
            return this.repeatDiscountCodeField;
        }
        set
        {
            this.repeatDiscountCodeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=8)]
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
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=9)]
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