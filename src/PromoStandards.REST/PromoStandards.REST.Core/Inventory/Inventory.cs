namespace PromoStandards.REST.Core.Inventory;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.33440")]
[Serializable()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.promostandards.org/WSDL/Inventory/2.0.0/SharedObjects/")]
public partial class Inventory
{
        
    private string productIdField;
        
    private PartInventoryArrayPartInventory[] partInventoryArrayField;
        
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
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
    [System.Xml.Serialization.XmlArrayAttribute(Order=1)]
    [System.Xml.Serialization.XmlArrayItemAttribute("PartInventory", IsNullable=false)]
    public PartInventoryArrayPartInventory[] PartInventoryArray
    {
        get
        {
            return this.partInventoryArrayField;
        }
        set
        {
            this.partInventoryArrayField = value;
        }
    }
}