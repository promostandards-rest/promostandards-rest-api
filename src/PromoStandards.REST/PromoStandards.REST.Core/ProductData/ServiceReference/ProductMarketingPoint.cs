/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.promostandards.org/WSDL/ProductDataService/2.0.0/SharedObjects/")]
public partial class ProductMarketingPoint
{
    
    private string pointTypeField;
    
    private string pointCopyField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=0)]
    public string pointType
    {
        get
        {
            return this.pointTypeField;
        }
        set
        {
            this.pointTypeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=1)]
    public string pointCopy
    {
        get
        {
            return this.pointCopyField;
        }
        set
        {
            this.pointCopyField = value;
        }
    }
}