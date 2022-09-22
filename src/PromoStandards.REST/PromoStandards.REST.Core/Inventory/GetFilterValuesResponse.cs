namespace PromoStandards.REST.Core.Inventory;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.33440")]
[Serializable()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.promostandards.org/WSDL/Inventory/2.0.0/")]
public partial class GetFilterValuesResponse
{
        
    private GetFilterValuesResponseFilterValues filterValuesField;
        
    private ServiceMessage[] serviceMessageArrayField;
        
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public GetFilterValuesResponseFilterValues FilterValues
    {
        get
        {
            return this.filterValuesField;
        }
        set
        {
            this.filterValuesField = value;
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