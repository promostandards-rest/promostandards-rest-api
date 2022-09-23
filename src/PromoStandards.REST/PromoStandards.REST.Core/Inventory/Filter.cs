namespace PromoStandards.REST.Core.Inventory;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.33440")]
[Serializable()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.promostandards.org/WSDL/Inventory/2.0.0/SharedObjects/")]
public partial class Filter
{
        
    private string[] partIdArrayField;
        
    private string[] labelSizeArrayField;
        
    private string[] partColorArrayField;
        
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Order=0)]
    [System.Xml.Serialization.XmlArrayItemAttribute("partId", IsNullable=false)]
    public string[] partIdArray
    {
        get
        {
            return this.partIdArrayField;
        }
        set
        {
            this.partIdArrayField = value;
        }
    }
        
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Order=1)]
    public string[] LabelSizeArray
    {
        get
        {
            return this.labelSizeArrayField;
        }
        set
        {
            this.labelSizeArrayField = value;
        }
    }
        
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Order=2)]
    [System.Xml.Serialization.XmlArrayItemAttribute("partColor", IsNullable=false)]
    public string[] PartColorArray
    {
        get
        {
            return this.partColorArrayField;
        }
        set
        {
            this.partColorArrayField = value;
        }
    }
}