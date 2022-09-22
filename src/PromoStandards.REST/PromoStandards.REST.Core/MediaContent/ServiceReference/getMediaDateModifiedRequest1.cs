namespace PromoStandards.REST.Core.MediaContent.ServiceReference;

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
public partial class getMediaDateModifiedRequest1
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.promostandards.org/WSDL/MediaService/1.0.0/", Order=0)]
    public GetMediaDateModifiedRequest GetMediaDateModifiedRequest;
    
    public getMediaDateModifiedRequest1()
    {
    }
    
    public getMediaDateModifiedRequest1(GetMediaDateModifiedRequest GetMediaDateModifiedRequest)
    {
        this.GetMediaDateModifiedRequest = GetMediaDateModifiedRequest;
    }
}