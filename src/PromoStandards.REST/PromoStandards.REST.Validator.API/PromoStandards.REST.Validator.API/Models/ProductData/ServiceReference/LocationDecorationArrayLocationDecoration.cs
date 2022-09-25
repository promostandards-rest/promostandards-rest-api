namespace PromoStandards.REST.Core.ProductData.ServiceReference;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.promostandards.org/WSDL/ProductDataService/2.0.0/SharedObjects/")]
public class LocationDecorationArrayLocationDecoration
{
    
    private string locationNameField;
    
    private int maxImprintColorsField;
    
    private bool maxImprintColorsFieldSpecified;
    
    private string decorationNameField;
    
    private bool locationDecorationComboDefaultField;
    
    private bool priceIncludesField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=0)]
    public string locationName
    {
        get
        {
            return this.locationNameField;
        }
        set
        {
            this.locationNameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public int maxImprintColors
    {
        get
        {
            return this.maxImprintColorsField;
        }
        set
        {
            this.maxImprintColorsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool maxImprintColorsSpecified
    {
        get
        {
            return this.maxImprintColorsFieldSpecified;
        }
        set
        {
            this.maxImprintColorsFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=2)]
    public string decorationName
    {
        get
        {
            return this.decorationNameField;
        }
        set
        {
            this.decorationNameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    public bool locationDecorationComboDefault
    {
        get
        {
            return this.locationDecorationComboDefaultField;
        }
        set
        {
            this.locationDecorationComboDefaultField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=4)]
    public bool priceIncludes
    {
        get
        {
            return this.priceIncludesField;
        }
        set
        {
            this.priceIncludesField = value;
        }
    }
}