namespace PromoStandards.REST.Core.ProductPricingConfiguration.ServiceReference;

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
public partial class PricingAndConfigurationServiceClient : System.ServiceModel.ClientBase<PricingAndConfigurationService>, PricingAndConfigurationService
{
    
    public PricingAndConfigurationServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
        base(binding, remoteAddress)
    {
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    System.Threading.Tasks.Task<getAvailableLocationsResponse1> PricingAndConfigurationService.getAvailableLocationsAsync(getAvailableLocationsRequest1 request)
    {
        return base.Channel.getAvailableLocationsAsync(request);
    }
    
    public System.Threading.Tasks.Task<getAvailableLocationsResponse1> getAvailableLocationsAsync(GetAvailableLocationsRequest GetAvailableLocationsRequest)
    {
        getAvailableLocationsRequest1 inValue = new getAvailableLocationsRequest1();
        inValue.GetAvailableLocationsRequest = GetAvailableLocationsRequest;
        return ((PricingAndConfigurationService)(this)).getAvailableLocationsAsync(inValue);
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    System.Threading.Tasks.Task<getDecorationColorsResponse1> PricingAndConfigurationService.getDecorationColorsAsync(getDecorationColorsRequest1 request)
    {
        return base.Channel.getDecorationColorsAsync(request);
    }
    
    public System.Threading.Tasks.Task<getDecorationColorsResponse1> getDecorationColorsAsync(GetDecorationColorsRequest GetDecorationColorsRequest)
    {
        getDecorationColorsRequest1 inValue = new getDecorationColorsRequest1();
        inValue.GetDecorationColorsRequest = GetDecorationColorsRequest;
        return ((PricingAndConfigurationService)(this)).getDecorationColorsAsync(inValue);
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    System.Threading.Tasks.Task<getFobPointsResponse1> PricingAndConfigurationService.getFobPointsAsync(getFobPointsRequest1 request)
    {
        return base.Channel.getFobPointsAsync(request);
    }
    
    public System.Threading.Tasks.Task<getFobPointsResponse1> getFobPointsAsync(GetFobPointsRequest GetFobPointsRequest)
    {
        getFobPointsRequest1 inValue = new getFobPointsRequest1();
        inValue.GetFobPointsRequest = GetFobPointsRequest;
        return ((PricingAndConfigurationService)(this)).getFobPointsAsync(inValue);
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    System.Threading.Tasks.Task<getAvailableChargesResponse1> PricingAndConfigurationService.getAvailableChargesAsync(getAvailableChargesRequest1 request)
    {
        return base.Channel.getAvailableChargesAsync(request);
    }
    
    public System.Threading.Tasks.Task<getAvailableChargesResponse1> getAvailableChargesAsync(GetAvailableChargesRequest GetAvailableChargesRequest)
    {
        getAvailableChargesRequest1 inValue = new getAvailableChargesRequest1();
        inValue.GetAvailableChargesRequest = GetAvailableChargesRequest;
        return ((PricingAndConfigurationService)(this)).getAvailableChargesAsync(inValue);
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    System.Threading.Tasks.Task<getConfigurationAndPricingResponse1> PricingAndConfigurationService.getConfigurationAndPricingAsync(getConfigurationAndPricingRequest1 request)
    {
        return base.Channel.getConfigurationAndPricingAsync(request);
    }
    
    public System.Threading.Tasks.Task<getConfigurationAndPricingResponse1> getConfigurationAndPricingAsync(GetConfigurationAndPricingRequest GetConfigurationAndPricingRequest)
    {
        getConfigurationAndPricingRequest1 inValue = new getConfigurationAndPricingRequest1();
        inValue.GetConfigurationAndPricingRequest = GetConfigurationAndPricingRequest;
        return ((PricingAndConfigurationService)(this)).getConfigurationAndPricingAsync(inValue);
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