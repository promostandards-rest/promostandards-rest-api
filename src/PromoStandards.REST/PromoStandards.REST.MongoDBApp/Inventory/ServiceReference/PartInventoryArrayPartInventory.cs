namespace PromoStandards.REST.MongoDBApp.Inventory.ServiceReference;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.promostandards.org/WSDL/Inventory/2.0.0/SharedObjects/")]
public partial class PartInventoryArrayPartInventory
{
    
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
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public string partId
    {
        get
        {
            return this.partIdField;
        }
        set
        {
            this.partIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public bool mainPart
    {
        get
        {
            return this.mainPartField;
        }
        set
        {
            this.mainPartField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public string partColor
    {
        get
        {
            return this.partColorField;
        }
        set
        {
            this.partColorField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    public labelSize labelSize
    {
        get
        {
            return this.labelSizeField;
        }
        set
        {
            this.labelSizeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool labelSizeSpecified
    {
        get
        {
            return this.labelSizeFieldSpecified;
        }
        set
        {
            this.labelSizeFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=4)]
    public string partDescription
    {
        get
        {
            return this.partDescriptionField;
        }
        set
        {
            this.partDescriptionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=5)]
    public quantityAvailable quantityAvailable
    {
        get
        {
            return this.quantityAvailableField;
        }
        set
        {
            this.quantityAvailableField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=6)]
    public bool manufacturedItem
    {
        get
        {
            return this.manufacturedItemField;
        }
        set
        {
            this.manufacturedItemField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=7)]
    public bool buyToOrder
    {
        get
        {
            return this.buyToOrderField;
        }
        set
        {
            this.buyToOrderField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=8)]
    public int replenishmentLeadTime
    {
        get
        {
            return this.replenishmentLeadTimeField;
        }
        set
        {
            this.replenishmentLeadTimeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool replenishmentLeadTimeSpecified
    {
        get
        {
            return this.replenishmentLeadTimeFieldSpecified;
        }
        set
        {
            this.replenishmentLeadTimeFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=9)]
    public string attributeSelection
    {
        get
        {
            return this.attributeSelectionField;
        }
        set
        {
            this.attributeSelectionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Order=10)]
    [System.Xml.Serialization.XmlArrayItemAttribute("InventoryLocation", IsNullable=false)]
    public InventoryLocation[] InventoryLocationArray
    {
        get
        {
            return this.inventoryLocationArrayField;
        }
        set
        {
            this.inventoryLocationArrayField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=11)]
    public System.DateTime lastModified
    {
        get
        {
            return this.lastModifiedField;
        }
        set
        {
            this.lastModifiedField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool lastModifiedSpecified
    {
        get
        {
            return this.lastModifiedFieldSpecified;
        }
        set
        {
            this.lastModifiedFieldSpecified = value;
        }
    }
}