namespace PromoStandards.REST.Core.ProductPricingConfiguration.ServiceReference;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.promostandards.org/WSDL/PricingAndConfiguration/1.0.0/")]
public partial class GetDecorationColorsResponseDecorationColors
{
    
    private Color[] colorArrayField;
    
    private string productIdField;
    
    private int locationIdField;
    
    private DecorationMethod[] decorationMethodArrayField;
    
    private System.Nullable<bool> pmsMatchField;
    
    private System.Nullable<bool> fullColorField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Order=0)]
    [System.Xml.Serialization.XmlArrayItemAttribute("Color", IsNullable=false)]
    public Color[] ColorArray
    {
        get
        {
            return this.colorArrayField;
        }
        set
        {
            this.colorArrayField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.promostandards.org/WSDL/PricingAndConfiguration/1.0.0/SharedObjects/", DataType="token", Order=1)]
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
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.promostandards.org/WSDL/PricingAndConfiguration/1.0.0/SharedObjects/", Order=2)]
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
    [System.Xml.Serialization.XmlArrayAttribute(Order=3)]
    [System.Xml.Serialization.XmlArrayItemAttribute("DecorationMethod", IsNullable=false)]
    public DecorationMethod[] DecorationMethodArray
    {
        get
        {
            return this.decorationMethodArrayField;
        }
        set
        {
            this.decorationMethodArrayField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=4)]
    public System.Nullable<bool> pmsMatch
    {
        get
        {
            return this.pmsMatchField;
        }
        set
        {
            this.pmsMatchField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=5)]
    public System.Nullable<bool> fullColor
    {
        get
        {
            return this.fullColorField;
        }
        set
        {
            this.fullColorField = value;
        }
    }
}