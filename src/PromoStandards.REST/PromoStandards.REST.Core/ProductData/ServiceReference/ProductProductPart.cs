using PromoStandards.REST.Core.ProductData.ServiceReference;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.promostandards.org/WSDL/ProductDataService/2.0.0/")]
public partial class ProductPart
{
    
    private string partIdField;
    
    private Color primaryColorField;
    
    private string[] descriptionField;
    
    private countryOfOrigin countryOfOriginField;
    
    private bool countryOfOriginFieldSpecified;
    
    private Color[] colorArrayField;
    
    private string primaryMaterialField;
    
    private Specification[] specificationArrayField;
    
    private string shapeField;
    
    private ApparelSize apparelSizeField;
    
    private Dimension dimensionField;
    
    private int leadTimeField;
    
    private bool leadTimeFieldSpecified;
    
    private string unspscField;
    
    private string gtinField;
    
    private System.Nullable<bool> isRushServiceField;
    
    private ProductPackage[] productPackagingArrayField;
    
    private ShippingPackage[] shippingPackageArrayField;
    
    private System.Nullable<System.DateTime> endDateField;
    
    private System.Nullable<System.DateTime> effectiveDateField;
    
    private System.Nullable<bool> isCloseoutField;
    
    private System.Nullable<bool> isCautionField;
    
    private string cautionCommentField;
    
    private decimal nmfcCodeField;
    
    private bool nmfcCodeFieldSpecified;
    
    private string nmfcDescriptionField;
    
    private string nmfcNumberField;
    
    private System.Nullable<bool> isOnDemandField;
    
    private System.Nullable<bool> isHazmatField;

    /// <summary>
    /// The part Id
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.promostandards.org/WSDL/ProductDataService/2.0.0/SharedObjects/", DataType="token", Order=0)]
    [Required]
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

    /// <summary>
    /// The "go to market" color. Represented as a Color Object.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public Color primaryColor
    {
        get
        {
            return this.primaryColorField;
        }
        set
        {
            this.primaryColorField = value;
        }
    }

    /// <summary>
    /// Description
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute("description", Namespace="http://www.promostandards.org/WSDL/ProductDataService/2.0.0/SharedObjects/", DataType="token", Order=2)]
    public string[] description
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
    /// Country of Origin ISO 3166-1 Alpha 2 code for Country     Example: CA=Canada; US=United States
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.promostandards.org/WSDL/ProductDataService/2.0.0/SharedObjects/", Order=3)]
    public countryOfOrigin countryOfOrigin
    {
        get
        {
            return this.countryOfOriginField;
        }
        set
        {
            this.countryOfOriginField = value;
        }
    }

    /// <summary>
    /// Information about the part colors
    /// </summary>
    [System.Xml.Serialization.XmlArrayAttribute(Order=4)]
    [System.Xml.Serialization.XmlArrayItemAttribute("Color", Namespace="http://www.promostandards.org/WSDL/ProductDataService/2.0.0/SharedObjects/", IsNullable=false)]
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

    /// <summary>
    /// Primary material of construction
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.promostandards.org/WSDL/ProductDataService/2.0.0/SharedObjects/", DataType="token", Order=5)]
    public string primaryMaterial
    {
        get
        {
            return this.primaryMaterialField;
        }
        set
        {
            this.primaryMaterialField = value;
        }
    }

    /// <summary>
    /// Specifications
    /// </summary>
    [System.Xml.Serialization.XmlArrayAttribute(Order=6)]
    [System.Xml.Serialization.XmlArrayItemAttribute("Specification", Namespace="http://www.promostandards.org/WSDL/ProductDataService/2.0.0/SharedObjects/", IsNullable=false)]
    public Specification[] SpecificationArray
    {
        get
        {
            return this.specificationArrayField;
        }
        set
        {
            this.specificationArrayField = value;
        }
    }

    /// <summary>
    /// General shape
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.promostandards.org/WSDL/ProductDataService/2.0.0/SharedObjects/", DataType="token", Order=7)]
    public string shape
    {
        get
        {
            return this.shapeField;
        }
        set
        {
            this.shapeField = value;
        }
    }

    /// <summary>
    /// Used to describe an apparel size
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.promostandards.org/WSDL/ProductDataService/2.0.0/SharedObjects/", Order=8)]
    public ApparelSize ApparelSize
    {
        get
        {
            return this.apparelSizeField;
        }
        set
        {
            this.apparelSizeField = value;
        }
    }

    /// <summary>
    /// Physical dimensions and weight
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.promostandards.org/WSDL/ProductDataService/2.0.0/SharedObjects/", Order=9)]
    public Dimension Dimension
    {
        get
        {
            return this.dimensionField;
        }
        set
        {
            this.dimensionField = value;
        }
    }

    /// <summary>
    /// Lead time in days
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order=10)]
    public int leadTime
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

    /// <summary>
    /// United Nations Standard Products and Services Code (UNSPSC)
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.promostandards.org/WSDL/ProductDataService/2.0.0/SharedObjects/", DataType="token", Order=11)]
    public string unspsc
    {
        get
        {
            return this.unspscField;
        }
        set
        {
            this.unspscField = value;
        }
    }

    /// <summary>
    /// Global Trade Item Number (GTIN)
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.promostandards.org/WSDL/ProductDataService/2.0.0/SharedObjects/", DataType="token", Order=12)]
    public string gtin
    {
        get
        {
            return this.gtinField;
        }
        set
        {
            this.gtinField = value;
        }
    }

    /// <summary>
    /// Rush service
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.promostandards.org/WSDL/ProductDataService/2.0.0/SharedObjects/", IsNullable=true, Order=13)]
    [Required]
    public System.Nullable<bool> isRushService
    {
        get
        {
            return this.isRushServiceField;
        }
        set
        {
            this.isRushServiceField = value;
        }
    }

    /// <summary>
    /// Packaging option details; e.g. Gift Box, Cello Pack, Sleeve.  An array of ProductPackaging objects.
    /// </summary>
    [System.Xml.Serialization.XmlArrayAttribute(Order=14)]
    [System.Xml.Serialization.XmlArrayItemAttribute("ProductPackage", Namespace="http://www.promostandards.org/WSDL/ProductDataService/2.0.0/SharedObjects/", IsNullable=false)]
    public ProductPackage[] ProductPackagingArray
    {
        get
        {
            return this.productPackagingArrayField;
        }
        set
        {
            this.productPackagingArrayField = value;
        }
    }

    /// <summary>
    /// Shipping package option details for the partPackaging Default package type; e.g. Carton, Box, Pallet.  An array of ShippingPackage objects.
    /// </summary>
    [System.Xml.Serialization.XmlArrayAttribute(Order=15)]
    [System.Xml.Serialization.XmlArrayItemAttribute("ShippingPackage", Namespace="http://www.promostandards.org/WSDL/ProductDataService/2.0.0/SharedObjects/", IsNullable=false)]
    public ShippingPackage[] ShippingPackageArray
    {
        get
        {
            return this.shippingPackageArrayField;
        }
        set
        {
            this.shippingPackageArrayField = value;
        }
    }

    /// <summary>
    /// The date this part expires from supplier availability in ISO 8601 format
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.promostandards.org/WSDL/ProductDataService/2.0.0/SharedObjects/", IsNullable=true, Order=16)]
    public System.Nullable<System.DateTime> endDate
    {
        get
        {
            return this.endDateField;
        }
        set
        {
            this.endDateField = value;
        }
    }

    /// <summary>
    /// The Date this Part initially becomes available from the Supplier in ISO 8601 format
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.promostandards.org/WSDL/ProductDataService/2.0.0/SharedObjects/", IsNullable=true, Order=17)]
    public System.Nullable<System.DateTime> effectiveDate
    {
        get
        {
            return this.effectiveDateField;
        }
        set
        {
            this.effectiveDateField = value;
        }
    }

    /// <summary>
    /// Indicates if a closeout
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.promostandards.org/WSDL/ProductDataService/2.0.0/SharedObjects/", IsNullable=true, Order=18)]
    [Required]
    public System.Nullable<bool> isCloseout
    {
        get
        {
            return this.isCloseoutField;
        }
        set
        {
            this.isCloseoutField = value;
        }
    }

    /// <summary>
    /// Cautionary status to review for specific warnings about using product data
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.promostandards.org/WSDL/ProductDataService/2.0.0/SharedObjects/", IsNullable=true, Order=19)]
    [Required]
    public System.Nullable<bool> isCaution
    {
        get
        {
            return this.isCautionField;
        }
        set
        {
            this.isCautionField = value;
        }
    }

    /// <summary>
    /// Cautionary comments
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.promostandards.org/WSDL/ProductDataService/2.0.0/SharedObjects/", DataType="token", Order=20)]
    public string cautionComment
    {
        get
        {
            return this.cautionCommentField;
        }
        set
        {
            this.cautionCommentField = value;
        }
    }

    /// <summary>
    /// National Motor Freight Classification Code
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.promostandards.org/WSDL/ProductDataService/2.0.0/SharedObjects/", Order=21)]
    public decimal nmfcCode
    {
        get
        {
            return this.nmfcCodeField;
        }
        set
        {
            this.nmfcCodeField = value;
        }
    }

    /// <summary>
    /// National Motor Freight Classification Description
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.promostandards.org/WSDL/ProductDataService/2.0.0/SharedObjects/", DataType="token", Order=22)]
    public string nmfcDescription
    {
        get
        {
            return this.nmfcDescriptionField;
        }
        set
        {
            this.nmfcDescriptionField = value;
        }
    }

    /// <summary>
    /// National Motor Freight Classification Number
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.promostandards.org/WSDL/ProductDataService/2.0.0/SharedObjects/", DataType="token", Order=23)]
    public string nmfcNumber
    {
        get
        {
            return this.nmfcNumberField;
        }
        set
        {
            this.nmfcNumberField = value;
        }
    }

    /// <summary>
    /// Manufactured on demand / Made to order
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.promostandards.org/WSDL/ProductDataService/2.0.0/SharedObjects/", IsNullable=true, Order=24)]
    public System.Nullable<bool> isOnDemand
    {
        get
        {
            return this.isOnDemandField;
        }
        set
        {
            this.isOnDemandField = value;
        }
    }

    /// <summary>
    /// Contains hazardous material.  A nil value indicates this it is unknown or the data is not available by the supplier.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.promostandards.org/WSDL/ProductDataService/2.0.0/SharedObjects/", IsNullable=true, Order=25)]
    public System.Nullable<bool> isHazmat
    {
        get
        {
            return this.isHazmatField;
        }
        set
        {
            this.isHazmatField = value;
        }
    }
}