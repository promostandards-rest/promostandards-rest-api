using System.ServiceModel;

var basicHttpsBinding = new BasicHttpsBinding()
{
    MaxReceivedMessageSize = int.MaxValue,
    MaxBufferPoolSize = int.MaxValue,
    MaxBufferSize = int.MaxValue,
};
var throttling = 0;
var endpoint = "";
var wsVersion = "";
var id = "";
var password = "";
var localizationCountry = "";
var localizationLanguage = "";

var client = new ProductDataServiceClient(basicHttpsBinding, new EndpointAddress(endpoint));

var sellable = await client.getProductSellableAsync(new GetProductSellableRequest()
{
    wsVersion = wsVersion,
    id = id,
    password = password,
    isSellable = true,
    localizationCountry = localizationCountry,
    localizationLanguage = localizationLanguage
});

var closeout = await client.getProductCloseOutAsync(new GetProductCloseOutRequest()
{
    wsVersion = wsVersion,
    id = id,
    password = password,
});

var sellableIds = sellable.GetProductSellableResponse.ProductSellableArray.Select(p => p.productId).ToList();
var closeoutIds = closeout.GetProductCloseOutResponse.ProductCloseOutArray.Select(p => p.productId).ToList();
var productIds = sellableIds.Concat(closeoutIds).Distinct();

foreach (var productId in productIds)
{
    var product = await client.getProductAsync(new GetProductRequest
    {
        wsVersion = null,
        id = null,
        password = null,
        localizationCountry = null,
        localizationLanguage = null,
        productId = id
    });
}