﻿[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
public partial class getProductsWithRegulationsRequest1
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.promostandards.org/WSDL/ProductComplianceService/1.0.0/", Order=0)]
    public GetProductsWithRegulationsRequest GetProductsWithRegulationsRequest;
    
    public getProductsWithRegulationsRequest1()
    {
    }
    
    public getProductsWithRegulationsRequest1(GetProductsWithRegulationsRequest GetProductsWithRegulationsRequest)
    {
        this.GetProductsWithRegulationsRequest = GetProductsWithRegulationsRequest;
    }
}