namespace PromoStandards.REST.Core.ProductData.ServiceReference;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.promostandards.org/WSDL/ProductDataService/2.0.0/SharedObjects/")]
public class Color
{
    
    private string standardColorNameField;
    
    private string hexField;
    
    private string approximatePmsField;
    
    private string colorNameField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=0)]
    public string standardColorName
    {
        get
        {
            return this.standardColorNameField;
        }
        set
        {
            this.standardColorNameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=1)]
    public string hex
    {
        get
        {
            return this.hexField;
        }
        set
        {
            this.hexField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=2)]
    public string approximatePms
    {
        get
        {
            return this.approximatePmsField;
        }
        set
        {
            this.approximatePmsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=3)]
    public string colorName
    {
        get
        {
            return this.colorNameField;
        }
        set
        {
            this.colorNameField = value;
        }
    }
}