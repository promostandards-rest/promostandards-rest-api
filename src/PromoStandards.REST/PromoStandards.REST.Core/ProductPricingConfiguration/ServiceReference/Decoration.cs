using System.Text.Json.Serialization;

namespace PromoStandards.REST.Core.ProductPricingConfiguration.ServiceReference;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.promostandards.org/WSDL/PricingAndConfiguration/1.0.0/")]
public partial class Decoration
{
    
    private int decorationIdField;
    
    private string decorationNameField;
    
    private string decorationGeometryField;
    
    private System.Nullable<decimal> decorationHeightField;
    
    private System.Nullable<decimal> decorationWidthField;
    
    private System.Nullable<decimal> decorationDiameterField;
    
    private decorationUom decorationUomField;
    
    private System.Nullable<bool> allowSubForDefaultLocationField;
    
    private System.Nullable<bool> allowSubForDefaultMethodField;
    
    private System.Nullable<int> itemPartQuantityLTMField;
    
    private bool itemPartQuantityLTMFieldSpecified;
    
    private Charge[] chargeArrayField;
    
    private System.Nullable<int> decorationUnitsIncludedField;
    
    private bool decorationUnitsIncludedFieldSpecified;
    
    private string decorationUnitsIncludedUomField;
    
    private System.Nullable<int> decorationUnitsMaxField;
    
    private bool decorationUnitsMaxFieldSpecified;
    
    private System.Nullable<bool> defaultDecorationField;
    
    private System.Nullable<int> leadTimeField;
    
    private bool leadTimeFieldSpecified;
    
    private System.Nullable<int> rushLeadTimeField;
    
    private bool rushLeadTimeFieldSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.promostandards.org/WSDL/PricingAndConfiguration/1.0.0/SharedObjects/", Order=0)]
    public int decorationId
    {
        get
        {
            return this.decorationIdField;
        }
        set
        {
            this.decorationIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.promostandards.org/WSDL/PricingAndConfiguration/1.0.0/SharedObjects/", Order=1)]
    public string decorationName
    {
        get
        {
            return this.decorationNameField;
        }
        set
        {
            this.decorationNameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.promostandards.org/WSDL/PricingAndConfiguration/1.0.0/SharedObjects/", Order=2)]
    public string decorationGeometry
    {
        get
        {
            return this.decorationGeometryField;
        }
        set
        {
            this.decorationGeometryField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.promostandards.org/WSDL/PricingAndConfiguration/1.0.0/SharedObjects/", IsNullable=true, Order=3)]
    public System.Nullable<decimal> decorationHeight
    {
        get
        {
            return this.decorationHeightField;
        }
        set
        {
            this.decorationHeightField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.promostandards.org/WSDL/PricingAndConfiguration/1.0.0/SharedObjects/", IsNullable=true, Order=4)]
    public System.Nullable<decimal> decorationWidth
    {
        get
        {
            return this.decorationWidthField;
        }
        set
        {
            this.decorationWidthField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.promostandards.org/WSDL/PricingAndConfiguration/1.0.0/SharedObjects/", IsNullable=true, Order=5)]
    public System.Nullable<decimal> decorationDiameter
    {
        get
        {
            return this.decorationDiameterField;
        }
        set
        {
            this.decorationDiameterField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.promostandards.org/WSDL/PricingAndConfiguration/1.0.0/SharedObjects/", Order=6)]
    public decorationUom decorationUom
    {
        get
        {
            return this.decorationUomField;
        }
        set
        {
            this.decorationUomField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=7)]
    public System.Nullable<bool> allowSubForDefaultLocation
    {
        get
        {
            return this.allowSubForDefaultLocationField;
        }
        set
        {
            this.allowSubForDefaultLocationField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=8)]
    public System.Nullable<bool> allowSubForDefaultMethod
    {
        get
        {
            return this.allowSubForDefaultMethodField;
        }
        set
        {
            this.allowSubForDefaultMethodField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=9)]
    public System.Nullable<int> itemPartQuantityLTM
    {
        get
        {
            return this.itemPartQuantityLTMField;
        }
        set
        {
            this.itemPartQuantityLTMField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [JsonIgnore]
    public bool itemPartQuantityLTMSpecified
    {
        get
        {
            return this.itemPartQuantityLTMFieldSpecified;
        }
        set
        {
            this.itemPartQuantityLTMFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Order=10)]
    [System.Xml.Serialization.XmlArrayItemAttribute("Charge", IsNullable=false)]
    public Charge[] ChargeArray
    {
        get
        {
            return this.chargeArrayField;
        }
        set
        {
            this.chargeArrayField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=11)]
    public System.Nullable<int> decorationUnitsIncluded
    {
        get
        {
            return this.decorationUnitsIncludedField;
        }
        set
        {
            this.decorationUnitsIncludedField = value;
        }
    }
    
    /// <remarks/>
    [JsonIgnore]
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool decorationUnitsIncludedSpecified
    {
        get
        {
            return this.decorationUnitsIncludedFieldSpecified;
        }
        set
        {
            this.decorationUnitsIncludedFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.promostandards.org/WSDL/PricingAndConfiguration/1.0.0/SharedObjects/", Order=12)]
    public string decorationUnitsIncludedUom
    {
        get
        {
            return this.decorationUnitsIncludedUomField;
        }
        set
        {
            this.decorationUnitsIncludedUomField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.promostandards.org/WSDL/PricingAndConfiguration/1.0.0/SharedObjects/", IsNullable=true, Order=13)]
    public System.Nullable<int> decorationUnitsMax
    {
        get
        {
            return this.decorationUnitsMaxField;
        }
        set
        {
            this.decorationUnitsMaxField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool decorationUnitsMaxSpecified
    {
        get
        {
            return this.decorationUnitsMaxFieldSpecified;
        }
        set
        {
            this.decorationUnitsMaxFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=14)]
    public System.Nullable<bool> defaultDecoration
    {
        get
        {
            return this.defaultDecorationField;
        }
        set
        {
            this.defaultDecorationField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=15)]
    public System.Nullable<int> leadTime
    {
        get
        {
            return this.leadTimeField;
        }
        set
        {
            this.leadTimeField = value;
        }
    }
    
    /// <remarks/>
    [JsonIgnore]
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool leadTimeSpecified
    {
        get
        {
            return this.leadTimeFieldSpecified;
        }
        set
        {
            this.leadTimeFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=16)]
    public System.Nullable<int> rushLeadTime
    {
        get
        {
            return this.rushLeadTimeField;
        }
        set
        {
            this.rushLeadTimeField = value;
        }
    }

    /// <remarks/>
    [JsonIgnore]
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool rushLeadTimeSpecified
    {
        get
        {
            return this.rushLeadTimeFieldSpecified;
        }
        set
        {
            this.rushLeadTimeFieldSpecified = value;
        }
    }
}