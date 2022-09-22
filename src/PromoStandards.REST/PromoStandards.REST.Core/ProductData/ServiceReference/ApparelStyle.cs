using System.Text.Json.Serialization;

namespace PromoStandards.REST.Core.ProductData.ServiceReference;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.promostandards.org/WSDL/ProductDataService/2.0.0/SharedObjects/")]
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum ApparelStyle {

    /// <remarks/>
    Unisex,
    
    /// <remarks/>
    Youth,
    
    /// <remarks/>
    Girls,
    
    /// <remarks/>
    Boys,
    
    /// <remarks/>
    Womens,
    
    /// <remarks/>
    WomensTall,
    
    /// <remarks/>
    Mens,
    
    /// <remarks/>
    MensTall,
}