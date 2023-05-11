﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NumberplanService
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="intele.services", ConfigurationName="NumberplanService.NumberplanPublicSoap")]
    public interface NumberplanPublicSoap
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="intele.services/Query", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<NumberplanService.QueryResponse> QueryAsync(NumberplanService.QueryRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="intele.services")]
    public partial class Authorizer
    {
        
        private int apiCustomerIdField;
        
        private string apiPasswordField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int ApiCustomerId
        {
            get
            {
                return this.apiCustomerIdField;
            }
            set
            {
                this.apiCustomerIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string ApiPassword
        {
            get
            {
                return this.apiPasswordField;
            }
            set
            {
                this.apiPasswordField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="intele.services")]
    public partial class NumberInfo
    {
        
        private long number_rangeField;
        
        private int country_codeField;
        
        private string national_significant_numberField;
        
        private string iso_3166_alpha_2Field;
        
        private string iso_3166_alpha_3Field;
        
        private string destinationField;
        
        private string number_typeField;
        
        private string locationField;
        
        private string registrarField;
        
        private string descriptionField;
        
        private int area_code_lengthField;
        
        private int country_idField;
        
        private int min_number_lengthField;
        
        private int max_number_lengthField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public long number_range
        {
            get
            {
                return this.number_rangeField;
            }
            set
            {
                this.number_rangeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public int country_code
        {
            get
            {
                return this.country_codeField;
            }
            set
            {
                this.country_codeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string national_significant_number
        {
            get
            {
                return this.national_significant_numberField;
            }
            set
            {
                this.national_significant_numberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string iso_3166_alpha_2
        {
            get
            {
                return this.iso_3166_alpha_2Field;
            }
            set
            {
                this.iso_3166_alpha_2Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string iso_3166_alpha_3
        {
            get
            {
                return this.iso_3166_alpha_3Field;
            }
            set
            {
                this.iso_3166_alpha_3Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string destination
        {
            get
            {
                return this.destinationField;
            }
            set
            {
                this.destinationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public string number_type
        {
            get
            {
                return this.number_typeField;
            }
            set
            {
                this.number_typeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public string location
        {
            get
            {
                return this.locationField;
            }
            set
            {
                this.locationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public string registrar
        {
            get
            {
                return this.registrarField;
            }
            set
            {
                this.registrarField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=9)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=10)]
        public int area_code_length
        {
            get
            {
                return this.area_code_lengthField;
            }
            set
            {
                this.area_code_lengthField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=11)]
        public int country_id
        {
            get
            {
                return this.country_idField;
            }
            set
            {
                this.country_idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=12)]
        public int min_number_length
        {
            get
            {
                return this.min_number_lengthField;
            }
            set
            {
                this.min_number_lengthField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=13)]
        public int max_number_length
        {
            get
            {
                return this.max_number_lengthField;
            }
            set
            {
                this.max_number_lengthField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Query", WrapperNamespace="intele.services", IsWrapped=true)]
    public partial class QueryRequest
    {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="intele.services")]
        public NumberplanService.Authorizer Authorizer;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="intele.services", Order=0)]
        public long msisdn;
        
        public QueryRequest()
        {
        }
        
        public QueryRequest(NumberplanService.Authorizer Authorizer, long msisdn)
        {
            this.Authorizer = Authorizer;
            this.msisdn = msisdn;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="QueryResponse", WrapperNamespace="intele.services", IsWrapped=true)]
    public partial class QueryResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="intele.services", Order=0)]
        public NumberplanService.NumberInfo QueryResult;
        
        public QueryResponse()
        {
        }
        
        public QueryResponse(NumberplanService.NumberInfo QueryResult)
        {
            this.QueryResult = QueryResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public interface NumberplanPublicSoapChannel : NumberplanService.NumberplanPublicSoap, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public partial class NumberplanPublicSoapClient : System.ServiceModel.ClientBase<NumberplanService.NumberplanPublicSoap>, NumberplanService.NumberplanPublicSoap
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public NumberplanPublicSoapClient(EndpointConfiguration endpointConfiguration) : 
                base(NumberplanPublicSoapClient.GetBindingForEndpoint(endpointConfiguration), NumberplanPublicSoapClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public NumberplanPublicSoapClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(NumberplanPublicSoapClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public NumberplanPublicSoapClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(NumberplanPublicSoapClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public NumberplanPublicSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<NumberplanService.QueryResponse> NumberplanService.NumberplanPublicSoap.QueryAsync(NumberplanService.QueryRequest request)
        {
            return base.Channel.QueryAsync(request);
        }
        
        public System.Threading.Tasks.Task<NumberplanService.QueryResponse> QueryAsync(NumberplanService.Authorizer Authorizer, long msisdn)
        {
            NumberplanService.QueryRequest inValue = new NumberplanService.QueryRequest();
            inValue.Authorizer = Authorizer;
            inValue.msisdn = msisdn;
            return ((NumberplanService.NumberplanPublicSoap)(this)).QueryAsync(inValue);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.NumberplanPublicSoap))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                result.Security.Mode = System.ServiceModel.BasicHttpSecurityMode.Transport;
                return result;
            }
            if ((endpointConfiguration == EndpointConfiguration.NumberplanPublicSoap12))
            {
                System.ServiceModel.Channels.CustomBinding result = new System.ServiceModel.Channels.CustomBinding();
                System.ServiceModel.Channels.TextMessageEncodingBindingElement textBindingElement = new System.ServiceModel.Channels.TextMessageEncodingBindingElement();
                textBindingElement.MessageVersion = System.ServiceModel.Channels.MessageVersion.CreateVersion(System.ServiceModel.EnvelopeVersion.Soap12, System.ServiceModel.Channels.AddressingVersion.None);
                result.Elements.Add(textBindingElement);
                System.ServiceModel.Channels.HttpsTransportBindingElement httpsBindingElement = new System.ServiceModel.Channels.HttpsTransportBindingElement();
                httpsBindingElement.AllowCookies = true;
                httpsBindingElement.MaxBufferSize = int.MaxValue;
                httpsBindingElement.MaxReceivedMessageSize = int.MaxValue;
                result.Elements.Add(httpsBindingElement);
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.NumberplanPublicSoap))
            {
                return new System.ServiceModel.EndpointAddress("https://services.intele.no/numberplan/public.asmx");
            }
            if ((endpointConfiguration == EndpointConfiguration.NumberplanPublicSoap12))
            {
                return new System.ServiceModel.EndpointAddress("https://services.intele.no/numberplan/public.asmx");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        public enum EndpointConfiguration
        {
            
            NumberplanPublicSoap,
            
            NumberplanPublicSoap12,
        }
    }
}
