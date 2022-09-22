namespace PromoStandards.REST.Core.MediaContent.ServiceReference;

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
public partial class getMediaContentResponse1
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.promostandards.org/WSDL/MediaService/1.0.0/", Order=0)]
    public GetMediaContentResponse GetMediaContentResponse;
    
    public getMediaContentResponse1()
    {
    }
    
    public getMediaContentResponse1(GetMediaContentResponse GetMediaContentResponse)
    {
        this.GetMediaContentResponse = GetMediaContentResponse;
    }
}