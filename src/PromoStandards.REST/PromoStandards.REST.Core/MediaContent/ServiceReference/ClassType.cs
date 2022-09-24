using System.ComponentModel.DataAnnotations;

namespace PromoStandards.REST.Core.MediaContent.ServiceReference;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.promostandards.org/WSDL/MediaService/1.0.0/")]
public partial class ClassType
{
    
    private int classTypeIdField;
    
    private string classTypeNameField;

    /// <summary>
    /// The classification of the media
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    [Required]
    public int classTypeId {
        get
        {
            return this.classTypeIdField;
        }
        set
        {
            this.classTypeIdField = value;
        }
    }

    /// <summary>
    /// The classification short name
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=1)]
    [Required]
    public string classTypeName
    {
        get
        {
            return this.classTypeNameField;
        }
        set
        {
            this.classTypeNameField = value;
        }
    }
}