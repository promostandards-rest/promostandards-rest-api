using System.ComponentModel;
using System.Text.Json.Serialization;

namespace PromoStandards.REST.Core.ProductData.ServiceReference;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.promostandards.org/WSDL/ProductDataService/2.0.0/SharedObjects/")]
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum LabelSize {
    
    /// <remarks/>
    OSFA,
    
    [System.Xml.Serialization.XmlEnumAttribute("6XS")]
    _6XS,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("5XS")]
    _5XS,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("4XS")]
    _4XS,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("3XS")]
    _3XS,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("2XS")]
    _2XS,
    
    /// <remarks/>
    XS,
    
    /// <remarks/>
    S,
    
    /// <remarks/>
    M,
    
    /// <remarks/>
    L,
    
    /// <remarks/>
    XL,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("2XL")]
    _2XL,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("3XL")]
    _3XL,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("4XL")]
    _4XL,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("5XL")]
    _5XL,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("6XL")]
    _6XL,
    
    /// <remarks/>
    CUSTOM,
}