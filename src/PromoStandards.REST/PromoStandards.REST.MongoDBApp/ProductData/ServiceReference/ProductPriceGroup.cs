namespace PromoStandards.REST.MongoDBApp.ProductData.ServiceReference;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.promostandards.org/WSDL/ProductDataService/2.0.0/SharedObjects/")]
public partial class ProductPriceGroup
{
    
    private ProductPrice[] productPriceArrayField;
    
    private string groupNameField;
    
    private CurrencyCodeType currencyField;
    
    private string descriptionField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Order=0)]
    [System.Xml.Serialization.XmlArrayItemAttribute("ProductPrice", IsNullable=false)]
    public ProductPrice[] ProductPriceArray
    {
        get
        {
            return this.productPriceArrayField;
        }
        set
        {
            this.productPriceArrayField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=1)]
    public string groupName
    {
        get
        {
            return this.groupNameField;
        }
        set
        {
            this.groupNameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public CurrencyCodeType currency
    {
        get
        {
            return this.currencyField;
        }
        set
        {
            this.currencyField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=3)]
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
}