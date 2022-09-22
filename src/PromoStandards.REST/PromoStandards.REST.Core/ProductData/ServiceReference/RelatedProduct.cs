using System.ComponentModel.DataAnnotations;

namespace PromoStandards.REST.Core.ProductData.ServiceReference;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.promostandards.org/WSDL/ProductDataService/2.0.0/SharedObjects/")]
public partial class RelatedProduct
{
    
    private RelationType relationTypeField;
    
    private string productIdField;
    
    private string partIdField;

    /// <summary>
    /// The relationship type between two products
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    [Required]
    public RelationType relationType
    {
        get
        {
            return this.relationTypeField;
        }
        set
        {
            this.relationTypeField = value;
        }
    }

    /// <summary>
    /// Product Id
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=1)]
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

    /// <summary>
    /// Part specific Id
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=2)]
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
}