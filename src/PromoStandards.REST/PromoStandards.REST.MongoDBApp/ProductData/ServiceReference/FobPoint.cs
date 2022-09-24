namespace PromoStandards.REST.MongoDBApp.ProductData.ServiceReference;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.promostandards.org/WSDL/ProductDataService/2.0.0/SharedObjects/")]
public partial class FobPoint
{
    
    private string fobIdField;
    
    private string fobCityField;
    
    private string fobStateField;
    
    private string fobPostalCodeField;
    
    private string fobCountryField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=0)]
    public string fobId
    {
        get
        {
            return this.fobIdField;
        }
        set
        {
            this.fobIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public string fobCity
    {
        get
        {
            return this.fobCityField;
        }
        set
        {
            this.fobCityField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public string fobState
    {
        get
        {
            return this.fobStateField;
        }
        set
        {
            this.fobStateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    public string fobPostalCode
    {
        get
        {
            return this.fobPostalCodeField;
        }
        set
        {
            this.fobPostalCodeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=4)]
    public string fobCountry
    {
        get
        {
            return this.fobCountryField;
        }
        set
        {
            this.fobCountryField = value;
        }
    }
}