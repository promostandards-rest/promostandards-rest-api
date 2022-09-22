namespace PromoStandards.REST.Core.MediaContent.ServiceReference;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.promostandards.org/WSDL/MediaService/1.0.0/")]
public partial class ClassType
{
    
    private int classTypeIdField;
    
    private string classTypeNameField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public int classTypeId
    {
        get
        {
            return this.classTypeIdField;
        }
        set
        {
            this.classTypeIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=1)]
    public string classTypeName
    {
        get
        {
            return this.classTypeNameField;
        }
        set
        {
            this.classTypeNameField = value;
        }
    }
}