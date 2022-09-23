[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
public partial class ProductDataServiceClient : System.ServiceModel.ClientBase<ProductDataService>, ProductDataService
{
    
    /// <summary>
    /// Implement this partial method to configure the service endpoint.
    /// </summary>
    /// <param name="serviceEndpoint">The endpoint to configure</param>
    /// <param name="clientCredentials">The client credentials</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
    
    public ProductDataServiceClient() : 
        base(ProductDataServiceClient.GetDefaultBinding(), ProductDataServiceClient.GetDefaultEndpointAddress())
    {
        this.Endpoint.Name = EndpointConfiguration.ProductDataServiceBinding.ToString();
        ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
    }
    
    public ProductDataServiceClient(EndpointConfiguration endpointConfiguration) : 
        base(ProductDataServiceClient.GetBindingForEndpoint(endpointConfiguration), ProductDataServiceClient.GetEndpointAddress(endpointConfiguration))
    {
        this.Endpoint.Name = endpointConfiguration.ToString();
        ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
    }
    
    public ProductDataServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
        base(ProductDataServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
    {
        this.Endpoint.Name = endpointConfiguration.ToString();
        ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
    }
    
    public ProductDataServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
        base(ProductDataServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
    {
        this.Endpoint.Name = endpointConfiguration.ToString();
        ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
    }
    
    public ProductDataServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
        base(binding, remoteAddress)
    {
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    System.Threading.Tasks.Task<getProductResponse1> ProductDataService.getProductAsync(getProductRequest1 request)
    {
        return base.Channel.getProductAsync(request);
    }
    
    public System.Threading.Tasks.Task<getProductResponse1> getProductAsync(GetProductRequest GetProductRequest)
    {
        getProductRequest1 inValue = new getProductRequest1();
        inValue.GetProductRequest = GetProductRequest;
        return ((ProductDataService)(this)).getProductAsync(inValue);
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    System.Threading.Tasks.Task<getProductDateModifiedResponse1> ProductDataService.getProductDateModifiedAsync(getProductDateModifiedRequest1 request)
    {
        return base.Channel.getProductDateModifiedAsync(request);
    }
    
    public System.Threading.Tasks.Task<getProductDateModifiedResponse1> getProductDateModifiedAsync(GetProductDateModifiedRequest GetProductDateModifiedRequest)
    {
        getProductDateModifiedRequest1 inValue = new getProductDateModifiedRequest1();
        inValue.GetProductDateModifiedRequest = GetProductDateModifiedRequest;
        return ((ProductDataService)(this)).getProductDateModifiedAsync(inValue);
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    System.Threading.Tasks.Task<getProductCloseOutResponse1> ProductDataService.getProductCloseOutAsync(getProductCloseOutRequest1 request)
    {
        return base.Channel.getProductCloseOutAsync(request);
    }
    
    public System.Threading.Tasks.Task<getProductCloseOutResponse1> getProductCloseOutAsync(GetProductCloseOutRequest GetProductCloseOutRequest)
    {
        getProductCloseOutRequest1 inValue = new getProductCloseOutRequest1();
        inValue.GetProductCloseOutRequest = GetProductCloseOutRequest;
        return ((ProductDataService)(this)).getProductCloseOutAsync(inValue);
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    System.Threading.Tasks.Task<getProductSellableResponse1> ProductDataService.getProductSellableAsync(getProductSellableRequest1 request)
    {
        return base.Channel.getProductSellableAsync(request);
    }
    
    public System.Threading.Tasks.Task<getProductSellableResponse1> getProductSellableAsync(GetProductSellableRequest GetProductSellableRequest)
    {
        getProductSellableRequest1 inValue = new getProductSellableRequest1();
        inValue.GetProductSellableRequest = GetProductSellableRequest;
        return ((ProductDataService)(this)).getProductSellableAsync(inValue);
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
        if ((endpointConfiguration == EndpointConfiguration.ProductDataServiceBinding))
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
        if ((endpointConfiguration == EndpointConfiguration.ProductDataServiceBinding))
        {
            return new System.ServiceModel.EndpointAddress("https://services.starline.com/CustomerProductDataService/CustomerProductDataServi" +
                                                           "ceV2.svc");
        }
        throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
    }
    
    private static System.ServiceModel.Channels.Binding GetDefaultBinding()
    {
        return ProductDataServiceClient.GetBindingForEndpoint(EndpointConfiguration.ProductDataServiceBinding);
    }
    
    private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
    {
        return ProductDataServiceClient.GetEndpointAddress(EndpointConfiguration.ProductDataServiceBinding);
    }
    
    public enum EndpointConfiguration
    {
        
        ProductDataServiceBinding,
    }
}