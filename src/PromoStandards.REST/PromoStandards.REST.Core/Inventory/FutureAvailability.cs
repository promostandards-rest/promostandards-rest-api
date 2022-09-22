using System.ComponentModel.DataAnnotations;

namespace PromoStandards.REST.Core.Inventory;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.33440")]
[Serializable()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.promostandards.org/WSDL/Inventory/2.0.0/SharedObjects/")]
public partial class FutureAvailability
{
        
    private Quantity quantityField;
        
    private System.DateTime availableOnField;

    /// <summary>
    /// Future net available inventory quantity for the part/inventory location combination indicating goods on order or future quantity at manufactured goods. 
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    [Required]
    public Quantity Quantity
    {
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
    /// A date timestamp in UTC specifying the valid timestamp depicting when the inventory will be available for allocation to sales orders.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    [Required]
    public System.DateTime availableOn {
        get
        {
            return this.availableOnField;
        }
        set
        {
            this.availableOnField = value;
        }
    }
}