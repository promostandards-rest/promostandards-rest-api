﻿namespace PromoStandards.REST.Core.Inventory;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.33440")]
[Serializable()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.promostandards.org/WSDL/Inventory/2.0.0/SharedObjects/")]
public partial class ServiceMessage
{
        
    private int codeField;
        
    private string descriptionField;
        
    private ServiceMessageSeverity severityField;
        
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public int code
    {
        get
        {
            return this.codeField;
        }
        set
        {
            this.codeField = value;
        }
    }
        
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="token", Order=1)]
    public string description
    {
        get
        {
            return this.descriptionField;
        }
        set
        {
            this.descriptionField = value;
        }
    }
        
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public ServiceMessageSeverity severity
    {
        get
        {
            return this.severityField;
        }
        set
        {
            this.severityField = value;
        }
    }
}