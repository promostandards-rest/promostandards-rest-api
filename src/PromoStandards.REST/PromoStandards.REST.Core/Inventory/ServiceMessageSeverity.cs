﻿using System.Text.Json.Serialization;

namespace PromoStandards.REST.Core.Inventory;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.33440")]
[Serializable()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.promostandards.org/WSDL/Inventory/2.0.0/SharedObjects/")]
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum ServiceMessageSeverity
{
        
    /// <remarks/>
    Error,
        
    /// <remarks/>
    Information,
        
    /// <remarks/>
    Warning,
}