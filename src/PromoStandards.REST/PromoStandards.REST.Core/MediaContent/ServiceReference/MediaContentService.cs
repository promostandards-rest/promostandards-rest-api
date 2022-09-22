namespace PromoStandards.REST.Core.MediaContent.ServiceReference;
public interface MediaContentService
{
    System.Threading.Tasks.Task<GetMediaContentResponse> getMediaContentAsync(GetMediaContentRequest request);
    System.Threading.Tasks.Task<GetMediaDateModifiedResponse> getMediaDateModifiedAsync(GetMediaDateModifiedRequest request);
}