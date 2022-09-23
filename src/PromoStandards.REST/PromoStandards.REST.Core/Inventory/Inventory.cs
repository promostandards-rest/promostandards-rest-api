namespace PromoStandards.REST.Core.Inventory;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.33440")]
[Serializable()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.promostandards.org/WSDL/Inventory/2.0.0/SharedObjects/")]
public partial class Inventory
{
    public string productId { get; set; }
    public PartInventory[] PartInventoryArray { get; set; }
}