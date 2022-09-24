namespace PromoStandards.REST.MongoDBApp.ProductData.ServiceReference;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.promostandards.org/WSDL/ProductDataService/2.0.0/SharedObjects/")]
public partial class RelatedProduct
{
    
    private RelatedProductRelationType relationTypeField;
    
    private string productIdField;
    
    private string partIdField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public RelatedProductRelationType relationType
    {
        get
        {
            return this.relationTypeField;
        }
        set
        {
            this.relationTypeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=1)]
    public string productId
    {
        get
        {
            return this.productIdField;
        }
        set
        {
            this.productIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=2)]
    public string partId
    {
        get
        {
            return this.partIdField;
        }
        set
        {
            this.partIdField = value;
        }
    }
}