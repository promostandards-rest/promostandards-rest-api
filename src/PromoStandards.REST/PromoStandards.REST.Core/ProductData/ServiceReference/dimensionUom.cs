using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.promostandards.org/WSDL/ProductDataService/2.0.0/SharedObjects/")]
[JsonConverter(typeof(StringEnumConverter))]
public enum dimensionUom
{
    
    /// <remarks/>
    MM,
    
    /// <remarks/>
    CM,
    
    /// <remarks/>
    MR,
    
    /// <remarks/>
    IN,
    
    /// <remarks/>
    FT,
    
    /// <remarks/>
    YD,
}