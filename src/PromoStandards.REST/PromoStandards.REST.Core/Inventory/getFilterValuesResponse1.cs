namespace PromoStandards.REST.Core.Inventory;

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
public partial class getFilterValuesResponse1
{
        
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.promostandards.org/WSDL/Inventory/2.0.0/", Order=0)]
    public GetFilterValuesResponse GetFilterValuesResponse;
        
    public getFilterValuesResponse1()
    {
    }
        
    public getFilterValuesResponse1(GetFilterValuesResponse GetFilterValuesResponse)
    {
        this.GetFilterValuesResponse = GetFilterValuesResponse;
    }
}