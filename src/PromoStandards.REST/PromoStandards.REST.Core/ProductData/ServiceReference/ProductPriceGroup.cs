using System.ComponentModel.DataAnnotations;

namespace PromoStandards.REST.Core.ProductData.ServiceReference;

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

    /// <summary>
    /// An array of Product Price objects
    /// </summary>
    [System.Xml.Serialization.XmlArrayAttribute(Order=0)]
    [System.Xml.Serialization.XmlArrayItemAttribute("ProductPrice", IsNullable=false)]
    [Required]
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

    /// <summary>
    /// Price group description
    /// </summary>
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

    /// <summary>
    /// The currency supported in ISO4217 format.
    /// </summary>
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

    /// <summary>
    /// The description of the product price
    /// </summary>
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