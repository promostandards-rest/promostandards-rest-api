namespace PromoStandards.REST.Core.ProductPricingConfiguration.ServiceReference;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.promostandards.org/WSDL/PricingAndConfiguration/1.0.0/")]
public partial class Part
{
    
    private string partIdField;
    
    private string partDescriptionField;
    
    private PartPrice[] partPriceArrayField;
    
    private int partGroupField;
    
    private int nextPartGroupField;
    
    private bool nextPartGroupFieldSpecified;
    
    private bool partGroupRequiredField;
    
    private string partGroupDescriptionField;
    
    private decimal ratioField;
    
    private System.Nullable<bool> defaultPartField;
    
    private PartLocationId[] locationIdArrayField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.promostandards.org/WSDL/PricingAndConfiguration/1.0.0/SharedObjects/", DataType="token", Order=0)]
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
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.promostandards.org/WSDL/PricingAndConfiguration/1.0.0/SharedObjects/", DataType="token", Order=1)]
    public string partDescription
    {
        get
        {
            return this.partDescriptionField;
        }
        set
        {
            this.partDescriptionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Order=2)]
    [System.Xml.Serialization.XmlArrayItemAttribute("PartPrice", IsNullable=false)]
    public PartPrice[] PartPriceArray
    {
        get
        {
            return this.partPriceArrayField;
        }
        set
        {
            this.partPriceArrayField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.promostandards.org/WSDL/PricingAndConfiguration/1.0.0/SharedObjects/", Order=3)]
    public int partGroup
    {
        get
        {
            return this.partGroupField;
        }
        set
        {
            this.partGroupField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.promostandards.org/WSDL/PricingAndConfiguration/1.0.0/SharedObjects/", Order=4)]
    public int nextPartGroup
    {
        get
        {
            return this.nextPartGroupField;
        }
        set
        {
            this.nextPartGroupField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool nextPartGroupSpecified
    {
        get
        {
            return this.nextPartGroupFieldSpecified;
        }
        set
        {
            this.nextPartGroupFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.promostandards.org/WSDL/PricingAndConfiguration/1.0.0/SharedObjects/", Order=5)]
    public bool partGroupRequired
    {
        get
        {
            return this.partGroupRequiredField;
        }
        set
        {
            this.partGroupRequiredField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.promostandards.org/WSDL/PricingAndConfiguration/1.0.0/SharedObjects/", DataType="token", Order=6)]
    public string partGroupDescription
    {
        get
        {
            return this.partGroupDescriptionField;
        }
        set
        {
            this.partGroupDescriptionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.promostandards.org/WSDL/PricingAndConfiguration/1.0.0/SharedObjects/", Order=7)]
    public decimal ratio
    {
        get
        {
            return this.ratioField;
        }
        set
        {
            this.ratioField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.promostandards.org/WSDL/PricingAndConfiguration/1.0.0/SharedObjects/", IsNullable=true, Order=8)]
    public System.Nullable<bool> defaultPart
    {
        get
        {
            return this.defaultPartField;
        }
        set
        {
            this.defaultPartField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Order=9)]
    [System.Xml.Serialization.XmlArrayItemAttribute("LocationId", IsNullable=false)]
    public PartLocationId[] LocationIdArray
    {
        get
        {
            return this.locationIdArrayField;
        }
        set
        {
            this.locationIdArrayField = value;
        }
    }
}