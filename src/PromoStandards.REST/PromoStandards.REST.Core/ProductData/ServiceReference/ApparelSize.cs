using System.ComponentModel.DataAnnotations;

namespace PromoStandards.REST.Core.ProductData.ServiceReference;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.promostandards.org/WSDL/ProductDataService/2.0.0/SharedObjects/")]
public partial class ApparelSize
{
    
    private ApparelSizeApparelStyle apparelStyleField;
    
    private ApparelSizeLabelSize labelSizeField;
    
    private string customSizeField;

    /// <summary>
    /// List of possible values. e.g. Ladies, Men, Youth, etc.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    [Required]
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

    /// <summary>
    /// List of possible values.  The apparel items tagged size. e.g. XS, S, M, XL, etc.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    [Required]
    public ApparelSizeLabelSize labelSize {
        get
        {
            return this.labelSizeField;
        }
        set
        {
            this.labelSizeField = value;
        }
    }

    /// <summary>
    /// Used to communicate custom size when labelSize is CUSTOM.
    /// </summary>
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