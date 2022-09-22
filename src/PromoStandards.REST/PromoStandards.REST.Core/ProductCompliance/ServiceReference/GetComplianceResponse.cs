/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.promostandards.org/WSDL/ProductComplianceService/1.0.0/")]
public partial class GetComplianceResponse
{
    
    private GetComplianceResponseComplianceData[] complianceDataArrayField;
    
    private GetComplianceResponseServiceMessage[] serviceMessageArrayField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Order=0)]
    [System.Xml.Serialization.XmlArrayItemAttribute("ComplianceData", IsNullable=false)]
    public GetComplianceResponseComplianceData[] ComplianceDataArray
    {
        get
        {
            return this.complianceDataArrayField;
        }
        set
        {
            this.complianceDataArrayField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Order=1)]
    [System.Xml.Serialization.XmlArrayItemAttribute("ServiceMessage", IsNullable=false)]
    public GetComplianceResponseServiceMessage[] ServiceMessageArray
    {
        get
        {
            return this.serviceMessageArrayField;
        }
        set
        {
            this.serviceMessageArrayField = value;
        }
    }
}