using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.promostandards.org/WSDL/ProductDataService/2.0.0/SharedObjects/")]
[JsonConverter(typeof(StringEnumConverter))]
public enum SpecificationType {

    /// <remarks/>
    Length,
    
    /// <remarks/>
    Thickness,
    
    /// <remarks/>
    Radius,
    
    /// <remarks/>
    Volume,
    
    /// <remarks/>
    Capacity,
    
    /// <remarks/>
    Memory,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("Data Ports")]
    DataPorts,
    
    /// <remarks/>
    Capacitance,
    
    /// <remarks/>
    Voltage,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("Point Size")]
    PointSize,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("Sheet Size")]
    SheetSize,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("Sheet Count")]
    SheetCount,
    
    /// <remarks/>
    Pockets,
    
    /// <remarks/>
    Inseam,
    
    /// <remarks/>
    Bust,
    
    /// <remarks/>
    Chest,
    
    /// <remarks/>
    Waist,
    
    /// <remarks/>
    Hips,
    
    /// <remarks/>
    Cup,
    
    /// <remarks/>
    Rise,
    
    /// <remarks/>
    Neck,
    
    /// <remarks/>
    Thigh,
    
    /// <remarks/>
    Shoulders,
    
    /// <remarks/>
    Sleeve,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("Device Size")]
    DeviceSize,
}