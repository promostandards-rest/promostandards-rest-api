namespace PromoStandards.REST.MongoDBApp.Inventory.ServiceReference;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.promostandards.org/WSDL/Inventory/2.0.0/SharedObjects/")]
public partial class Filter
{
    
    private string[] partIdArrayField;
    
    private labelSize[] labelSizeArrayField;
    
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
    public labelSize[] LabelSizeArray
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