﻿using Newtonsoft.Json;
using Swashbuckle.AspNetCore.Annotations;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using JsonIgnoreAttribute = System.Text.Json.Serialization.JsonIgnoreAttribute;

namespace PromoStandards.REST.Core.Inventory {

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.promostandards.org/WSDL/Inventory/2.0.0/", ConfigurationName = "InventoryService")]
    public interface InventoryService {

        // CODEGEN: Generating message contract since the operation getFilterValues is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action = "getFilterValues")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        getFilterValuesResponse1 getFilterValues(getFilterValuesRequest1 request);

        // CODEGEN: Generating message contract since the operation getInventoryLevels is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action = "getInventoryLevels")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        getInventoryLevelsResponse1 getInventoryLevels(getInventoryLevelsRequest1 request);
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.promostandards.org/WSDL/Inventory/2.0.0/")]
    public partial class GetFilterValuesRequest {

        private wsVersion wsVersionField;

        private string idField;

        private string passwordField;

        private string productIdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.promostandards.org/WSDL/Inventory/2.0.0/SharedObjects/", Order = 0)]
        public wsVersion wsVersion {
            get {
                return this.wsVersionField;
            }
            set {
                this.wsVersionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.promostandards.org/WSDL/Inventory/2.0.0/SharedObjects/", Order = 1)]
        public string id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.promostandards.org/WSDL/Inventory/2.0.0/SharedObjects/", Order = 2)]
        public string password {
            get {
                return this.passwordField;
            }
            set {
                this.passwordField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.promostandards.org/WSDL/Inventory/2.0.0/SharedObjects/", Order = 3)]
        public string productId {
            get {
                return this.productIdField;
            }
            set {
                this.productIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.promostandards.org/WSDL/Inventory/2.0.0/SharedObjects/")]
    public enum wsVersion {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2.0.0")]
        Item200,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.promostandards.org/WSDL/Inventory/2.0.0/")]
    public partial class GetFilterValuesResponse {

        private GetFilterValuesResponseFilterValues filterValuesField;

        private ServiceMessage[] serviceMessageArrayField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public GetFilterValuesResponseFilterValues FilterValues {
            get {
                return this.filterValuesField;
            }
            set {
                this.filterValuesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Namespace = "http://www.promostandards.org/WSDL/Inventory/2.0.0/SharedObjects/", Order = 1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("ServiceMessage", IsNullable = false)]
        public ServiceMessage[] ServiceMessageArray {
            get {
                return this.serviceMessageArrayField;
            }
            set {
                this.serviceMessageArrayField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.promostandards.org/WSDL/Inventory/2.0.0/")]
    public partial class GetFilterValuesResponseFilterValues {

        private string productIdField;

        private Filter filterField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.promostandards.org/WSDL/Inventory/2.0.0/SharedObjects/", Order = 0)]
        public string productId {
            get {
                return this.productIdField;
            }
            set {
                this.productIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.promostandards.org/WSDL/Inventory/2.0.0/SharedObjects/", Order = 1)]
        public Filter Filter {
            get {
                return this.filterField;
            }
            set {
                this.filterField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.promostandards.org/WSDL/Inventory/2.0.0/SharedObjects/")]
    public partial class Filter {

        private string[] partIdArrayField;

        private labelSize[] labelSizeArrayField;

        private string[] partColorArrayField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("partId", IsNullable = false)]
        public string[] partIdArray {
            get {
                return this.partIdArrayField;
            }
            set {
                this.partIdArrayField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 1)]
        public labelSize[] LabelSizeArray {
            get {
                return this.labelSizeArrayField;
            }
            set {
                this.labelSizeArrayField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 2)]
        [System.Xml.Serialization.XmlArrayItemAttribute("partColor", IsNullable = false)]
        public string[] PartColorArray {
            get {
                return this.partColorArrayField;
            }
            set {
                this.partColorArrayField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.promostandards.org/WSDL/Inventory/2.0.0/SharedObjects/")]
    public enum labelSize {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2XL")]
        Item2XL,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2XS")]
        Item2XS,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3XL")]
        Item3XL,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3XS")]
        Item3XS,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4XL")]
        Item4XL,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4XS")]
        Item4XS,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5XL")]
        Item5XL,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5XS")]
        Item5XS,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6XL")]
        Item6XL,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6XS")]
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

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.promostandards.org/WSDL/Inventory/2.0.0/SharedObjects/")]
    public partial class ServiceMessage {

        private int codeField;

        private string descriptionField;

        private ServiceMessageSeverity severityField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public int code {
            get {
                return this.codeField;
            }
            set {
                this.codeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "token", Order = 1)]
        public string description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public ServiceMessageSeverity severity {
            get {
                return this.severityField;
            }
            set {
                this.severityField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.promostandards.org/WSDL/Inventory/2.0.0/SharedObjects/")]
    public enum ServiceMessageSeverity {

        /// <remarks/>
        Error,

        /// <remarks/>
        Information,

        /// <remarks/>
        Warning,
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    public partial class getFilterValuesRequest1 {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://www.promostandards.org/WSDL/Inventory/2.0.0/", Order = 0)]
        public GetFilterValuesRequest GetFilterValuesRequest;

        public getFilterValuesRequest1() {
        }

        public getFilterValuesRequest1(GetFilterValuesRequest GetFilterValuesRequest) {
            this.GetFilterValuesRequest = GetFilterValuesRequest;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    public partial class getFilterValuesResponse1 {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://www.promostandards.org/WSDL/Inventory/2.0.0/", Order = 0)]
        public GetFilterValuesResponse GetFilterValuesResponse;

        public getFilterValuesResponse1() {
        }

        public getFilterValuesResponse1(GetFilterValuesResponse GetFilterValuesResponse) {
            this.GetFilterValuesResponse = GetFilterValuesResponse;
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.promostandards.org/WSDL/Inventory/2.0.0/")]
    public partial class GetInventoryLevelsRequest {

        private wsVersion wsVersionField;

        private string idField;

        private string passwordField;

        private string productIdField;

        private Filter filterField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.promostandards.org/WSDL/Inventory/2.0.0/SharedObjects/", Order = 0)]
        public wsVersion wsVersion {
            get {
                return this.wsVersionField;
            }
            set {
                this.wsVersionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.promostandards.org/WSDL/Inventory/2.0.0/SharedObjects/", Order = 1)]
        public string id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.promostandards.org/WSDL/Inventory/2.0.0/SharedObjects/", Order = 2)]
        public string password {
            get {
                return this.passwordField;
            }
            set {
                this.passwordField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.promostandards.org/WSDL/Inventory/2.0.0/SharedObjects/", Order = 3)]
        public string productId {
            get {
                return this.productIdField;
            }
            set {
                this.productIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.promostandards.org/WSDL/Inventory/2.0.0/SharedObjects/", Order = 4)]
        public Filter Filter {
            get {
                return this.filterField;
            }
            set {
                this.filterField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.promostandards.org/WSDL/Inventory/2.0.0/")]
    public partial class GetInventoryLevelsResponse {

        private Inventory inventoryField;

        private ServiceMessage[] serviceMessageArrayField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.promostandards.org/WSDL/Inventory/2.0.0/SharedObjects/", Order = 0)]
        public Inventory Inventory {
            get {
                return this.inventoryField;
            }
            set {
                this.inventoryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Namespace = "http://www.promostandards.org/WSDL/Inventory/2.0.0/SharedObjects/", Order = 1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("ServiceMessage", IsNullable = false)]
        public ServiceMessage[] ServiceMessageArray {
            get {
                return this.serviceMessageArrayField;
            }
            set {
                this.serviceMessageArrayField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.promostandards.org/WSDL/Inventory/2.0.0/SharedObjects/")]
    public partial class Inventory {

        private string productIdField;

        private PartInventoryArrayPartInventory[] partInventoryArrayField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string productId {
            get {
                return this.productIdField;
            }
            set {
                this.productIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("PartInventory", IsNullable = false)]
        public PartInventoryArrayPartInventory[] PartInventoryArray {
            get {
                return this.partInventoryArrayField;
            }
            set {
                this.partInventoryArrayField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.promostandards.org/WSDL/Inventory/2.0.0/SharedObjects/")]
    public partial class PartInventoryArrayPartInventory {

        private string partIdField;

        private bool mainPartField;

        private string partColorField;

        private labelSize labelSizeField;

        private bool labelSizeFieldSpecified;

        private string partDescriptionField;

        private quantityAvailable quantityAvailableField;

        private bool manufacturedItemField;

        private bool buyToOrderField;

        private int replenishmentLeadTimeField;

        private bool replenishmentLeadTimeFieldSpecified;

        private string attributeSelectionField;

        private InventoryLocation[] inventoryLocationArrayField;

        private System.DateTime lastModifiedField;

        private bool lastModifiedFieldSpecified;
        /// <summary>
        /// The part id
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        [Required]
        [SwaggerSchema(Title = "Part ID")]
        public string partId {
            get {
                return this.partIdField;
            }
            set {
                this.partIdField = value;
            }
        }

        /// <summary>
        /// A boolean value indicating if this is a main part of the product. In a tumbler with an optional lid configuration, the parts associated with the tumbler would be set to TRUE. The parts associated with the Lid would be set to false.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        [Required]
        [SwaggerSchema(Title = "Main Part")]
        public bool mainPart {
            get {
                return this.mainPartField;
            }
            set {
                this.mainPartField = value;
            }
        }

        /// <summary>
        /// Description of the color of the part
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        [SwaggerSchema(Title = "Color")]
        public string partColor {
            get {
                return this.partColorField;
            }
            set {
                this.partColorField = value;
            }
        }

        /// <summary>
        /// The apparel items tagged size.  Enumerated values: {6XS,5XS,4XS,3XS,2XS,XS,S,M,L,XL,2XL,3XL,4XL,5XL,6XL,CUSTOM} CUSTOM is used for any size that does not match one of the other sizes.For example 7XL and 8XL would return CUSTOM.To identify the actual size when CUSTOM is returned, reference the Product Data endpoint.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        [SwaggerSchema(Title = "Size")]
        public labelSize labelSize {
            get {
                return this.labelSizeField;
            }
            set {
                this.labelSizeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [JsonIgnore]
        public bool labelSizeSpecified {
            get {
                return this.labelSizeFieldSpecified;
            }
            set {
                this.labelSizeFieldSpecified = value;
            }
        }

        /// <summary>
        /// Description of the part
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        [SwaggerSchema(Title = "Part Description")]
        public string partDescription {
            get {
                return this.partDescriptionField;
            }
            set {
                this.partDescriptionField = value;
            }
        }

        /// <summary>
        /// A quantity object containing the sum of inventory of all inventory locations of the part
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        [SwaggerSchema(Title = "Quantity Available")]
        public quantityAvailable quantityAvailable {
            get {
                return this.quantityAvailableField;
            }
            set {
                this.quantityAvailableField = value;
            }
        }

        /// <summary>
        /// Indicates that the supplier produces this part according to demand. The supplier may keep a limited amount of inventory or inventory may be 0.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        [SwaggerSchema(Title = "Manufactured Item")]
        public bool manufacturedItem {
            get {
                return this.manufacturedItemField;
            }
            set {
                this.manufacturedItemField = value;
            }
        }

        /// <summary>
        /// Indicates that the supplier purchases this product to order. The supplier may keep a limited amount of inventory, show available inventory to buy, or it might be 0.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        [SwaggerSchema(Title = "Buy To Order")]
        [Required]
        public bool buyToOrder {
            get {
                return this.buyToOrderField;
            }
            set {
                this.buyToOrderField = value;
            }
        }

        /// <summary>
        /// Time to replenish buy to order or made to order
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        [SwaggerSchema(Title = "Replenishment Lead Time")]
        public int replenishmentLeadTime {
            get {
                return this.replenishmentLeadTimeField;
            }
            set {
                this.replenishmentLeadTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [JsonIgnore]
        public bool replenishmentLeadTimeSpecified {
            get {
                return this.replenishmentLeadTimeFieldSpecified;
            }
            set {
                this.replenishmentLeadTimeFieldSpecified = value;
            }
        }

        /// <summary>
        /// A string describing the attribute of the product other than size and color
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        [SwaggerSchema(Title = "Attribute Selection")]
        public string attributeSelection {
            get {
                return this.attributeSelectionField;
            }
            set {
                this.attributeSelectionField = value;
            }
        }

        /// <summary>
        /// An array of InventoryLocation objects
        /// </summary>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 10)]
        [System.Xml.Serialization.XmlArrayItemAttribute("InventoryLocation", IsNullable = false)]
        [SwaggerSchema(Title = "Inventory Locations")]
        public InventoryLocation[] InventoryLocationArray {
            get {
                return this.inventoryLocationArrayField;
            }
            set {
                this.inventoryLocationArrayField = value;
            }
        }

        /// <summary>
        /// A date timestamp in UTC specifying the last time inventory was modified.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
        [SwaggerSchema(Title = "Last Modified Date")]
        public System.DateTime lastModified {
            get {
                return this.lastModifiedField;
            }
            set {
                this.lastModifiedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [JsonIgnore]
        public bool lastModifiedSpecified {
            get {
                return this.lastModifiedFieldSpecified;
            }
            set {
                this.lastModifiedFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.promostandards.org/WSDL/Inventory/2.0.0/SharedObjects/")]
    public partial class quantityAvailable {

        private Quantity quantityField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public Quantity Quantity {
            get {
                return this.quantityField;
            }
            set {
                this.quantityField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.promostandards.org/WSDL/Inventory/2.0.0/SharedObjects/")]
    public partial class Quantity {

        private QuantityUom uomField;

        private decimal valueField;

        /// <summary>
        /// Unit of measure
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        [Required]
        public QuantityUom uom {
            get {
                return this.uomField;
            }
            set {
                this.uomField = value;
            }
        }

        /// <summary>
        /// The unit of measure; values are enumerated. Values are: {BX, CA, DZ, EA, KT, PR, PK, RL, ST, SL, TH } 
        /// BX - Box
        /// CA - Case
        /// DZ - Dozen
        /// EA - Each
        /// KT - Kit
        /// PR - Pair
        /// PK - Package
        /// RL - Roll
        /// ST - Set
        /// SL - Sleeve
        /// TH – Thousand
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        [Required]
        public decimal value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.promostandards.org/WSDL/Inventory/2.0.0/SharedObjects/")]
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

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.promostandards.org/WSDL/Inventory/2.0.0/SharedObjects/")]
    public partial class InventoryLocation {

        private string inventoryLocationIdField;

        private string inventoryLocationNameField;

        private string postalCodeField;

        private InventoryLocationCountry countryField;

        private bool countryFieldSpecified;

        private inventoryLocationQuantity inventoryLocationQuantityField;

        private FutureAvailability[] futureAvailabilityArrayField;

        /// <summary>
        /// The inventory location id
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        [Required]
        public string inventoryLocationId {
            get {
                return this.inventoryLocationIdField;
            }
            set {
                this.inventoryLocationIdField = value;
            }
        }

        /// <summary>
        /// The name of the inventory location
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string inventoryLocationName {
            get {
                return this.inventoryLocationNameField;
            }
            set {
                this.inventoryLocationNameField = value;
            }
        }

        /// <summary>
        /// The postal code
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        [Required]
        public string postalCode {
            get {
                return this.postalCodeField;
            }
            set {
                this.postalCodeField = value;
            }
        }

        /// <summary>
        /// The country in ISO 3166-2 format
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        [Required]
        public InventoryLocationCountry country {
            get {
                return this.countryField;
            }
            set {
                this.countryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [JsonIgnore]
        public bool countrySpecified {
            get {
                return this.countryFieldSpecified;
            }
            set {
                this.countryFieldSpecified = value;
            }
        }

        /// <summary>
        /// An object which contains available to order quantity for this inventory location
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public inventoryLocationQuantity inventoryLocationQuantity {
            get {
                return this.inventoryLocationQuantityField;
            }
            set {
                this.inventoryLocationQuantityField = value;
            }
        }

        /// <summary>
        /// Array of FutureAvailability objects
        /// </summary>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 5)]
        [System.Xml.Serialization.XmlArrayItemAttribute("FutureAvailability", IsNullable = false)]
        public FutureAvailability[] FutureAvailabilityArray {
            get {
                return this.futureAvailabilityArrayField;
            }
            set {
                this.futureAvailabilityArrayField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.codesynthesis.com/xmlns/xsstl")]
    public enum InventoryLocationCountry {

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

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.promostandards.org/WSDL/Inventory/2.0.0/SharedObjects/")]
    public partial class inventoryLocationQuantity {

        private Quantity quantityField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public Quantity Quantity {
            get {
                return this.quantityField;
            }
            set {
                this.quantityField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.promostandards.org/WSDL/Inventory/2.0.0/SharedObjects/")]
    public partial class FutureAvailability {

        private Quantity quantityField;

        private System.DateTime availableOnField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public Quantity Quantity {
            get {
                return this.quantityField;
            }
            set {
                this.quantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public System.DateTime availableOn {
            get {
                return this.availableOnField;
            }
            set {
                this.availableOnField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    public partial class getInventoryLevelsRequest1 {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://www.promostandards.org/WSDL/Inventory/2.0.0/", Order = 0)]
        public GetInventoryLevelsRequest GetInventoryLevelsRequest;

        public getInventoryLevelsRequest1() {
        }

        public getInventoryLevelsRequest1(GetInventoryLevelsRequest GetInventoryLevelsRequest) {
            this.GetInventoryLevelsRequest = GetInventoryLevelsRequest;
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    public partial class getInventoryLevelsResponse1 {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://www.promostandards.org/WSDL/Inventory/2.0.0/", Order = 0)]
        public GetInventoryLevelsResponse GetInventoryLevelsResponse;

        public getInventoryLevelsResponse1() {
        }

        public getInventoryLevelsResponse1(GetInventoryLevelsResponse GetInventoryLevelsResponse) {
            this.GetInventoryLevelsResponse = GetInventoryLevelsResponse;
        }
    }
}
