/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.promostandards.org/WSDL/ProductDataService/2.0.0/SharedObjects/")]
public partial class Dimension
{
    
    private dimensionUom dimensionUomField;
    
    private System.Nullable<decimal> depthField;
    
    private System.Nullable<decimal> heightField;
    
    private System.Nullable<decimal> widthField;
    
    private weightUom weightUomField;
    
    private System.Nullable<decimal> weightField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public dimensionUom dimensionUom
    {
        get
        {
            return this.dimensionUomField;
        }
        set
        {
            this.dimensionUomField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=1)]
    public System.Nullable<decimal> depth
    {
        get
        {
            return this.depthField;
        }
        set
        {
            this.depthField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=2)]
    public System.Nullable<decimal> height
    {
        get
        {
            return this.heightField;
        }
        set
        {
            this.heightField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=3)]
    public System.Nullable<decimal> width
    {
        get
        {
            return this.widthField;
        }
        set
        {
            this.widthField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=4)]
    public weightUom weightUom
    {
        get
        {
            return this.weightUomField;
        }
        set
        {
            this.weightUomField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=5)]
    public System.Nullable<decimal> weight
    {
        get
        {
            return this.weightField;
        }
        set
        {
            this.weightField = value;
        }
    }
}