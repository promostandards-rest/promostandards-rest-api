namespace PromoStandards.REST.Core.Inventory;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.33440")]
[Serializable()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.promostandards.org/WSDL/Inventory/2.0.0/SharedObjects/")]
public partial class Quantity
{
        
    private QuantityUom uomField;
        
    private decimal valueField;
        
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public QuantityUom uom
    {
        get
        {
            return this.uomField;
        }
        set
        {
            this.uomField = value;
        }
    }
        
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public decimal value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}