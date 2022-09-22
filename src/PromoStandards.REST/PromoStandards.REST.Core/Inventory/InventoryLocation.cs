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
        
    private inventoryLocationQuantity inventoryLocationQuantityField;
        
    private FutureAvailability[] futureAvailabilityArrayField;
        
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public string inventoryLocationId
    {
        get
        {
            return this.inventoryLocationIdField;
        }
        set
        {
            this.inventoryLocationIdField = value;
        }
    }
        
    /// <remarks/>
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
        
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public string postalCode
    {
        get
        {
            return this.postalCodeField;
        }
        set
        {
            this.postalCodeField = value;
        }
    }
        
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    public InventoryLocationCountry country
    {
        get
        {
            return this.countryField;
        }
        set
        {
            this.countryField = value;
        }
    }
        
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool countrySpecified
    {
        get
        {
            return this.countryFieldSpecified;
        }
        set
        {
            this.countryFieldSpecified = value;
        }
    }
        
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=4)]
    public inventoryLocationQuantity inventoryLocationQuantity
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
        
    /// <remarks/>
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