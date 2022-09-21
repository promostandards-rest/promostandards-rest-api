using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace PromoStandards.REST.Core.Inventory;

[JsonConverter(typeof(StringEnumConverter))]
public enum QuantityUom {

    /// <remarks/>
    BX,

    /// <remarks/>
    CA,

    /// <remarks/>
    DZ,

    /// <remarks/>
    EA,

    /// <remarks/>
    KT,

    /// <remarks/>
    PK,

    /// <remarks/>
    PR,

    /// <remarks/>
    RL,

    /// <remarks/>
    SL,

    /// <remarks/>
    ST,

    /// <remarks/>
    TH,
}