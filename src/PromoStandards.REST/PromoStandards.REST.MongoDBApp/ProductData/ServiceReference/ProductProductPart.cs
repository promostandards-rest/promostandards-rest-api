/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.promostandards.org/WSDL/ProductDataService/2.0.0/")]
public partial class ProductProductPart
{
    
    private string partIdField;
    
    private ProductProductPartPrimaryColor primaryColorField;
    
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
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.promostandards.org/WSDL/ProductDataService/2.0.0/SharedObjects/", DataType="token", Order=0)]
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
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public ProductProductPartPrimaryColor primaryColor
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
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool countryOfOriginSpecified
    {
        get
        {
            return this.countryOfOriginFieldSpecified;
        }
        set
        {
            this.countryOfOriginFieldSpecified = value;
        }
    }
    
    /// <remarks/>
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
    
    /// <remarks/>
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
    
    /// <remarks/>
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
    
    /// <remarks/>
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
    
    /// <remarks/>
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
    
    /// <remarks/>
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
    
    /// <remarks/>
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
    
    /// <remarks/>
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
    
    /// <remarks/>
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
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.promostandards.org/WSDL/ProductDataService/2.0.0/SharedObjects/", IsNullable=true, Order=13)]
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
    
    /// <remarks/>
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
    
    /// <remarks/>
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
    
    /// <remarks/>
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
    
    /// <remarks/>
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
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.promostandards.org/WSDL/ProductDataService/2.0.0/SharedObjects/", IsNullable=true, Order=18)]
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
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.promostandards.org/WSDL/ProductDataService/2.0.0/SharedObjects/", IsNullable=true, Order=19)]
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
    
    /// <remarks/>
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
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool nmfcCodeSpecified
    {
        get
        {
            return this.nmfcCodeFieldSpecified;
        }
        set
        {
            this.nmfcCodeFieldSpecified = value;
        }
    }
    
    /// <remarks/>
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
    
    /// <remarks/>
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
    
    /// <remarks/>
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
    
    /// <remarks/>
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