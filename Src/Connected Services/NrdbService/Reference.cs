﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NrdbService
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.ServiceContractAttribute(Name="Nrdb Lookup ServiceSoap", Namespace="intelesms.services", ConfigurationName="NrdbService.NrdbLookupServiceSoap")]
    public interface NrdbLookupServiceSoap
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="intelesms.services/Query", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<NrdbService.NrdbStatus> QueryAsync(NrdbService.LoginClass login, long mobile);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="intelesms.services")]
    public partial class LoginClass
    {
        
        private int customerIdField;
        
        private string passwordField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int CustomerId
        {
            get
            {
                return this.customerIdField;
            }
            set
            {
                this.customerIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Password
        {
            get
            {
                return this.passwordField;
            }
            set
            {
                this.passwordField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="intelesms.services")]
    public partial class NrdbStatus
    {
        
        private ErrorCodeEnum errorCodeField;
        
        private string errorCodeDescriptionField;
        
        private long msisdnField;
        
        private int mncField;
        
        private int mccField;
        
        private int spidField;
        
        private System.DateTime queryDateField;
        
        private bool hasChangedField;
        
        private int queriesLeftField;
        
        private int queryTimeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public ErrorCodeEnum ErrorCode
        {
            get
            {
                return this.errorCodeField;
            }
            set
            {
                this.errorCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string ErrorCodeDescription
        {
            get
            {
                return this.errorCodeDescriptionField;
            }
            set
            {
                this.errorCodeDescriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public long Msisdn
        {
            get
            {
                return this.msisdnField;
            }
            set
            {
                this.msisdnField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public int Mnc
        {
            get
            {
                return this.mncField;
            }
            set
            {
                this.mncField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public int Mcc
        {
            get
            {
                return this.mccField;
            }
            set
            {
                this.mccField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public int Spid
        {
            get
            {
                return this.spidField;
            }
            set
            {
                this.spidField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public System.DateTime QueryDate
        {
            get
            {
                return this.queryDateField;
            }
            set
            {
                this.queryDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public bool HasChanged
        {
            get
            {
                return this.hasChangedField;
            }
            set
            {
                this.hasChangedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public int QueriesLeft
        {
            get
            {
                return this.queriesLeftField;
            }
            set
            {
                this.queriesLeftField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=9)]
        public int QueryTime
        {
            get
            {
                return this.queryTimeField;
            }
            set
            {
                this.queryTimeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="intelesms.services")]
	public enum ErrorCodeEnum
	{

		ClientSystemError = -5,
		ClientInvalidLogin = -4,
		ClientMaxQueryReached = -3,
		ClientInvalidMsisdn = -2,
		ClientInetFailure = -1,

		Success = 0,

		RemoteInvalidMsisdn = 1,
		RemoteNonExistingNumber = 2,
		RemoteSystemError = 3,
		RemoteMaxQueryReached = 4,
		RemoteInvalidLogin = 5

	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public interface NrdbLookupServiceSoapChannel : NrdbService.NrdbLookupServiceSoap, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public partial class NrdbLookupServiceSoapClient : System.ServiceModel.ClientBase<NrdbService.NrdbLookupServiceSoap>, NrdbService.NrdbLookupServiceSoap
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public NrdbLookupServiceSoapClient(EndpointConfiguration endpointConfiguration) : 
                base(NrdbLookupServiceSoapClient.GetBindingForEndpoint(endpointConfiguration), NrdbLookupServiceSoapClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public NrdbLookupServiceSoapClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(NrdbLookupServiceSoapClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public NrdbLookupServiceSoapClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(NrdbLookupServiceSoapClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public NrdbLookupServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<NrdbService.NrdbStatus> QueryAsync(NrdbService.LoginClass login, long mobile)
        {
            return base.Channel.QueryAsync(login, mobile);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.Nrdb_x0020_Lookup_x0020_ServiceSoap))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                result.Security.Mode = System.ServiceModel.BasicHttpSecurityMode.Transport;
                return result;
            }
            if ((endpointConfiguration == EndpointConfiguration.Nrdb_x0020_Lookup_x0020_ServiceSoap12))
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
            if ((endpointConfiguration == EndpointConfiguration.Nrdb_x0020_Lookup_x0020_ServiceSoap))
            {
                return new System.ServiceModel.EndpointAddress("https://services.intele.no/nrdb/script.asmx");
            }
            if ((endpointConfiguration == EndpointConfiguration.Nrdb_x0020_Lookup_x0020_ServiceSoap12))
            {
                return new System.ServiceModel.EndpointAddress("https://services.intele.no/nrdb/script.asmx");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        public enum EndpointConfiguration
        {
            
            Nrdb_x0020_Lookup_x0020_ServiceSoap,
            
            Nrdb_x0020_Lookup_x0020_ServiceSoap12,
        }
    }
}
