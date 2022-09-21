/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.promostandards.org/WSDL/ProductDataService/2.0.0/SharedObjects/")]
public partial class ApparelSize
{
    
    private ApparelStyle apparelStyleField;
    
    private LabelSize labelSizeField;
    
    private string customSizeField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public ApparelStyle apparelStyle
    {
        get
        {
            return this.apparelStyleField;
        }
        set
        {
            this.apparelStyleField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public LabelSize labelSize
    {
        get
        {
            return this.labelSizeField;
        }
        set
        {
            this.labelSizeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=2)]
    public string customSize
    {
        get
        {
            return this.customSizeField;
        }
        set
        {
            this.customSizeField = value;
        }
    }
}