[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
public partial class getComplianceResponse1
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.promostandards.org/WSDL/ProductComplianceService/1.0.0/", Order=0)]
    public GetComplianceResponse GetComplianceResponse;
    
    public getComplianceResponse1()
    {
    }
    
    public getComplianceResponse1(GetComplianceResponse GetComplianceResponse)
    {
        this.GetComplianceResponse = GetComplianceResponse;
    }
}