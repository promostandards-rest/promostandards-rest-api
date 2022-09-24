using System.ComponentModel.DataAnnotations;

namespace PromoStandards.REST.Core.ProductData.ServiceReference;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.promostandards.org/WSDL/ProductDataService/2.0.0/SharedObjects/")]
public partial class ShippingPackage
{
    
    private string packageTypeField;
    
    private string descriptionField;
    
    private decimal quantityField;
    
    private dimensionUom dimensionUomField;
    
    private System.Nullable<decimal> depthField;
    
    private System.Nullable<decimal> heightField;
    
    private System.Nullable<decimal> widthField;
    
    private weightUom weightUomField;
    
    private System.Nullable<decimal> weightField;

    /// <summary>
    /// The shipping package specific type for this shipping package e.g. Box, Carton, etc.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=0)]
    [Required]
    public string packageType
    {
        get
        {
            return this.packageTypeField;
        }
        set
        {
            this.packageTypeField = value;
        }
    }

    /// <summary>
    /// The shipping package specific description
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=1)]
    public string description
    {
        get
        {
            return this.descriptionField;
        }
        set
        {
            this.descriptionField = value;
        }
    }

    /// <summary>
    /// The partId unit quantity included within this specific shipping packaging option
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    [Required]
    public decimal quantity
    {
        get
        {
            return this.quantityField;
        }
        set
        {
            this.quantityField = value;
        }
    }

    /// <summary>
    /// The weight unit of measure for the packageType
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
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
    /// The depth/length of the shipping package in the dimensionUom unit of measure
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=4)]
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
    /// The height of the shipping package in the dimensionUom unit of measure
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=5)]
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
    /// The width of the shipping package in the dimensionUom unit of measure
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=6)]
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
    /// The weight unit of measure for the packageType
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order=7)]
    [Required]
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

    /// <summary>
    /// The weight of the specific packageType
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=8)]
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