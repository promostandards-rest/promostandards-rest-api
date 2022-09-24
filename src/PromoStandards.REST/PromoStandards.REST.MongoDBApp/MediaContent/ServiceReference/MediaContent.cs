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
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.promostandards.org/WSDL/MediaService/1.0.0/SharedObjects/", DataType="token", Order=0)]
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
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=2)]
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
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.promostandards.org/WSDL/MediaService/1.0.0/SharedObjects/", Order=3)]
    public mediaTypeType mediaType
    {
        get
        {
            return this.mediaTypeField;
        }
        set
        {
            this.mediaTypeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Order=4)]
    [System.Xml.Serialization.XmlArrayItemAttribute("ClassType", IsNullable=false)]
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
    
    /// <remarks/>
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
    
    /// <remarks/>
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
    
    /// <remarks/>
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
    
    /// <remarks/>
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
    
    /// <remarks/>
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
    
    /// <remarks/>
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
    
    /// <remarks/>
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
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=12)]
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
    
    /// <remarks/>
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
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=14)]
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
    
    /// <remarks/>
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