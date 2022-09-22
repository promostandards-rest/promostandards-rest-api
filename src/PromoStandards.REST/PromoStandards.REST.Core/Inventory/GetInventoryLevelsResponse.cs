namespace PromoStandards.REST.Core.Inventory;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.33440")]
[Serializable()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.promostandards.org/WSDL/Inventory/2.0.0/")]
public partial class GetInventoryLevelsResponse
{
        
    private Inventory inventoryField;
        
    private ServiceMessage[] serviceMessageArrayField;
        
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.promostandards.org/WSDL/Inventory/2.0.0/SharedObjects/", Order=0)]
    public Inventory Inventory
    {
        get
        {
            return this.inventoryField;
        }
        set
        {
            this.inventoryField = value;
        }
    }
        
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Namespace="http://www.promostandards.org/WSDL/Inventory/2.0.0/SharedObjects/", Order=1)]
    [System.Xml.Serialization.XmlArrayItemAttribute("ServiceMessage", IsNullable=false)]
    public ServiceMessage[] ServiceMessageArray
    {
        get
        {
            return this.serviceMessageArrayField;
        }
        set
        {
            this.serviceMessageArrayField = value;
        }
    }
}