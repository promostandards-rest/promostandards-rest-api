/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.promostandards.org/WSDL/ProductComplianceService/1.0.0/")]
public partial class GetProductsWithRegulationsResponse
{
    
    private GetProductsWithRegulationsResponseProductWithRegulations[] productWithRegulationsArrayField;
    
    private GetProductsWithRegulationsResponseServiceMessage[] serviceMessageArrayField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Order=0)]
    [System.Xml.Serialization.XmlArrayItemAttribute("ProductWithRegulations", IsNullable=false)]
    public GetProductsWithRegulationsResponseProductWithRegulations[] productWithRegulationsArray
    {
        get
        {
            return this.productWithRegulationsArrayField;
        }
        set
        {
            this.productWithRegulationsArrayField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Order=1)]
    [System.Xml.Serialization.XmlArrayItemAttribute("ServiceMessage", IsNullable=false)]
    public GetProductsWithRegulationsResponseServiceMessage[] ServiceMessageArray
    {
        get
        {
            return this.serviceMessageArrayField;
        }
        set
        {
            this.serviceMessageArrayField = value;
        }
    }
}