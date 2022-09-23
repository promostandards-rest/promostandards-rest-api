using System.ComponentModel.DataAnnotations;

namespace PromoStandards.REST.Core.ProductPricingConfiguration.ServiceReference;

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

    /// <summary>
    /// The Id of the FOB Point
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=0)]
    [Required]
    public string fobId {
        get
        {
            return this.fobIdField;
        }
        set
        {
            this.fobIdField = value;
        }
    }

    /// <summary>
    /// The city of the FOB Point
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    [Required]
    public string fobCity {
        get
        {
            return this.fobCityField;
        }
        set
        {
            this.fobCityField = value;
        }
    }

    /// <summary>
    /// The state of the FOB Point in ISO 3166-2 format.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    [Required]
    public string fobState {
        get
        {
            return this.fobStateField;
        }
        set
        {
            this.fobStateField = value;
        }
    }

    /// <summary>
    /// The Postal or Zip Code of the fob Point
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    [Required]
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

    /// <summary>
    /// The country of the FOB Point in Alpha 2 ISO3166 “CODE” format.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order=4)]
    [Required]
    public string fobCountry {
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