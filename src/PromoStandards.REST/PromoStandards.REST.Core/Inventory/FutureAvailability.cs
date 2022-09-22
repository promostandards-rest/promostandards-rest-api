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
        
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
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
        
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public System.DateTime availableOn
    {
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