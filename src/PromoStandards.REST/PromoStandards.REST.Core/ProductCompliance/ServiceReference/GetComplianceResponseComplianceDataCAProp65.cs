/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.promostandards.org/WSDL/ProductComplianceService/1.0.0/")]
public partial class GetComplianceResponseComplianceDataCAProp65
{
    
    private CAProp65ApplicableWarning[] applicableWarningsArrayField;
    
    private policyForApplyingLabelEnum policyForApplyingLabelField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Order=0)]
    [System.Xml.Serialization.XmlArrayItemAttribute("ApplicableWarnings", IsNullable=false)]
    public CAProp65ApplicableWarning[] ApplicableWarningsArray
    {
        get
        {
            return this.applicableWarningsArrayField;
        }
        set
        {
            this.applicableWarningsArrayField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public policyForApplyingLabelEnum policyForApplyingLabel
    {
        get
        {
            return this.policyForApplyingLabelField;
        }
        set
        {
            this.policyForApplyingLabelField = value;
        }
    }
}