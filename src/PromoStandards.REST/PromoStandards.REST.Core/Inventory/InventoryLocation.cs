using System.ComponentModel.DataAnnotations;

namespace PromoStandards.REST.Core.Inventory;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.33440")]
[Serializable()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.promostandards.org/WSDL/Inventory/2.0.0/SharedObjects/")]
public partial class InventoryLocation
{
        
    private string inventoryLocationIdField;
        
    private string inventoryLocationNameField;
        
    private string postalCodeField;
        
    private InventoryLocationCountry countryField;
        
    private bool countryFieldSpecified;
        
    private Quantity inventoryLocationQuantityField;
        
    private FutureAvailability[] futureAvailabilityArrayField;

    /// <summary>
    /// The inventory location id
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    [Required]
    public string inventoryLocationId {
        get
        {
            return this.inventoryLocationIdField;
        }
        set
        {
            this.inventoryLocationIdField = value;
        }
    }

    /// <summary>
    /// The name of the inventory location
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public string inventoryLocationName
    {
        get
        {
            return this.inventoryLocationNameField;
        }
        set
        {
            this.inventoryLocationNameField = value;
        }
    }

    /// <summary>
    /// The postal code
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    [Required]
    public string postalCode {
        get
        {
            return this.postalCodeField;
        }
        set
        {
            this.postalCodeField = value;
        }
    }

    /// <summary>
    /// The country in ISO 3166-2 format
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    [Required]
    public InventoryLocationCountry country {
        get
        {
            return this.countryField;
        }
        set
        {
            this.countryField = value;
        }
    }
        
    /// <summary>
    /// An object which contains available to order quantity for this inventory location
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order=4)]
    public Quantity inventoryLocationQuantity
    {
        get
        {
            return this.inventoryLocationQuantityField;
        }
        set
        {
            this.inventoryLocationQuantityField = value;
        }
    }

    /// <summary>
    /// Array of FutureAvailability objects
    /// </summary>
    [System.Xml.Serialization.XmlArrayAttribute(Order=5)]
    [System.Xml.Serialization.XmlArrayItemAttribute("FutureAvailability", IsNullable=false)]
    public FutureAvailability[] FutureAvailabilityArray
    {
        get
        {
            return this.futureAvailabilityArrayField;
        }
        set
        {
            this.futureAvailabilityArrayField = value;
        }
    }
}