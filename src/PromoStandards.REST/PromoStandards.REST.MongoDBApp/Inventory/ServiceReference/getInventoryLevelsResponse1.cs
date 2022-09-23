namespace PromoStandards.REST.MongoDBApp.Inventory.ServiceReference;

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
public partial class getInventoryLevelsResponse1
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.promostandards.org/WSDL/Inventory/2.0.0/", Order=0)]
    public GetInventoryLevelsResponse GetInventoryLevelsResponse;
    
    public getInventoryLevelsResponse1()
    {
    }
    
    public getInventoryLevelsResponse1(GetInventoryLevelsResponse GetInventoryLevelsResponse)
    {
        this.GetInventoryLevelsResponse = GetInventoryLevelsResponse;
    }
}