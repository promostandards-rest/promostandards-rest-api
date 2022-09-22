/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.promostandards.org/WSDL/ProductComplianceService/1.0.0/")]
public partial class CAProp65ApplicableWarning
{
    
    private applicableWarningEnum applicableWarningField;
    
    private string[] applicableChemicalsField;
    
    private warningLabelAppliedEnum warningLabelAppliedField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public applicableWarningEnum applicableWarning
    {
        get
        {
            return this.applicableWarningField;
        }
        set
        {
            this.applicableWarningField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Order=1)]
    [System.Xml.Serialization.XmlArrayItemAttribute("applicableChemical", DataType="token", IsNullable=false)]
    public string[] applicableChemicals
    {
        get
        {
            return this.applicableChemicalsField;
        }
        set
        {
            this.applicableChemicalsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public warningLabelAppliedEnum warningLabelApplied
    {
        get
        {
            return this.warningLabelAppliedField;
        }
        set
        {
            this.warningLabelAppliedField = value;
        }
    }
}