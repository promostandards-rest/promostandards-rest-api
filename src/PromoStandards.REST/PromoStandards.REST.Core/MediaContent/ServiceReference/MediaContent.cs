using System.ComponentModel.DataAnnotations;

namespace PromoStandards.REST.Core.MediaContent.ServiceReference;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.promostandards.org/WSDL/MediaService/1.0.0/")]
public partial class MediaContent
{
    
    private string productIdField;
    
    private string partIdField;
    
    private string urlField;
    
    private mediaTypeType mediaTypeField;
    
    private ClassType[] classTypeArrayField;
    
    private double fileSizeField;
    
    private bool fileSizeFieldSpecified;
    
    private decimal widthField;
    
    private bool widthFieldSpecified;
    
    private decimal heightField;
    
    private bool heightFieldSpecified;
    
    private int dpiField;
    
    private bool dpiFieldSpecified;
    
    private string colorField;
    
    private Decoration[] decorationArrayField;
    
    private Location[] locationArrayField;
    
    private int decorationIdField;
    
    private bool decorationIdFieldSpecified;
    
    private string descriptionField;
    
    private bool singlePartField;
    
    private System.DateTime changeTimeStampField;
    
    private bool changeTimeStampFieldSpecified;

    /// <summary>
    /// The associated Product Id
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.promostandards.org/WSDL/MediaService/1.0.0/SharedObjects/", DataType="token", Order=0)]
    [Required]
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

    /// <summary>
    /// The part Id associated to the product Id.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.promostandards.org/WSDL/MediaService/1.0.0/SharedObjects/", DataType="token", Order=1)]
    public string partId
    {
        get
        {
            return this.partIdField;
        }
        set
        {
            this.partIdField = value;
        }
    }

    /// <summary>
    /// The URL of the media location.  Any valid URL can be returned including prefixes like http and ftp.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=2)]
    [Required]
    public string url
    {
        get
        {
            return this.urlField;
        }
        set
        {
            this.urlField = value;
        }
    }
    
    /// <summary>
    /// The type of media
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.promostandards.org/WSDL/MediaService/1.0.0/SharedObjects/", Order=3)]
    [Required]
    public mediaTypeType mediaType {
        get
        {
            return this.mediaTypeField;
        }
        set
        {
            this.mediaTypeField = value;
        }
    }

    /// <summary>
    /// An array of ClassType objects that classify of the media
    /// </summary>
    [System.Xml.Serialization.XmlArrayAttribute(Order=4)]
    [System.Xml.Serialization.XmlArrayItemAttribute("ClassType", IsNullable=false)]
    [Required]
    public ClassType[] ClassTypeArray
    {
        get
        {
            return this.classTypeArrayField;
        }
        set
        {
            this.classTypeArrayField = value;
        }
    }
    
    /// <summary>
    /// The file size
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order=5)]
    public double fileSize
    {
        get
        {
            return this.fileSizeField;
        }
        set
        {
            this.fileSizeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool fileSizeSpecified
    {
        get
        {
            return this.fileSizeFieldSpecified;
        }
        set
        {
            this.fileSizeFieldSpecified = value;
        }
    }
    
    /// <summary>
    /// Width
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order=6)]
    public decimal width
    {
        get
        {
            return this.widthField;
        }
        set
        {
            this.widthField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool widthSpecified
    {
        get
        {
            return this.widthFieldSpecified;
        }
        set
        {
            this.widthFieldSpecified = value;
        }
    }
    
    /// <summary>
    /// Height
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order=7)]
    public decimal height
    {
        get
        {
            return this.heightField;
        }
        set
        {
            this.heightField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool heightSpecified
    {
        get
        {
            return this.heightFieldSpecified;
        }
        set
        {
            this.heightFieldSpecified = value;
        }
    }

    /// <summary>
    /// Dots per inch
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order=8)]
    public int dpi
    {
        get
        {
            return this.dpiField;
        }
        set
        {
            this.dpiField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool dpiSpecified
    {
        get
        {
            return this.dpiFieldSpecified;
        }
        set
        {
            this.dpiFieldSpecified = value;
        }
    }
    
    /// <summary>
    /// The color description
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=9)]
    public string color
    {
        get
        {
            return this.colorField;
        }
        set
        {
            this.colorField = value;
        }
    }

    /// <summary>
    /// An array of decoration objects that describe the decorations associated with the media
    /// </summary>
    [System.Xml.Serialization.XmlArrayAttribute(Order=10)]
    [System.Xml.Serialization.XmlArrayItemAttribute("Decoration", IsNullable=false)]
    public Decoration[] DecorationArray
    {
        get
        {
            return this.decorationArrayField;
        }
        set
        {
            this.decorationArrayField = value;
        }
    }

    /// <summary>
    /// An array of location objects that describe the locations associated with the media
    /// </summary>
    [System.Xml.Serialization.XmlArrayAttribute(Order=11)]
    [System.Xml.Serialization.XmlArrayItemAttribute("Location", IsNullable=false)]
    public Location[] LocationArray
    {
        get
        {
            return this.locationArrayField;
        }
        set
        {
            this.locationArrayField = value;
        }
    }

    /// <summary>
    /// The decoration id associated with the media
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order=12)]
    [Required]
    public int decorationId
    {
        get
        {
            return this.decorationIdField;
        }
        set
        {
            this.decorationIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool decorationIdSpecified
    {
        get
        {
            return this.decorationIdFieldSpecified;
        }
        set
        {
            this.decorationIdFieldSpecified = value;
        }
    }

    /// <summary>
    /// Information about the media
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=13)]
    public string description
    {
        get
        {
            return this.descriptionField;
        }
        set
        {
            this.descriptionField = value;
        }
    }

    /// <summary>
    /// Identifies whether the partId one to one corresponds with the image.  (Use FALSE for group shots)
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order=14)]
    [Required]
    public bool singlePart
    {
        get
        {
            return this.singlePartField;
        }
        set
        {
            this.singlePartField = value;
        }
    }

    /// <summary>
    /// The date time since last change in UTC
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.promostandards.org/WSDL/MediaService/1.0.0/SharedObjects/", Order=15)]
    public System.DateTime changeTimeStamp
    {
        get
        {
            return this.changeTimeStampField;
        }
        set
        {
            this.changeTimeStampField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool changeTimeStampSpecified
    {
        get
        {
            return this.changeTimeStampFieldSpecified;
        }
        set
        {
            this.changeTimeStampFieldSpecified = value;
        }
    }
}