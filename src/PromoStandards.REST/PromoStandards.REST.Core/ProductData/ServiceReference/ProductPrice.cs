using System.ComponentModel.DataAnnotations;

namespace PromoStandards.REST.Core.ProductData.ServiceReference;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.promostandards.org/WSDL/ProductDataService/2.0.0/SharedObjects/")]
public partial class ProductPrice
{
    
    private int quantityMinField;
    
    private int quantityMaxField;
    
    private bool quantityMaxFieldSpecified;
    
    private decimal priceField;
    
    private string discountCodeField;

    /// <summary>
    /// The minimum quantity for which this price applies.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    [Required]
    public int quantityMin
    {
        get
        {
            return this.quantityMinField;
        }
        set
        {
            this.quantityMinField = value;
        }
    }

    /// <summary>
    /// The maximum quantity for which this price applies.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    [Required]
    public int quantityMax
    {
        get
        {
            return this.quantityMaxField;
        }
        set
        {
            this.quantityMaxField = value;
        }
    }

    /// <summary>
    /// The price value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public decimal price
    {
        get
        {
            return this.priceField;
        }
        set
        {
            this.priceField = value;
        }
    }

    /// <summary>
    /// The discount code.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=3)]
    public string discountCode
    {
        get
        {
            return this.discountCodeField;
        }
        set
        {
            this.discountCodeField = value;
        }
    }
}