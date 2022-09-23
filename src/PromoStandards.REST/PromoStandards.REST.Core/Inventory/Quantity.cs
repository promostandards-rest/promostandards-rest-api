using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PromoStandards.REST.Core.Inventory;

public partial class Quantity
{
    /// <summary>
    /// The quantity value
    /// </summary>
    [Required]
    public QuantityUom uom { get; set; }

    /// <summary>
    /// The unit of measure; values are enumerated.
    /// Values are: {BX, CA, DZ, EA, KT, PR, PK, RL, ST, SL, TH}
    ///   BX - Box
    ///   CA - Case
    ///   DZ - Dozen
    ///   EA - Each
    ///   KT - Kit
    ///   PR - Pair
    ///   PK - Package
    ///   RL - Roll
    ///   ST - Set
    ///   SL - Sleeve
    ///   TH – Thousand
    /// </summary>
    [Required]
    public decimal value { get; set; }
}