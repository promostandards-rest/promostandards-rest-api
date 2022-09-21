using System.ComponentModel.DataAnnotations;

/// <summary>
/// Product class summary
/// </summary>
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.promostandards.org/WSDL/ProductDataService/2.0.0/")]
public partial class Product
{
    
    /// <summary>
    /// The associated product.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.promostandards.org/WSDL/ProductDataService/2.0.0/SharedObjects/", DataType = "token", Order = 0)]
    [Required]
    public string productId { get; set; } = String.Empty;

    /// <summary>
    /// The Supplier name for the product
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.promostandards.org/WSDL/ProductDataService/2.0.0/SharedObjects/", DataType="token", Order=1)]
    [Required]
    public string productName { get; set; } = String.Empty;

    /// <summary>
    /// Basic product description or bulleted list of descriptions.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute("description", Namespace="http://www.promostandards.org/WSDL/ProductDataService/2.0.0/SharedObjects/", DataType="token", Order=2)]
    [Required]
    public string description { get; set; } = String.Empty;

    /// <summary>
    /// The date that the pricing in the ProductPriceGroupArray portion of the response expires.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.promostandards.org/WSDL/ProductDataService/2.0.0/SharedObjects/", IsNullable=true, Order=3)]
    public System.DateTime? priceExpiresDate { get; set; }

    /// <summary>
    /// Marketing points type and content.  An array of MarketingPoint objects.
    /// </summary>
    [System.Xml.Serialization.XmlArrayAttribute(Order=4)]
    [System.Xml.Serialization.XmlArrayItemAttribute("ProductMarketingPoint", Namespace="http://www.promostandards.org/WSDL/ProductDataService/2.0.0/SharedObjects/", IsNullable=false)]
    public ProductMarketingPoint[]? ProductMarketingPointArray { get; set; }

    /// <summary>
    /// Array of keywords often used in searching for this product.  An array of ProductKeyword objects.
    /// </summary>
    [System.Xml.Serialization.XmlArrayAttribute(Order=5)]
    [System.Xml.Serialization.XmlArrayItemAttribute("ProductKeyword", Namespace="http://www.promostandards.org/WSDL/ProductDataService/2.0.0/SharedObjects/", IsNullable=false)]
    public ProductKeyword[]? ProductKeywordArray { get; set; }

    /// <summary>
    /// The specific product brand
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.promostandards.org/WSDL/ProductDataService/2.0.0/SharedObjects/", DataType="token", Order=6)]
    public string? productBrand { get; set; }

    /// <summary>
    /// Product status for export
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=7)]
    [Required]
    public bool? export { get; set; }

    /// <summary>
    /// The product’s categorization array.  An array of ProductCategory objects.
    /// </summary>
    [System.Xml.Serialization.XmlArrayAttribute(Order=8)]
    [System.Xml.Serialization.XmlArrayItemAttribute("ProductCategory", Namespace="http://www.promostandards.org/WSDL/ProductDataService/2.0.0/SharedObjects/", IsNullable=false)]
    public ProductCategory[]? ProductCategoryArray { get; set; }

    /// <summary>
    /// Products related to the quested product as Substitutable, CompanionSell, or Common Grouping (Family).  An array of RelatedProduct objects.
    /// </summary>
    [System.Xml.Serialization.XmlArrayAttribute(Order=9)]
    [System.Xml.Serialization.XmlArrayItemAttribute("RelatedProduct", Namespace="http://www.promostandards.org/WSDL/ProductDataService/2.0.0/SharedObjects/", IsNullable=false)]
    public RelatedProduct[]? RelatedProductArray { get; set; }

    /// <summary>
    /// The URL of the product’s primary image. Any valid URL can be returned including prefixes like http and ftp.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.promostandards.org/WSDL/ProductDataService/2.0.0/SharedObjects/", DataType="token", Order=10)]
    public string? primaryImageUrl { get; set; }

    /// <summary>
    /// All part specific product data.  An array of ProductPart objects. 
    /// </summary>
    [System.Xml.Serialization.XmlArrayAttribute(Order=11)]
    [System.Xml.Serialization.XmlArrayItemAttribute("ProductPriceGroup", Namespace="http://www.promostandards.org/WSDL/ProductDataService/2.0.0/SharedObjects/", IsNullable=false)]
    public ProductPriceGroup[]? ProductPriceGroupArray { get; set; }

    /// <summary>
    /// Indicates if there is information about this product via the Product Safety and Compliance service.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.promostandards.org/WSDL/ProductDataService/2.0.0/SharedObjects/", IsNullable=true, Order=12)]
    public bool? complianceInfoAvailable { get; set; }

    /// <summary>
    /// The United Nations Standard Products and Services Code® (UNSPSC®) that best describes this product. Note that the enumerated values are the UNSPSC "Commodity" codes. For more information, refer to https://www.unspsc.org.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order=13)]
    public int unspscCommodityCode { get; set; }

    /// <summary>
    /// An array of Location Decoration objects
    /// </summary>
    [System.Xml.Serialization.XmlArrayAttribute(Namespace="http://www.promostandards.org/WSDL/ProductDataService/2.0.0/SharedObjects/", Order=14)]
    [System.Xml.Serialization.XmlArrayItemAttribute("LocationDecoration", IsNullable=false)]
    [Required]
    public LocationDecoration[]? LocationDecorationArray { get; set; }

    /// <summary>
    /// All part specific product data.  An array of ProductPart objects. 
    /// </summary>
    [System.Xml.Serialization.XmlArrayAttribute(Order=15)]
    [System.Xml.Serialization.XmlArrayItemAttribute("ProductPart", IsNullable=false)]
    [Required]
    public ProductProductPart[]? ProductPartArray { get; set; }

    /// <summary>
    /// The date time stamp of the most recent change to this data in ISO 8601 format
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order=16)]
    [Required]
    public System.DateTime lastChangeDate { get; set; }

    /// <summary>
    /// The date time stamp when this products data initially became available in ISO 8601 format
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order=17)]
    [Required]
    public System.DateTime creationDate { get; set; }

    /// <summary>
    /// The date this part expires from supplier availability in ISO 8601 format
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.promostandards.org/WSDL/ProductDataService/2.0.0/SharedObjects/", IsNullable=true, Order=18)]
    public System.DateTime? endDate { get; set; }

    /// <summary>
    /// The Date this Part initially becomes available from the Supplier in ISO 8601 format
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.promostandards.org/WSDL/ProductDataService/2.0.0/SharedObjects/", IsNullable=true, Order=19)]
    public System.DateTime? effectiveDate { get; set; }

    /// <summary>
    /// Cautionary status to review for specific warnings about using product data
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.promostandards.org/WSDL/ProductDataService/2.0.0/SharedObjects/", IsNullable=true, Order=20)]
    [Required]
    public bool? isCaution { get; set; }

    /// <summary>
    /// Cautionary comments
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.promostandards.org/WSDL/ProductDataService/2.0.0/SharedObjects/", DataType="token", Order=21)]
    public string? cautionComment { get; set; }

    /// <summary>
    /// Indicates if a closeout
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.promostandards.org/WSDL/ProductDataService/2.0.0/SharedObjects/", IsNullable=true, Order=22)]
    [Required]
    public bool? isCloseout { get; set; }

    /// <summary>
    /// The line name (ex : Trimark, Hit)
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.promostandards.org/WSDL/ProductDataService/2.0.0/SharedObjects/", DataType="token", Order=23)]
    public string? lineName { get; set; }

    /// <summary>
    /// The default setup charge for this product. Can be a textual description.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.promostandards.org/WSDL/ProductDataService/2.0.0/SharedObjects/", DataType="token", Order=24)]
    public string? defaultSetupCharge { get; set; }

    /// <summary>
    /// The default RUN charge for this product. Can be a textual description
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.promostandards.org/WSDL/ProductDataService/2.0.0/SharedObjects/", DataType="token", Order=25)]
    public string? defaultRunCharge { get; set; }

    /// <summary>
    /// The imprint size
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.promostandards.org/WSDL/ProductDataService/2.0.0/SharedObjects/", DataType="token", Order=26)]
    public string? imprintSize { get; set; }

    /// <summary>
    /// An array of FOB points object
    /// </summary>
    [System.Xml.Serialization.XmlArrayAttribute(Namespace="http://www.promostandards.org/WSDL/ProductDataService/2.0.0/SharedObjects/", Order=27)]
    [System.Xml.Serialization.XmlArrayItemAttribute("FobPoint", IsNullable=false)]
    [Required]
    public FobPoint[]? FobPointArray { get; set; }
}