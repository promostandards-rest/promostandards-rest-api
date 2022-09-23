using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Security.Cryptography.Xml;
using System.Security.Policy;
using MongoDB.Bson.Serialization.Attributes;

namespace PromoStandards.REST.Core.Inventory;

public partial class PartInventory
{
    /// <summary>
    /// The part id
    /// </summary>
    [Required]
    public string partId { get; set; }

    /// <summary>
    /// A boolean value indicating if this is a main part of the product. In a tumbler with an optional lid configuration, the parts associated with the tumbler would be set to TRUE. The parts associated with the Lid would be set to false.
    /// </summary>
    [Required]
    public bool mainPart { get; set; }

    /// <summary>
    /// Description of the color of the part
    /// </summary>
    public string partColor { get; set; }

    /// <summary>
    /// The apparel items tagged size.  Enumerated values: {6XS,5XS,4XS,3XS,2XS,XS,S,M,L,XL,2XL,3XL,4XL,5XL,6XL,CUSTOM} CUSTOM is used for any size that does not match one of the other sizes.For example 7XL and 8XL would return CUSTOM.To identify the actual size when CUSTOM is returned, reference the Product Data endpoint.
    /// </summary>
    public labelSize labelSize { get; set; }

    /// <summary>
    /// Description of the part
    /// </summary>
    public string partDescription { get; set; }

    /// <summary>
    /// A quantity object containing the sum of inventory of all inventory locations of the part
    /// </summary>
    public Quantity quantityAvailable { get; set; }

    /// <summary>
    /// Indicates that the supplier produces this part according to demand. The supplier may keep a limited amount of inventory or inventory may be 0.
    /// </summary>
    [Required]
    public bool manufacturedItem { get; set; }

    /// <summary>
    /// Indicates that the supplier purchases this product to order. The supplier may keep a limited amount of inventory, show available inventory to buy, or it might be 0.
    /// </summary>
    [Required]
    public bool buyToOrder { get; set; }

    /// <summary>
    /// Time to replenish buy to order or made to order
    /// </summary>
    public int replenishmentLeadTime { get; set; }

    /// <summary>
    /// A string describing the attribute of the product other than size and color
    /// </summary>
    public string attributeSelection { get; set; }

    /// <summary>
    /// An array of InventoryLocation objects
    /// </summary>
    public InventoryLocation[] InventoryLocationArray { get; set; }

    /// <summary>
    /// A date timestamp in UTC specifying the last time inventory was modified.
    /// </summary>
    public System.DateTime lastModified { get; set; }
}