[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
[System.ServiceModel.ServiceContractAttribute(Namespace="http://www.promostandards.org/WSDL/MediaService/1.0.0/", ConfigurationName="MediaContentService")]
public interface MediaContentService
{
    
    [System.ServiceModel.OperationContractAttribute(Action="getMediaContent", ReplyAction="*")]
    [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
    [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ClassType[]))]
    [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Decoration[]))]
    [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Location[]))]
    [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MediaContent[]))]
    [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MediaDateModified[]))]
    System.Threading.Tasks.Task<getMediaContentResponse1> getMediaContentAsync(getMediaContentRequest1 request);
    
    [System.ServiceModel.OperationContractAttribute(Action="urn:getMediaDateModified", ReplyAction="*")]
    [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
    [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ClassType[]))]
    [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Decoration[]))]
    [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Location[]))]
    [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MediaContent[]))]
    [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MediaDateModified[]))]
    System.Threading.Tasks.Task<getMediaDateModifiedResponse1> getMediaDateModifiedAsync(getMediaDateModifiedRequest1 request);
}