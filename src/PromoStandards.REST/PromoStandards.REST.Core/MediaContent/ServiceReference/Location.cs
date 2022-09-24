using System.ComponentModel.DataAnnotations;

namespace PromoStandards.REST.Core.MediaContent.ServiceReference;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.promostandards.org/WSDL/MediaService/1.0.0/")]
public partial class Location
{
    
    private int locationIdField;
    
    private string locationNameField;

    /// <summary>
    /// The location id associated with the media
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    [Required]
    public int locationId
    {
        get
        {
            return this.locationIdField;
        }
        set
        {
            this.locationIdField = value;
        }
    }

    /// <summary>
    /// The name of the location associated with the id
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=1)]
    [Required]
    public string locationName {
        get
        {
            return this.locationNameField;
        }
        set
        {
            this.locationNameField = value;
        }
    }
}