[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
public partial class ProductComplianceServiceClient : System.ServiceModel.ClientBase<ProductComplianceService>, ProductComplianceService
{
    
    /// <summary>
    /// Implement this partial method to configure the service endpoint.
    /// </summary>
    /// <param name="serviceEndpoint">The endpoint to configure</param>
    /// <param name="clientCredentials">The client credentials</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
    
    public ProductComplianceServiceClient() : 
        base(ProductComplianceServiceClient.GetDefaultBinding(), ProductComplianceServiceClient.GetDefaultEndpointAddress())
    {
        this.Endpoint.Name = EndpointConfiguration.ProductComplianceServiceBinding.ToString();
        ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
    }
    
    public ProductComplianceServiceClient(EndpointConfiguration endpointConfiguration) : 
        base(ProductComplianceServiceClient.GetBindingForEndpoint(endpointConfiguration), ProductComplianceServiceClient.GetEndpointAddress(endpointConfiguration))
    {
        this.Endpoint.Name = endpointConfiguration.ToString();
        ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
    }
    
    public ProductComplianceServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
        base(ProductComplianceServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
    {
        this.Endpoint.Name = endpointConfiguration.ToString();
        ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
    }
    
    public ProductComplianceServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
        base(ProductComplianceServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
    {
        this.Endpoint.Name = endpointConfiguration.ToString();
        ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
    }
    
    public ProductComplianceServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
        base(binding, remoteAddress)
    {
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    System.Threading.Tasks.Task<getProductsWithRegulationsResponse1> ProductComplianceService.getProductsWithRegulationsAsync(getProductsWithRegulationsRequest1 request)
    {
        return base.Channel.getProductsWithRegulationsAsync(request);
    }
    
    public System.Threading.Tasks.Task<getProductsWithRegulationsResponse1> getProductsWithRegulationsAsync(GetProductsWithRegulationsRequest GetProductsWithRegulationsRequest)
    {
        getProductsWithRegulationsRequest1 inValue = new getProductsWithRegulationsRequest1();
        inValue.GetProductsWithRegulationsRequest = GetProductsWithRegulationsRequest;
        return ((ProductComplianceService)(this)).getProductsWithRegulationsAsync(inValue);
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    System.Threading.Tasks.Task<getComplianceResponse1> ProductComplianceService.getComplianceAsync(getComplianceRequest1 request)
    {
        return base.Channel.getComplianceAsync(request);
    }
    
    public System.Threading.Tasks.Task<getComplianceResponse1> getComplianceAsync(GetComplianceRequest GetComplianceRequest)
    {
        getComplianceRequest1 inValue = new getComplianceRequest1();
        inValue.GetComplianceRequest = GetComplianceRequest;
        return ((ProductComplianceService)(this)).getComplianceAsync(inValue);
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
        if ((endpointConfiguration == EndpointConfiguration.ProductComplianceServiceBinding))
        {
            System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
            result.MaxBufferSize = int.MaxValue;
            result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
            result.MaxReceivedMessageSize = int.MaxValue;
            result.AllowCookies = true;
            return result;
        }
        throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
    }
    
    private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
    {
        if ((endpointConfiguration == EndpointConfiguration.ProductComplianceServiceBinding))
        {
            return new System.ServiceModel.EndpointAddress("http://localhost/ProductComplianceService.svc");
        }
        throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
    }
    
    private static System.ServiceModel.Channels.Binding GetDefaultBinding()
    {
        return ProductComplianceServiceClient.GetBindingForEndpoint(EndpointConfiguration.ProductComplianceServiceBinding);
    }
    
    private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
    {
        return ProductComplianceServiceClient.GetEndpointAddress(EndpointConfiguration.ProductComplianceServiceBinding);
    }
    
    public enum EndpointConfiguration
    {
        
        ProductComplianceServiceBinding,
    }
}