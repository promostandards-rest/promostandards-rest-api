namespace PromoStandards.REST.Core.MediaContent.ServiceReference;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.promostandards.org/WSDL/MediaService/1.0.0/")]
public partial class GetMediaDateModifiedRequest
{
    
    private string wsVersionField;
    
    private string idField;
    
    private string passwordField;
    
    private string cultureNameField;
    
    private System.DateTime changeTimeStampField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.promostandards.org/WSDL/MediaService/1.0.0/SharedObjects/", DataType="token", Order=0)]
    public string wsVersion
    {
        get
        {
            return this.wsVersionField;
        }
        set
        {
            this.wsVersionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.promostandards.org/WSDL/MediaService/1.0.0/SharedObjects/", DataType="token", Order=1)]
    public string id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.promostandards.org/WSDL/MediaService/1.0.0/SharedObjects/", DataType="token", Order=2)]
    public string password
    {
        get
        {
            return this.passwordField;
        }
        set
        {
            this.passwordField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.promostandards.org/WSDL/MediaService/1.0.0/SharedObjects/", Order=3)]
    public string cultureName
    {
        get
        {
            return this.cultureNameField;
        }
        set
        {
            this.cultureNameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.promostandards.org/WSDL/MediaService/1.0.0/SharedObjects/", Order=4)]
    public System.DateTime changeTimeStamp
    {
        get
        {
            return this.changeTimeStampField;
        }
        set
        {
            this.changeTimeStampField = value;
        }
    }
}