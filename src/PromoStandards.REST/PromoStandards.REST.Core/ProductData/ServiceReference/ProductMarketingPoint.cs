﻿using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace PromoStandards.REST.Core.ProductData.ServiceReference;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.promostandards.org/WSDL/ProductDataService/2.0.0/SharedObjects/")]
public partial class ProductMarketingPoint
{
    
    private string pointTypeField;
    
    private string pointCopyField;

    /// <summary>
    /// Basic category or type of marketing point being made.e.g.Highlights, Size, Safety
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=0)]
    public string pointType
    {
        get
        {
            return this.pointTypeField;
        }
        set
        {
            this.pointTypeField = value;
        }
    }

    /// <summary>
    /// Marketing bullet or point copy
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=1)]
    [Required]
    public string pointCopy {
        get
        {
            return this.pointCopyField;
        }
        set
        {
            this.pointCopyField = value;
        }
    }
}