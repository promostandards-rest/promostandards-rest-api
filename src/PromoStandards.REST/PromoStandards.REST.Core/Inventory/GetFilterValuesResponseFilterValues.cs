namespace PromoStandards.REST.Core.Inventory;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.33440")]
[Serializable()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.promostandards.org/WSDL/Inventory/2.0.0/")]
public partial class GetFilterValuesResponseFilterValues
{
        
    private string productIdField;
        
    private Filter filterField;
        
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.promostandards.org/WSDL/Inventory/2.0.0/SharedObjects/", Order=0)]
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
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.promostandards.org/WSDL/Inventory/2.0.0/SharedObjects/", Order=1)]
    public Filter Filter
    {
        get
        {
            return this.filterField;
        }
        set
        {
            this.filterField = value;
        }
    }
}