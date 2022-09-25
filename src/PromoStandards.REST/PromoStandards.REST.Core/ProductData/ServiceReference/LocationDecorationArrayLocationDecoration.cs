using System.ComponentModel.DataAnnotations;

namespace PromoStandards.REST.Core.ProductData.ServiceReference;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.promostandards.org/WSDL/ProductDataService/2.0.0/SharedObjects/")]
public partial class LocationDecorationArrayLocationDecoration
{
    
    private string locationNameField;
    
    private int maxImprintColorsField;
    
    private bool maxImprintColorsFieldSpecified;
    
    private string decorationNameField;
    
    private bool locationDecorationComboDefaultField;
    
    private bool priceIncludesField;

    /// <summary>
    /// Location name
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=0)]
    [Required]
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

    /// <summary>
    /// The maximum number of imprint colors available, based on a decoration location and type.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
    public int maxImprintColors {
        get {
            return this.maxImprintColorsField;
        }
        set {
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


    /// <summary>
    /// Decoration name
    /// </summary>
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

    /// <summary>
    /// Is this the default location
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    [Required]
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

    /// <summary>
    /// Does this include price
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order=4)]
    [Required]
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