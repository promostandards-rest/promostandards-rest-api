namespace PromoStandards.REST.MongoDBApp.Inventory.ServiceReference;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
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