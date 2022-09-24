/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.promostandards.org/WSDL/MediaService/1.0.0/SharedObjects/")]
public partial class errorMessage
{
    
    private int codeField;
    
    private string descriptionField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public int code
    {
        get
        {
            return this.codeField;
        }
        set
        {
            this.codeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=1)]
    public string description
    {
        get
        {
            return this.descriptionField;
        }
        set
        {
            this.descriptionField = value;
        }
    }
}