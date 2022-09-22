using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PromoStandards.REST.Core.Inventory;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.33440")]
[Serializable()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.promostandards.org/WSDL/Inventory/2.0.0/SharedObjects/")]
public partial class Quantity
{
        
    private QuantityUom uomField;
        
    private decimal valueField;

    /// <summary>
    /// The quantity value
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    [Required]
    public QuantityUom uom
    {
        get
        {
            return this.uomField;
        }
        set
        {
            this.uomField = value;
        }
    }

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
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    [Required]
    public decimal value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}