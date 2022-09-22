namespace PromoStandards.REST.Core.MediaContent.ServiceReference;

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
public partial class MediaContentServiceClient : System.ServiceModel.ClientBase<MediaContentService>, MediaContentService
{
    
    public MediaContentServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
        base(binding, remoteAddress)
    {
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    System.Threading.Tasks.Task<getMediaContentResponse1> MediaContentService.getMediaContentAsync(getMediaContentRequest1 request)
    {
        return base.Channel.getMediaContentAsync(request);
    }
    
    public System.Threading.Tasks.Task<getMediaContentResponse1> getMediaContentAsync(GetMediaContentRequest GetMediaContentRequest)
    {
        getMediaContentRequest1 inValue = new getMediaContentRequest1();
        inValue.GetMediaContentRequest = GetMediaContentRequest;
        return ((MediaContentService)(this)).getMediaContentAsync(inValue);
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    System.Threading.Tasks.Task<getMediaDateModifiedResponse1> MediaContentService.getMediaDateModifiedAsync(getMediaDateModifiedRequest1 request)
    {
        return base.Channel.getMediaDateModifiedAsync(request);
    }
    
    public System.Threading.Tasks.Task<getMediaDateModifiedResponse1> getMediaDateModifiedAsync(GetMediaDateModifiedRequest GetMediaDateModifiedRequest)
    {
        getMediaDateModifiedRequest1 inValue = new getMediaDateModifiedRequest1();
        inValue.GetMediaDateModifiedRequest = GetMediaDateModifiedRequest;
        return ((MediaContentService)(this)).getMediaDateModifiedAsync(inValue);
    }
    
    public virtual System.Threading.Tasks.Task OpenAsync()
    {
        return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
    }
    
    public virtual System.Threading.Tasks.Task CloseAsync()
    {
        return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
    }
}