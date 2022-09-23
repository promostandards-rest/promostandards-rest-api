namespace PromoStandards.REST.MongoDBApp.Inventory.ServiceReference;

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
public partial class InventoryServiceClient : System.ServiceModel.ClientBase<InventoryService>, InventoryService
{
    
    /// <summary>
    /// Implement this partial method to configure the service endpoint.
    /// </summary>
    /// <param name="serviceEndpoint">The endpoint to configure</param>
    /// <param name="clientCredentials">The client credentials</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
    
    public InventoryServiceClient() : 
        base(InventoryServiceClient.GetDefaultBinding(), InventoryServiceClient.GetDefaultEndpointAddress())
    {
        this.Endpoint.Name = EndpointConfiguration.InventoryServiceBinding.ToString();
        ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
    }
    
    public InventoryServiceClient(EndpointConfiguration endpointConfiguration) : 
        base(InventoryServiceClient.GetBindingForEndpoint(endpointConfiguration), InventoryServiceClient.GetEndpointAddress(endpointConfiguration))
    {
        this.Endpoint.Name = endpointConfiguration.ToString();
        ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
    }
    
    public InventoryServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
        base(InventoryServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
    {
        this.Endpoint.Name = endpointConfiguration.ToString();
        ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
    }
    
    public InventoryServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
        base(InventoryServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
    {
        this.Endpoint.Name = endpointConfiguration.ToString();
        ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
    }
    
    public InventoryServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
        base(binding, remoteAddress)
    {
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    System.Threading.Tasks.Task<getFilterValuesResponse1> InventoryService.getFilterValuesAsync(getFilterValuesRequest1 request)
    {
        return base.Channel.getFilterValuesAsync(request);
    }
    
    public System.Threading.Tasks.Task<getFilterValuesResponse1> getFilterValuesAsync(GetFilterValuesRequest GetFilterValuesRequest)
    {
        getFilterValuesRequest1 inValue = new getFilterValuesRequest1();
        inValue.GetFilterValuesRequest = GetFilterValuesRequest;
        return ((InventoryService)(this)).getFilterValuesAsync(inValue);
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    System.Threading.Tasks.Task<getInventoryLevelsResponse1> InventoryService.getInventoryLevelsAsync(getInventoryLevelsRequest1 request)
    {
        return base.Channel.getInventoryLevelsAsync(request);
    }
    
    public System.Threading.Tasks.Task<getInventoryLevelsResponse1> getInventoryLevelsAsync(GetInventoryLevelsRequest GetInventoryLevelsRequest)
    {
        getInventoryLevelsRequest1 inValue = new getInventoryLevelsRequest1();
        inValue.GetInventoryLevelsRequest = GetInventoryLevelsRequest;
        return ((InventoryService)(this)).getInventoryLevelsAsync(inValue);
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
        if ((endpointConfiguration == EndpointConfiguration.InventoryServiceBinding))
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
        if ((endpointConfiguration == EndpointConfiguration.InventoryServiceBinding))
        {
            return new System.ServiceModel.EndpointAddress("https://services.starline.com/InventoryService/CustomerInventoryServiceV2.svc");
        }
        throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
    }
    
    private static System.ServiceModel.Channels.Binding GetDefaultBinding()
    {
        return InventoryServiceClient.GetBindingForEndpoint(EndpointConfiguration.InventoryServiceBinding);
    }
    
    private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
    {
        return InventoryServiceClient.GetEndpointAddress(EndpointConfiguration.InventoryServiceBinding);
    }
    
    public enum EndpointConfiguration
    {
        
        InventoryServiceBinding,
    }
}