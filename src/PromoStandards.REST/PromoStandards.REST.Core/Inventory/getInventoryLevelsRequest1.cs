namespace PromoStandards.REST.Core.Inventory;

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
public partial class getInventoryLevelsRequest1
{
        
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.promostandards.org/WSDL/Inventory/2.0.0/", Order=0)]
    public GetInventoryLevelsRequest GetInventoryLevelsRequest;
        
    public getInventoryLevelsRequest1()
    {
    }
        
    public getInventoryLevelsRequest1(GetInventoryLevelsRequest GetInventoryLevelsRequest)
    {
        this.GetInventoryLevelsRequest = GetInventoryLevelsRequest;
    }
}