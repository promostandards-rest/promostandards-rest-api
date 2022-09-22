using System.ComponentModel.DataAnnotations;

namespace PromoStandards.REST.Core.ProductData.ServiceReference;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.promostandards.org/WSDL/ProductDataService/2.0.0/SharedObjects/")]
public partial class ProductCategory
{
    
    private string categoryField;
    
    private string subCategoryField;

    /// <summary>
    /// Product category
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=0)]
    [Required]
    public string category
    {
        get
        {
            return this.categoryField;
        }
        set
        {
            this.categoryField = value;
        }
    }

    /// <summary>
    /// Product subcategory
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=1)]
    [Required]
    public string subCategory
    {
        get
        {
            return this.subCategoryField;
        }
        set
        {
            this.subCategoryField = value;
        }
    }
}