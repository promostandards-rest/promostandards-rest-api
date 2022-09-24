using System.ComponentModel.DataAnnotations;

namespace PromoStandards.REST.Core.ProductData.ServiceReference;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.promostandards.org/WSDL/ProductDataService/2.0.0/SharedObjects/")]
public partial class Specification
{
    
    private SpecificationSpecificationType specificationTypeField;
    
    private string specificationUomField;
    
    private string measurementValueField;

    /// <summary>
    /// The type of specification
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    [Required]
    public SpecificationSpecificationType specificationType
    {
        get
        {
            return this.specificationTypeField;
        }
        set
        {
            this.specificationTypeField = value;
        }
    }

    /// <summary>
    /// Specification unit of measure  
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(DataType="token", IsNullable=true, Order=1)]
    [Required]
    public string SpecificationUom
    {
        get
        {
            return this.specificationUomField;
        }
        set
        {
            this.specificationUomField = value;
        }
    }

    /// <summary>
    /// Specification Measurement Value
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=2)]
    [Required]
    public string measurementValue
    {
        get
        {
            return this.measurementValueField;
        }
        set
        {
            this.measurementValueField = value;
        }
    }
}