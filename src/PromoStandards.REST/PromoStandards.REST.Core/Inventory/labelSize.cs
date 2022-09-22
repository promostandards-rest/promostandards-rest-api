using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace PromoStandards.REST.Core.Inventory;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.33440")]
[Serializable()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.promostandards.org/WSDL/Inventory/2.0.0/SharedObjects/")]
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum labelSize
{
        
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("2XL")]
    [EnumMember(Value = "2XL")]
    _2XL,
        
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("2XS")]
    [EnumMember(Value = "2XS")]
    _2XS,
        
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("3XL")]
    [EnumMember(Value = "3XL")]
    _3XL,
        
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("3XS")]
    [EnumMember(Value = "3XS")]
    _3XS,
        
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("4XL")]
    [EnumMember(Value = "4XL")]
    _4XL,
        
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("4XS")]
    [EnumMember(Value = "4XS")]
    _4XS,
        
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("5XL")]
    [EnumMember(Value = "5XL")]
    _5XL,
        
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("5XS")]
    [EnumMember(Value = "5XS")]
    _5XS,
        
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("6XL")]
    [EnumMember(Value = "6XL")]
    _6XL,
        
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("6XS")]
    [EnumMember(Value = "6XS")]
    _6XS,
        
    /// <remarks/>
    CUSTOM,
        
    /// <remarks/>
    L,
        
    /// <remarks/>
    M,
        
    /// <remarks/>
    OSFA,
        
    /// <remarks/>
    S,
        
    /// <remarks/>
    XL,
        
    /// <remarks/>
    XS,
}