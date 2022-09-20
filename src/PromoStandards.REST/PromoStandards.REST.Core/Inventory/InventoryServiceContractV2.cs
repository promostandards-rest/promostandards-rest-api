using System.ComponentModel.DataAnnotations;
/// <summary>
/// Issues:
/// 1. Authentication
/// 2. C#, ENum, for example Item200
/// </summary>
namespace PromoStandards.REST.Core.Inventory
{
    public class GetFilterValuesRequest
    {
        public wsVersion wsVersion { get; set; }

        /// <summary>
        ///  The customer Id or any other agreed upon Id.
        /// </summary>        
        [MaxLength(64), MinLength(1)]
        public string id { get; set; }

        [Required]
        [MaxLength(64), MinLength(1)]
        public string password { get; set; }


        [MaxLength(64), MinLength(1)]
        public string productId { get; set; }
    }

    public enum wsVersion
    {
        Item100,
        Item200,
    }

    public class GetFilterValuesResponse
    {
        public GetFilterValuesResponseFilterValues FilterValues { get; set; }
        public ServiceMessage[] ServiceMessageArray { get; set; }
    }

    public class GetFilterValuesResponseFilterValues
    {
        public string productId { get; set; }
        public Filter Filter { get; set; }
    }

    public class Filter
    {
        public string[] partIdArray { get; set; }
        public labelSize[] LabelSizeArray { get; set; }
        public string[] PartColorArray { get; set; }
    }

    public enum labelSize
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnum("2XL")]
        Item2XL,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnum("2XS")]
        Item2XS,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnum("3XL")]
        Item3XL,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnum("3XS")]
        Item3XS,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnum("4XL")]
        Item4XL,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnum("4XS")]
        Item4XS,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnum("5XL")]
        Item5XL,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnum("5XS")]
        Item5XS,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnum("6XL")]
        Item6XL,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnum("6XS")]
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

    public class ServiceMessage
    {
        public int code { get; set; }

        public string description { get; set; }
        public ServiceMessageSeverity severity { get; set; }
    }

    public enum ServiceMessageSeverity
    {
        Error,
        Information,
        Warning,
    }


    public class getFilterValuesRequest1
    {
        public GetFilterValuesRequest GetFilterValuesRequest;

        public getFilterValuesRequest1()
        {
        }

        public getFilterValuesRequest1(GetFilterValuesRequest GetFilterValuesRequest)
        {
            this.GetFilterValuesRequest = GetFilterValuesRequest;
        }
    }

    public partial class getFilterValuesResponse1
    {
        public GetFilterValuesResponse GetFilterValuesResponse;
        public getFilterValuesResponse1()
        {
        }

        public getFilterValuesResponse1(GetFilterValuesResponse GetFilterValuesResponse)
        {
            this.GetFilterValuesResponse = GetFilterValuesResponse;
        }
    }

    public class GetInventoryLevelsRequest
    {
        public wsVersion wsVersion { get; set; }
        public string id { get; set; }
        public string password { get; set; }
        public string productId { get; set; }
        public Filter Filter { get; set; }
    }

    public class GetInventoryLevelsResponse
    {
        public Inventory Inventory { get; set; }
        public ServiceMessage[] ServiceMessageArray { get; set; }
    }

    public class Inventory
    {
        public string productId { get; set; }
        public PartInventoryArrayPartInventory[] PartInventoryArray { get; set; }
    }

    public class PartInventoryArrayPartInventory
    {
        public string partId { get; set; }
        public bool mainPart { get; set; }
        public string partColor { get; set; }
        public labelSize labelSize { get; set; }
        public bool labelSizeSpecified { get; set; }
        public string partDescription { get; set; }
        public quantityAvailable quantityAvailable { get; set; }
        public bool manufacturedItem { get; set; }
        public bool buyToOrder { get; set; }
        public int replenishmentLeadTime { get; set; }
        public bool replenishmentLeadTimeSpecified { get; set; }
        public string attributeSelection { get; set; }
        public InventoryLocation[] InventoryLocationArray { get; set; }
        public DateTime lastModified { get; set; }
        public bool lastModifiedSpecified { get; set; }
    }

    public class quantityAvailable
    {
        public Quantity Quantity { get; set; }
    }
    public class Quantity
    {
        public QuantityUom uom { get; set; }
        public decimal value { get; set; }
    }

    public enum QuantityUom
    {

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

    public class InventoryLocation
    {
        public string inventoryLocationId { get; set; }

        public string inventoryLocationName { get; set; }

        public string postalCode { get; set; }
        public InventoryLocationCountry country { get; set; }
        public bool countrySpecified { get; set; }
        public inventoryLocationQuantity inventoryLocationQuantity { get; set; }
        public FutureAvailability[] FutureAvailabilityArray { get; set; }
    }

    public enum InventoryLocationCountry
    {

        /// <remarks/>
        AF,

        /// <remarks/>
        AX,

        /// <remarks/>
        AL,

        /// <remarks/>
        DZ,

        /// <remarks/>
        AS,

        /// <remarks/>
        AD,

        /// <remarks/>
        AO,

        /// <remarks/>
        AI,

        /// <remarks/>
        AQ,

        /// <remarks/>
        AG,

        /// <remarks/>
        AR,

        /// <remarks/>
        AM,

        /// <remarks/>
        AW,

        /// <remarks/>
        AU,

        /// <remarks/>
        AT,

        /// <remarks/>
        AZ,

        /// <remarks/>
        BS,

        /// <remarks/>
        BH,

        /// <remarks/>
        BD,

        /// <remarks/>
        BB,

        /// <remarks/>
        BY,

        /// <remarks/>
        BE,

        /// <remarks/>
        BZ,

        /// <remarks/>
        BJ,

        /// <remarks/>
        BM,

        /// <remarks/>
        BT,

        /// <remarks/>
        BO,

        /// <remarks/>
        BA,

        /// <remarks/>
        BW,

        /// <remarks/>
        BV,

        /// <remarks/>
        BR,

        /// <remarks/>
        IO,

        /// <remarks/>
        BN,

        /// <remarks/>
        BG,

        /// <remarks/>
        BF,

        /// <remarks/>
        BI,

        /// <remarks/>
        KH,

        /// <remarks/>
        CM,

        /// <remarks/>
        CA,

        /// <remarks/>
        CV,

        /// <remarks/>
        KY,

        /// <remarks/>
        CF,

        /// <remarks/>
        TD,

        /// <remarks/>
        CL,

        /// <remarks/>
        CN,

        /// <remarks/>
        CX,

        /// <remarks/>
        CC,

        /// <remarks/>
        CO,

        /// <remarks/>
        KM,

        /// <remarks/>
        CG,

        /// <remarks/>
        CD,

        /// <remarks/>
        CK,

        /// <remarks/>
        CR,

        /// <remarks/>
        CI,

        /// <remarks/>
        HR,

        /// <remarks/>
        CU,

        /// <remarks/>
        CY,

        /// <remarks/>
        CZ,

        /// <remarks/>
        DK,

        /// <remarks/>
        DJ,

        /// <remarks/>
        DM,

        /// <remarks/>
        DO,

        /// <remarks/>
        EC,

        /// <remarks/>
        EG,

        /// <remarks/>
        SV,

        /// <remarks/>
        GQ,

        /// <remarks/>
        ER,

        /// <remarks/>
        EE,

        /// <remarks/>
        ET,

        /// <remarks/>
        FK,

        /// <remarks/>
        FO,

        /// <remarks/>
        FJ,

        /// <remarks/>
        FI,

        /// <remarks/>
        FR,

        /// <remarks/>
        GF,

        /// <remarks/>
        PF,

        /// <remarks/>
        TF,

        /// <remarks/>
        GA,

        /// <remarks/>
        GM,

        /// <remarks/>
        GE,

        /// <remarks/>
        DE,

        /// <remarks/>
        GH,

        /// <remarks/>
        GI,

        /// <remarks/>
        GR,

        /// <remarks/>
        GL,

        /// <remarks/>
        GD,

        /// <remarks/>
        GP,

        /// <remarks/>
        GU,

        /// <remarks/>
        GT,

        /// <remarks/>
        GG,

        /// <remarks/>
        GN,

        /// <remarks/>
        GW,

        /// <remarks/>
        GY,

        /// <remarks/>
        HT,

        /// <remarks/>
        HM,

        /// <remarks/>
        VA,

        /// <remarks/>
        HN,

        /// <remarks/>
        HK,

        /// <remarks/>
        HU,

        /// <remarks/>
        IS,

        /// <remarks/>
        IN,

        /// <remarks/>
        ID,

        /// <remarks/>
        IR,

        /// <remarks/>
        IQ,

        /// <remarks/>
        IE,

        /// <remarks/>
        IM,

        /// <remarks/>
        IL,

        /// <remarks/>
        IT,

        /// <remarks/>
        JM,

        /// <remarks/>
        JP,

        /// <remarks/>
        JE,

        /// <remarks/>
        JO,

        /// <remarks/>
        KZ,

        /// <remarks/>
        KE,

        /// <remarks/>
        KI,

        /// <remarks/>
        KP,

        /// <remarks/>
        KR,

        /// <remarks/>
        KW,

        /// <remarks/>
        KG,

        /// <remarks/>
        LA,

        /// <remarks/>
        LV,

        /// <remarks/>
        LB,

        /// <remarks/>
        LS,

        /// <remarks/>
        LR,

        /// <remarks/>
        LY,

        /// <remarks/>
        LI,

        /// <remarks/>
        LT,

        /// <remarks/>
        LU,

        /// <remarks/>
        MO,

        /// <remarks/>
        MK,

        /// <remarks/>
        MG,

        /// <remarks/>
        MW,

        /// <remarks/>
        MY,

        /// <remarks/>
        MV,

        /// <remarks/>
        ML,

        /// <remarks/>
        MT,

        /// <remarks/>
        MH,

        /// <remarks/>
        MQ,

        /// <remarks/>
        MR,

        /// <remarks/>
        MU,

        /// <remarks/>
        YT,

        /// <remarks/>
        MX,

        /// <remarks/>
        FM,

        /// <remarks/>
        MD,

        /// <remarks/>
        MC,

        /// <remarks/>
        MN,

        /// <remarks/>
        MS,

        /// <remarks/>
        MA,

        /// <remarks/>
        MZ,

        /// <remarks/>
        MM,

        /// <remarks/>
        NA,

        /// <remarks/>
        NR,

        /// <remarks/>
        NP,

        /// <remarks/>
        NL,

        /// <remarks/>
        AN,

        /// <remarks/>
        NC,

        /// <remarks/>
        NZ,

        /// <remarks/>
        NI,

        /// <remarks/>
        NE,

        /// <remarks/>
        NG,

        /// <remarks/>
        NU,

        /// <remarks/>
        NF,

        /// <remarks/>
        MP,

        /// <remarks/>
        NO,

        /// <remarks/>
        OM,

        /// <remarks/>
        PK,

        /// <remarks/>
        PW,

        /// <remarks/>
        PS,

        /// <remarks/>
        PA,

        /// <remarks/>
        PG,

        /// <remarks/>
        PY,

        /// <remarks/>
        PE,

        /// <remarks/>
        PH,

        /// <remarks/>
        PN,

        /// <remarks/>
        PL,

        /// <remarks/>
        PT,

        /// <remarks/>
        PR,

        /// <remarks/>
        QA,

        /// <remarks/>
        RE,

        /// <remarks/>
        RO,

        /// <remarks/>
        RU,

        /// <remarks/>
        RW,

        /// <remarks/>
        SH,

        /// <remarks/>
        KN,

        /// <remarks/>
        LC,

        /// <remarks/>
        PM,

        /// <remarks/>
        VC,

        /// <remarks/>
        WS,

        /// <remarks/>
        SM,

        /// <remarks/>
        ST,

        /// <remarks/>
        SA,

        /// <remarks/>
        SN,

        /// <remarks/>
        CS,

        /// <remarks/>
        SC,

        /// <remarks/>
        SL,

        /// <remarks/>
        SG,

        /// <remarks/>
        SK,

        /// <remarks/>
        SI,

        /// <remarks/>
        SB,

        /// <remarks/>
        SO,

        /// <remarks/>
        ZA,

        /// <remarks/>
        GS,

        /// <remarks/>
        ES,

        /// <remarks/>
        LK,

        /// <remarks/>
        SD,

        /// <remarks/>
        SR,

        /// <remarks/>
        SJ,

        /// <remarks/>
        SZ,

        /// <remarks/>
        SE,

        /// <remarks/>
        CH,

        /// <remarks/>
        SY,

        /// <remarks/>
        TW,

        /// <remarks/>
        TJ,

        /// <remarks/>
        TZ,

        /// <remarks/>
        TH,

        /// <remarks/>
        TL,

        /// <remarks/>
        TG,

        /// <remarks/>
        TK,

        /// <remarks/>
        TO,

        /// <remarks/>
        TT,

        /// <remarks/>
        TN,

        /// <remarks/>
        TR,

        /// <remarks/>
        TM,

        /// <remarks/>
        TC,

        /// <remarks/>
        TV,

        /// <remarks/>
        UG,

        /// <remarks/>
        UA,

        /// <remarks/>
        AE,

        /// <remarks/>
        GB,

        /// <remarks/>
        US,

        /// <remarks/>
        UM,

        /// <remarks/>
        UY,

        /// <remarks/>
        UZ,

        /// <remarks/>
        VU,

        /// <remarks/>
        VE,

        /// <remarks/>
        VN,

        /// <remarks/>
        VG,

        /// <remarks/>
        VI,

        /// <remarks/>
        WF,

        /// <remarks/>
        EH,

        /// <remarks/>
        YE,

        /// <remarks/>
        ZM,

        /// <remarks/>
        ZW,
    }

    public class inventoryLocationQuantity
    {
        public Quantity Quantity { get; set; }
    }

    public class FutureAvailability
    {

        public Quantity Quantity { get; set; }
        public DateTime availableOn { get; set; }

    }

    public class getInventoryLevelsRequest1
    {
        public GetInventoryLevelsRequest GetInventoryLevelsRequest;
        public getInventoryLevelsRequest1()
        {
        }
        public getInventoryLevelsRequest1(GetInventoryLevelsRequest GetInventoryLevelsRequest)
        {
            this.GetInventoryLevelsRequest = GetInventoryLevelsRequest;
        }
    }

    public partial class getInventoryLevelsResponse1
    {
        public GetInventoryLevelsResponse GetInventoryLevelsResponse;

        public getInventoryLevelsResponse1()
        {
        }

        public getInventoryLevelsResponse1(GetInventoryLevelsResponse GetInventoryLevelsResponse)
        {
            this.GetInventoryLevelsResponse = GetInventoryLevelsResponse;
        }
    }

}
