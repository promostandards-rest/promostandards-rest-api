[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
public partial class MediaContentServiceClient : System.ServiceModel.ClientBase<MediaContentService>, MediaContentService
{
    
    /// <summary>
    /// Implement this partial method to configure the service endpoint.
    /// </summary>
    /// <param name="serviceEndpoint">The endpoint to configure</param>
    /// <param name="clientCredentials">The client credentials</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
    
    public MediaContentServiceClient() : 
        base(MediaContentServiceClient.GetDefaultBinding(), MediaContentServiceClient.GetDefaultEndpointAddress())
    {
        this.Endpoint.Name = EndpointConfiguration.MediaServiceBinding.ToString();
        ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
    }
    
    public MediaContentServiceClient(EndpointConfiguration endpointConfiguration) : 
        base(MediaContentServiceClient.GetBindingForEndpoint(endpointConfiguration), MediaContentServiceClient.GetEndpointAddress(endpointConfiguration))
    {
        this.Endpoint.Name = endpointConfiguration.ToString();
        ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
    }
    
    public MediaContentServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
        base(MediaContentServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
    {
        this.Endpoint.Name = endpointConfiguration.ToString();
        ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
    }
    
    public MediaContentServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
        base(MediaContentServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
    {
        this.Endpoint.Name = endpointConfiguration.ToString();
        ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
    }
    
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
    
    private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
    {
        if ((endpointConfiguration == EndpointConfiguration.MediaServiceBinding))
        {
            System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
            result.MaxBufferSize = int.MaxValue;
            result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
            result.MaxReceivedMessageSize = int.MaxValue;
            result.AllowCookies = true;
            result.Security.Mode = System.ServiceModel.BasicHttpSecurityMode.Transport;
            return result;
        }
        throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
    }
    
    private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
    {
        if ((endpointConfiguration == EndpointConfiguration.MediaServiceBinding))
        {
            return new System.ServiceModel.EndpointAddress("https://services.starline.com/MediaContentService/MediaContentService.svc");
        }
        throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
    }
    
    private static System.ServiceModel.Channels.Binding GetDefaultBinding()
    {
        return MediaContentServiceClient.GetBindingForEndpoint(EndpointConfiguration.MediaServiceBinding);
    }
    
    private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
    {
        return MediaContentServiceClient.GetEndpointAddress(EndpointConfiguration.MediaServiceBinding);
    }
    
    public enum EndpointConfiguration
    {
        
        MediaServiceBinding,
    }
}