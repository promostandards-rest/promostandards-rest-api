using PromoStandards.REST.Core.ProductData.ServiceReference;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Security.Cryptography.Xml;
using System.Security.Policy;

namespace PromoStandards.REST.Core.Inventory;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.33440")]
[Serializable()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.promostandards.org/WSDL/Inventory/2.0.0/SharedObjects/")]
public partial class PartInventory
{
        
    private string partIdField;
        
    private bool mainPartField;
        
    private string partColorField;
        
    private labelSize labelSizeField;
        
    private bool labelSizeFieldSpecified;
        
    private string partDescriptionField;
        
    private Quantity quantityAvailableField;
        
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
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    [Required]
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

    /// <summary>
    /// A boolean value indicating if this is a main part of the product. In a tumbler with an optional lid configuration, the parts associated with the tumbler would be set to TRUE. The parts associated with the Lid would be set to false.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    [Required]
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

    /// <summary>
    /// Description of the color of the part
    /// </summary>
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
        
    /// <summary>
    /// The apparel items tagged size.  Enumerated values: {6XS,5XS,4XS,3XS,2XS,XS,S,M,L,XL,2XL,3XL,4XL,5XL,6XL,CUSTOM} CUSTOM is used for any size that does not match one of the other sizes.For example 7XL and 8XL would return CUSTOM.To identify the actual size when CUSTOM is returned, reference the Product Data endpoint.
    /// </summary>
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

    /// <summary>
    /// Description of the part
    /// </summary>
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

    /// <summary>
    /// A quantity object containing the sum of inventory of all inventory locations of the part
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order=5)]
    public Quantity quantityAvailable
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

    /// <summary>
    /// Indicates that the supplier produces this part according to demand. The supplier may keep a limited amount of inventory or inventory may be 0.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order=6)]
    [Required]
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

    /// <summary>
    /// Indicates that the supplier purchases this product to order. The supplier may keep a limited amount of inventory, show available inventory to buy, or it might be 0.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order=7)]
    [Required]
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

    /// <summary>
    /// Time to replenish buy to order or made to order
    /// </summary>
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

    /// <summary>
    /// A string describing the attribute of the product other than size and color
    /// </summary>
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

    /// <summary>
    /// An array of InventoryLocation objects
    /// </summary>
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

    /// <summary>
    /// A date timestamp in UTC specifying the last time inventory was modified.
    /// </summary>
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
}