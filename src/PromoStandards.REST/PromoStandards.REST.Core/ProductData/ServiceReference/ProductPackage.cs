using System.ComponentModel.DataAnnotations;

namespace PromoStandards.REST.Core.ProductData.ServiceReference;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.promostandards.org/WSDL/ProductDataService/2.0.0/SharedObjects/")]
public partial class ProductPackage
{
    
    private bool defaultField;
    
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
    /// Boolean flag identifying the single default packaging for this package
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    [Required]
    public bool @default
    {
        get
        {
            return this.defaultField;
        }
        set
        {
            this.defaultField = value;
        }
    }

    /// <summary>
    /// The packaging specific type for this partId e.g. Gift Box, Cello Pack, Sleeve
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=1)]
    [Required]
    public string packageType {
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
    /// The Packaging specific description
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=2)]
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
    /// The partId unit Quantity included within this specific Packaging Option
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    [Required]
    public decimal quantity {
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
    /// The unit of measure for the package
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order=4)]
    [Required]
    public dimensionUom dimensionUom {
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
    /// The depth/length of the package in the dimensionUom unit of measure
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=5)]
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
    /// The height of the package in the dimensionUom unit of measure
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=6)]
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
    /// The width of the package in the dimensionUom unit of measure
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=7)]
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
    [System.Xml.Serialization.XmlElementAttribute(Order=8)]
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
    /// The weight of the specific packageType
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=9)]
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