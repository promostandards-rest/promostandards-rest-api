namespace PromoStandards.REST.Core.Inventory
{
    public class GetFilterValuesRequest
    {
        public string WsVersion { get; set; }
        public string Id { get; set; }
        public string Password { get; set; }
        public string ProductId { get; set; }
    }

    //public class GetFilterValuesRequest
    //    {
    //        // public Models.wsVersion wsVersion { get; set; }
    //        public string wsVersion { get; set; }
    //        /// <summary>
    //        ///  The customer Id or any other agreed upon Id.
    //        /// </summary>        
    //        [MaxLength(64), MinLength(1)]
    //        public string id { get; set; }

    //        [Required]
    //        [MaxLength(64), MinLength(1)]
    //        public string password { get; set; }


    //        [MaxLength(64), MinLength(1)]
    //        public string productId { get; set; }
    //    }


    public class GetFilterValuesResponse
    {
        public GetFilterValuesResponseFilterValues FilterValues { get; set; }
        public ServiceMessage[]? ServiceMessageArray { get; set; }
    }


    public class GetInventoryLevelsRequest
    {
        public WsVersion WsVersion { get; set; }
        public string Id { get; set; }
        public string Password { get; set; }
        public string ProductId { get; set; }
        public Filter Filter { get; set; }
    }

    public class GetInventoryLevelsResponse
    {
        public Inventory Inventory { get; set; }
        public ServiceMessage[] ServiceMessageArray { get; set; }
    }


    public class GetFilterValuesResponseFilterValues
    {
        public string ProductId { get; set; }
        public Filter Filter { get; set; }
    }

    public class Filter
    {
        public string[]? PartIdArray { get; set; }
        public LabelSize[]? LabelSizeArray { get; set; }
        public string[]? PartColorArray { get; set; }
    }

    public enum LabelSize
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


    public class Inventory
    {
        public string ProductId { get; set; }
        public PartInventoryArrayPartInventory[] PartInventoryArray { get; set; }
    }

    public class PartInventoryArrayPartInventory
    {
        public string PartId { get; set; }
        public bool MainPart { get; set; }
        public string PartColor { get; set; }
        public LabelSize LabelSize { get; set; }
        public bool LabelSizeSpecified { get; set; }
        public string PartDescription { get; set; }
        public quantityAvailable QuantityAvailable { get; set; }
        public bool ManufacturedItem { get; set; }
        public bool BuyToOrder { get; set; }
        public int ReplenishmentLeadTime { get; set; }
        public bool ReplenishmentLeadTimeSpecified { get; set; }
        public string AttributeSelection { get; set; }
        public InventoryLocation[] InventoryLocationArray { get; set; }
        public DateTime LastModified { get; set; }
        public bool LastModifiedSpecified { get; set; }
    }

    public class quantityAvailable
    {
        public Quantity Quantity { get; set; }
    }

    public class InventoryLocation
    {
        public string InventoryLocationId { get; set; }

        public string InventoryLocationName { get; set; }

        public string PostalCode { get; set; }
        public NCountry country { get; set; }
        public bool CountrySpecified { get; set; }
        public InventoryLocationQuantity InventoryLocationQuantity { get; set; }
        public FutureAvailability[] FutureAvailabilityArray { get; set; }
    }


    public class InventoryLocationQuantity
    {
        public Quantity Quantity { get; set; }
    }

    public class FutureAvailability
    {
        public Quantity Quantity { get; set; }
        public DateTime AvailableOn { get; set; }

    }


    // Common
    public enum WsVersion
    {
        Item100,
        Item200,
    }


    public class ServiceMessage
    {
        public int Code { get; set; }

        public string Description { get; set; }
        public ServiceMessageSeverity Severity { get; set; }
    }

    public enum ServiceMessageSeverity
    {
        Error,
        Information,
        Warning,
    }

    public class ErrorMessage
    {
        public int code { get; set; }

        public string description { get; set; }

    }

    public class Quantity
    {
        public QuantityUom Uom { get; set; }
        public decimal Value { get; set; }
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

    public enum NCountry
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


    //  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.isotc211.org/iso4217/")]
    public enum NCurrencyCode
    {


        AFA,


        ALL,


        DZD,


        AON,


        ARS,


        AMD,


        AWG,


        AUD,


        ATS,


        AZM,


        BSD,


        BHD,


        BDT,


        BBD,


        BYR,


        BEF,


        BZD,


        BMD,


        BTN,


        BOB,


        BAM,


        BWP,


        BRL,


        BND,


        BGL,


        BIF,


        KHR,


        CAD,


        CVE,


        KYD,


        XOF,


        XAF,


        XPF,


        CLP,


        CNY,


        COP,


        KMF,


        CDF,


        CRC,


        HRK,


        CUP,


        CYP,


        CZK,


        DKK,


        DEM,


        DJF,


        DOP,


        NLG,


        XCD,


        ECS,


        EGP,


        SVC,


        ERN,


        EEK,


        ETB,


        EUR,


        FKP,


        FJD,


        FIM,


        FRF,


        GMD,


        GEL,


        GHC,


        GIP,


        GRD,


        GTQ,


        GYD,


        HTG,


        HNL,


        HKD,


        HUF,


        ISK,


        INR,


        IDR,


        IRR,


        IQD,


        IEP,


        ILS,


        ITL,


        JMD,


        JPY,


        JOD,


        KZT,


        KES,


        KWD,


        KGS,


        LAK,


        LVL,


        LBP,


        LSL,


        LRD,


        LYD,


        LTL,


        LUF,


        MOP,


        MKD,


        MGF,


        MWK,


        MYR,


        MVR,


        MTL,


        MRO,


        MUR,


        MXN,


        MDL,


        MNT,


        MAD,


        MZM,


        MMK,


        NAD,


        NPR,


        ANG,


        ZRN,


        NZD,


        NIC,


        NGN,


        KPW,


        NOK,


        PKR,


        PAB,


        PGK,


        PYG,


        PEN,


        PHP,


        PLN,


        PTE,


        QAR,


        OMR,


        ROL,


        RUR,


        RWF,


        STD,


        SAR,


        SCR,


        SLL,


        SGD,


        SKK,


        SIT,


        SBD,


        SOS,


        ZAR,


        KRW,


        ESP,


        LKR,


        SHP,


        GBP,


        SDP,


        SRG,


        SZL,


        SEK,


        CHF,


        SYP,


        TWD,


        TJR,


        TZS,


        THB,


        TPE,


        TOP,


        TTD,


        TND,


        TRL,


        TMM,


        AED,


        UGX,


        UAH,


        UYU,


        USD,


        UZS,


        VUV,


        VEB,


        VND,


        WST,


        YER,


        YUM,


        ZMK,


        ZWD,
    }



}