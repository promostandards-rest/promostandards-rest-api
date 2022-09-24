namespace PromoStandards.REST.MongoDBApp.ProductData.ServiceReference;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.promostandards.org/WSDL/ProductDataService/2.0.0/")]
public partial class Product
{
    
    private string productIdField;
    
    private string productNameField;
    
    private string[] descriptionField;
    
    private System.Nullable<System.DateTime> priceExpiresDateField;
    
    private bool priceExpiresDateFieldSpecified;
    
    private ProductMarketingPoint[] productMarketingPointArrayField;
    
    private ProductKeyword[] productKeywordArrayField;
    
    private string productBrandField;
    
    private System.Nullable<bool> exportField;
    
    private ProductCategory[] productCategoryArrayField;
    
    private RelatedProduct[] relatedProductArrayField;
    
    private string primaryImageUrlField;
    
    private ProductPriceGroup[] productPriceGroupArrayField;
    
    private System.Nullable<bool> complianceInfoAvailableField;
    
    private int unspscCommodityCodeField;
    
    private bool unspscCommodityCodeFieldSpecified;
    
    private LocationDecorationArrayLocationDecoration[] locationDecorationArrayField;
    
    private ProductProductPart[] productPartArrayField;
    
    private System.DateTime lastChangeDateField;
    
    private System.DateTime creationDateField;
    
    private System.Nullable<System.DateTime> endDateField;
    
    private System.Nullable<System.DateTime> effectiveDateField;
    
    private System.Nullable<bool> isCautionField;
    
    private string cautionCommentField;
    
    private System.Nullable<bool> isCloseoutField;
    
    private string lineNameField;
    
    private string defaultSetupChargeField;
    
    private string defaultRunChargeField;
    
    private string imprintSizeField;
    
    private FobPoint[] fobPointArrayField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.promostandards.org/WSDL/ProductDataService/2.0.0/SharedObjects/", DataType="token", Order=0)]
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
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.promostandards.org/WSDL/ProductDataService/2.0.0/SharedObjects/", DataType="token", Order=1)]
    public string productName
    {
        get
        {
            return this.productNameField;
        }
        set
        {
            this.productNameField = value;
        }
    }
    
    /// <remarks/>
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
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.promostandards.org/WSDL/ProductDataService/2.0.0/SharedObjects/", IsNullable=true, Order=3)]
    public System.Nullable<System.DateTime> priceExpiresDate
    {
        get
        {
            return this.priceExpiresDateField;
        }
        set
        {
            this.priceExpiresDateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool priceExpiresDateSpecified
    {
        get
        {
            return this.priceExpiresDateFieldSpecified;
        }
        set
        {
            this.priceExpiresDateFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Order=4)]
    [System.Xml.Serialization.XmlArrayItemAttribute("ProductMarketingPoint", Namespace="http://www.promostandards.org/WSDL/ProductDataService/2.0.0/SharedObjects/", IsNullable=false)]
    public ProductMarketingPoint[] ProductMarketingPointArray
    {
        get
        {
            return this.productMarketingPointArrayField;
        }
        set
        {
            this.productMarketingPointArrayField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Order=5)]
    [System.Xml.Serialization.XmlArrayItemAttribute("ProductKeyword", Namespace="http://www.promostandards.org/WSDL/ProductDataService/2.0.0/SharedObjects/", IsNullable=false)]
    public ProductKeyword[] ProductKeywordArray
    {
        get
        {
            return this.productKeywordArrayField;
        }
        set
        {
            this.productKeywordArrayField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.promostandards.org/WSDL/ProductDataService/2.0.0/SharedObjects/", DataType="token", Order=6)]
    public string productBrand
    {
        get
        {
            return this.productBrandField;
        }
        set
        {
            this.productBrandField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=7)]
    public System.Nullable<bool> export
    {
        get
        {
            return this.exportField;
        }
        set
        {
            this.exportField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Order=8)]
    [System.Xml.Serialization.XmlArrayItemAttribute("ProductCategory", Namespace="http://www.promostandards.org/WSDL/ProductDataService/2.0.0/SharedObjects/", IsNullable=false)]
    public ProductCategory[] ProductCategoryArray
    {
        get
        {
            return this.productCategoryArrayField;
        }
        set
        {
            this.productCategoryArrayField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Order=9)]
    [System.Xml.Serialization.XmlArrayItemAttribute("RelatedProduct", Namespace="http://www.promostandards.org/WSDL/ProductDataService/2.0.0/SharedObjects/", IsNullable=false)]
    public RelatedProduct[] RelatedProductArray
    {
        get
        {
            return this.relatedProductArrayField;
        }
        set
        {
            this.relatedProductArrayField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.promostandards.org/WSDL/ProductDataService/2.0.0/SharedObjects/", DataType="token", Order=10)]
    public string primaryImageUrl
    {
        get
        {
            return this.primaryImageUrlField;
        }
        set
        {
            this.primaryImageUrlField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Order=11)]
    [System.Xml.Serialization.XmlArrayItemAttribute("ProductPriceGroup", Namespace="http://www.promostandards.org/WSDL/ProductDataService/2.0.0/SharedObjects/", IsNullable=false)]
    public ProductPriceGroup[] ProductPriceGroupArray
    {
        get
        {
            return this.productPriceGroupArrayField;
        }
        set
        {
            this.productPriceGroupArrayField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.promostandards.org/WSDL/ProductDataService/2.0.0/SharedObjects/", IsNullable=true, Order=12)]
    public System.Nullable<bool> complianceInfoAvailable
    {
        get
        {
            return this.complianceInfoAvailableField;
        }
        set
        {
            this.complianceInfoAvailableField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=13)]
    public int unspscCommodityCode
    {
        get
        {
            return this.unspscCommodityCodeField;
        }
        set
        {
            this.unspscCommodityCodeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool unspscCommodityCodeSpecified
    {
        get
        {
            return this.unspscCommodityCodeFieldSpecified;
        }
        set
        {
            this.unspscCommodityCodeFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Namespace="http://www.promostandards.org/WSDL/ProductDataService/2.0.0/SharedObjects/", Order=14)]
    [System.Xml.Serialization.XmlArrayItemAttribute("LocationDecoration", IsNullable=false)]
    public LocationDecorationArrayLocationDecoration[] LocationDecorationArray
    {
        get
        {
            return this.locationDecorationArrayField;
        }
        set
        {
            this.locationDecorationArrayField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Order=15)]
    [System.Xml.Serialization.XmlArrayItemAttribute("ProductPart", IsNullable=false)]
    public ProductProductPart[] ProductPartArray
    {
        get
        {
            return this.productPartArrayField;
        }
        set
        {
            this.productPartArrayField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=16)]
    public System.DateTime lastChangeDate
    {
        get
        {
            return this.lastChangeDateField;
        }
        set
        {
            this.lastChangeDateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=17)]
    public System.DateTime creationDate
    {
        get
        {
            return this.creationDateField;
        }
        set
        {
            this.creationDateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.promostandards.org/WSDL/ProductDataService/2.0.0/SharedObjects/", IsNullable=true, Order=18)]
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
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.promostandards.org/WSDL/ProductDataService/2.0.0/SharedObjects/", IsNullable=true, Order=19)]
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
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.promostandards.org/WSDL/ProductDataService/2.0.0/SharedObjects/", IsNullable=true, Order=20)]
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
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.promostandards.org/WSDL/ProductDataService/2.0.0/SharedObjects/", DataType="token", Order=21)]
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
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.promostandards.org/WSDL/ProductDataService/2.0.0/SharedObjects/", IsNullable=true, Order=22)]
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
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.promostandards.org/WSDL/ProductDataService/2.0.0/SharedObjects/", DataType="token", Order=23)]
    public string lineName
    {
        get
        {
            return this.lineNameField;
        }
        set
        {
            this.lineNameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.promostandards.org/WSDL/ProductDataService/2.0.0/SharedObjects/", DataType="token", Order=24)]
    public string defaultSetupCharge
    {
        get
        {
            return this.defaultSetupChargeField;
        }
        set
        {
            this.defaultSetupChargeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.promostandards.org/WSDL/ProductDataService/2.0.0/SharedObjects/", DataType="token", Order=25)]
    public string defaultRunCharge
    {
        get
        {
            return this.defaultRunChargeField;
        }
        set
        {
            this.defaultRunChargeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.promostandards.org/WSDL/ProductDataService/2.0.0/SharedObjects/", DataType="token", Order=26)]
    public string imprintSize
    {
        get
        {
            return this.imprintSizeField;
        }
        set
        {
            this.imprintSizeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Namespace="http://www.promostandards.org/WSDL/ProductDataService/2.0.0/SharedObjects/", Order=27)]
    [System.Xml.Serialization.XmlArrayItemAttribute("FobPoint", IsNullable=false)]
    public FobPoint[] FobPointArray
    {
        get
        {
            return this.fobPointArrayField;
        }
        set
        {
            this.fobPointArrayField = value;
        }
    }
}