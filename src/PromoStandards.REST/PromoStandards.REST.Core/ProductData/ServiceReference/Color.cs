using System.ComponentModel.DataAnnotations;

namespace PromoStandards.REST.Core.ProductData.ServiceReference;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.promostandards.org/WSDL/ProductDataService/2.0.0/SharedObjects/")]
public partial class Color
{
    
    private string standardColorNameField;
    
    private string hexField;
    
    private string approximatePmsField;
    
    private string colorNameField;

    /// <summary>
    /// Supplier specific color name.  Go to market color
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "token", Order = 1)]
    [Required]
    public string colorName {
        get {
            return this.colorNameField;
        }
        set {
            this.colorNameField = value;
        }
    }

    /// <summary>
    /// The standard color that best describes this color. Eventually may become an enumeration.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=4)]
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

    /// <summary>
    /// The HEX code representation.  This is not a supplement for product color but data used for generating web user interfaces.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=2)]
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

    /// <summary>
    /// The PMS code representation.  This is not a supplement for product color.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=3)]
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
}