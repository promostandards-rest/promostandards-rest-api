﻿namespace PromoStandards.REST.Core.ProductPricingConfiguration.ServiceReference;

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
public partial class getAvailableChargesResponse1
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.promostandards.org/WSDL/PricingAndConfiguration/1.0.0/", Order=0)]
    public GetAvailableChargesResponse GetAvailableChargesResponse;
    
    public getAvailableChargesResponse1()
    {
    }
    
    public getAvailableChargesResponse1(GetAvailableChargesResponse GetAvailableChargesResponse)
    {
        this.GetAvailableChargesResponse = GetAvailableChargesResponse;
    }
}