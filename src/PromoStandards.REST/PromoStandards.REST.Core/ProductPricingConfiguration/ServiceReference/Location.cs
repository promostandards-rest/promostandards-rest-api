namespace PromoStandards.REST.Core.ProductPricingConfiguration.ServiceReference;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.promostandards.org/WSDL/PricingAndConfiguration/1.0.0/")]
public partial class Location
{
    
    private int locationIdField;
    
    private string locationNameField;
    
    private Decoration[] decorationArrayField;
    
    private int decorationsIncludedField;
    
    private bool defaultLocationField;
    
    private int maxDecorationField;
    
    private int minDecorationField;
    
    private System.Nullable<int> locationRankField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.promostandards.org/WSDL/PricingAndConfiguration/1.0.0/SharedObjects/", Order=0)]
    public int locationId
    {
        get
        {
            return this.locationIdField;
        }
        set
        {
            this.locationIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.promostandards.org/WSDL/PricingAndConfiguration/1.0.0/SharedObjects/", Order=1)]
    public string locationName
    {
        get
        {
            return this.locationNameField;
        }
        set
        {
            this.locationNameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Order=2)]
    [System.Xml.Serialization.XmlArrayItemAttribute("Decoration", IsNullable=false)]
    public Decoration[] DecorationArray
    {
        get
        {
            return this.decorationArrayField;
        }
        set
        {
            this.decorationArrayField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.promostandards.org/WSDL/PricingAndConfiguration/1.0.0/SharedObjects/", Order=3)]
    public int decorationsIncluded
    {
        get
        {
            return this.decorationsIncludedField;
        }
        set
        {
            this.decorationsIncludedField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.promostandards.org/WSDL/PricingAndConfiguration/1.0.0/SharedObjects/", Order=4)]
    public bool defaultLocation
    {
        get
        {
            return this.defaultLocationField;
        }
        set
        {
            this.defaultLocationField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.promostandards.org/WSDL/PricingAndConfiguration/1.0.0/SharedObjects/", Order=5)]
    public int maxDecoration
    {
        get
        {
            return this.maxDecorationField;
        }
        set
        {
            this.maxDecorationField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.promostandards.org/WSDL/PricingAndConfiguration/1.0.0/SharedObjects/", Order=6)]
    public int minDecoration
    {
        get
        {
            return this.minDecorationField;
        }
        set
        {
            this.minDecorationField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.promostandards.org/WSDL/PricingAndConfiguration/1.0.0/SharedObjects/", IsNullable=true, Order=7)]
    public System.Nullable<int> locationRank
    {
        get
        {
            return this.locationRankField;
        }
        set
        {
            this.locationRankField = value;
        }
    }
}