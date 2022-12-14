/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.promostandards.org/WSDL/MediaService/1.0.0/")]
public partial class GetMediaDateModifiedResponse
{
    
    private MediaDateModified[] mediaDateModifiedArrayField;
    
    private errorMessage errorMessageField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Order=0)]
    [System.Xml.Serialization.XmlArrayItemAttribute("MediaDateModified", IsNullable=false)]
    public MediaDateModified[] MediaDateModifiedArray
    {
        get
        {
            return this.mediaDateModifiedArrayField;
        }
        set
        {
            this.mediaDateModifiedArrayField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.promostandards.org/WSDL/MediaService/1.0.0/SharedObjects/", Order=1)]
    public errorMessage errorMessage
    {
        get
        {
            return this.errorMessageField;
        }
        set
        {
            this.errorMessageField = value;
        }
    }
}