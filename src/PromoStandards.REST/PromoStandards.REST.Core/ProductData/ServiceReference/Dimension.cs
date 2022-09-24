using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace PromoStandards.REST.Core.ProductData.ServiceReference;

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

    /// <summary>
    /// The dimensional unit of measure
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    [Required]
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

    /// <summary>
    /// The depth/length of the part using the unit of measure specified in dimensionUom
    /// </summary>
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

    /// <summary>
    /// The height of the part using the unit of measure specified in dimensionUom
    /// </summary>
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

    /// <summary>
    /// The width of the part using the unit of measure specified in dimensionUom
    /// </summary>
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

    /// <summary>
    /// The weight unit of measure for the part
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order=4)]
    [Required]
    public weightUom weightUom {
        get
        {
            return this.weightUomField;
        }
        set
        {
            this.weightUomField = value;
        }
    }

    /// <summary>
    /// The weight of the part using the unit of measure specified in dimensionUom
    /// </summary>
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