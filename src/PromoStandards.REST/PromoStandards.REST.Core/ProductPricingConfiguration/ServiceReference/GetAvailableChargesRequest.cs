namespace PromoStandards.REST.Core.ProductPricingConfiguration.ServiceReference;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.promostandards.org/WSDL/PricingAndConfiguration/1.0.0/")]
public partial class GetAvailableChargesRequest
{
    
    private string wsVersionField;
    
    private string idField;
    
    private string passwordField;
    
    private string productIdField;
    
    private string localizationCountryField;
    
    private string localizationLanguageField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.promostandards.org/WSDL/PricingAndConfiguration/1.0.0/SharedObjects/", DataType="token", Order=0)]
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
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.promostandards.org/WSDL/PricingAndConfiguration/1.0.0/SharedObjects/", DataType="token", Order=1)]
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
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.promostandards.org/WSDL/PricingAndConfiguration/1.0.0/SharedObjects/", DataType="token", Order=2)]
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
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.promostandards.org/WSDL/PricingAndConfiguration/1.0.0/SharedObjects/", DataType="token", Order=3)]
    public string productId
    {
        get
        {
            return this.productIdField;
        }
        set
        {
            this.productIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.promostandards.org/WSDL/PricingAndConfiguration/1.0.0/SharedObjects/", Order=4)]
    public string localizationCountry
    {
        get
        {
            return this.localizationCountryField;
        }
        set
        {
            this.localizationCountryField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.promostandards.org/WSDL/PricingAndConfiguration/1.0.0/SharedObjects/", Order=5)]
    public string localizationLanguage
    {
        get
        {
            return this.localizationLanguageField;
        }
        set
        {
            this.localizationLanguageField = value;
        }
    }
}