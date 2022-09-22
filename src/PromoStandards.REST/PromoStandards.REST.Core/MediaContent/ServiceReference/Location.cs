namespace PromoStandards.REST.Core.MediaContent.ServiceReference;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.promostandards.org/WSDL/MediaService/1.0.0/")]
public partial class Location
{
    
    private int locationIdField;
    
    private string locationNameField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public int locationId
    {
        get
        {
            return this.locationIdField;
        }
        set
        {
            this.locationIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=1)]
    public string locationName
    {
        get
        {
            return this.locationNameField;
        }
        set
        {
            this.locationNameField = value;
        }
    }
}