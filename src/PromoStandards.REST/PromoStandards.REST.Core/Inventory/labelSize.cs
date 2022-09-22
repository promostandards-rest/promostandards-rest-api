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
    Item2XL,
        
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("2XS")]
    [EnumMember(Value = "2XS")]
    Item2XS,
        
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("3XL")]
    [EnumMember(Value = "3XL")]
    Item3XL,
        
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("3XS")]
    [EnumMember(Value = "3XS")]
    Item3XS,
        
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("4XL")]
    [EnumMember(Value = "4XL")]
    Item4XL,
        
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("4XS")]
    [EnumMember(Value = "4XS")]
    Item4XS,
        
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("5XL")]
    [EnumMember(Value = "5XL")]
    Item5XL,
        
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("5XS")]
    [EnumMember(Value = "5XS")]
    Item5XS,
        
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("6XL")]
    [EnumMember(Value = "6XL")]
    Item6XL,
        
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("6XS")]
    [EnumMember(Value = "6XS")]
    Item6XS,
        
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