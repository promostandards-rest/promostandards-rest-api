﻿using System.ComponentModel.DataAnnotations;

namespace PromoStandards.REST.Core.MediaContent.ServiceReference;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.promostandards.org/WSDL/MediaService/1.0.0/")]
public partial class Decoration
{
    
    private int decorationIdField;
    
    private string decorationNameField;

    /// <summary>
    /// The decoration id associated with the media
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
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

    /// <summary>
    /// The name of the decoration associated with the id
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=1)]
    [Required]
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
}