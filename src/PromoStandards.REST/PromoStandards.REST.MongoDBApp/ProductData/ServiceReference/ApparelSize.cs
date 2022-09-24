namespace PromoStandards.REST.MongoDBApp.ProductData.ServiceReference;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.promostandards.org/WSDL/ProductDataService/2.0.0/SharedObjects/")]
public partial class ApparelSize
{
    
    private ApparelSizeApparelStyle apparelStyleField;
    
    private ApparelSizeLabelSize labelSizeField;
    
    private string customSizeField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public ApparelSizeApparelStyle apparelStyle
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
    public ApparelSizeLabelSize labelSize
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