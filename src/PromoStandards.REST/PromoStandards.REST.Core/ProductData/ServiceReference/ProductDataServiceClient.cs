[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
public partial class ProductDataServiceClient : System.ServiceModel.ClientBase<ProductDataService>, ProductDataService
{
    
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
}