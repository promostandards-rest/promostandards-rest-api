﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace PromoStandards.REST.Core.ProductData.ServiceReference;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.promostandards.org/WSDL/ProductDataService/2.0.0/SharedObjects/")]
[JsonConverter(typeof(StringEnumConverter))]
public enum weightUom {
    
    /// <remarks/>
    ME,
    
    /// <remarks/>
    KG,
    
    /// <remarks/>
    OZ,
    
    /// <remarks/>
    LB,
}