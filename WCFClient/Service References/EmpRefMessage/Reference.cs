﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCFClient.EmpRefMessage {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Employee", Namespace="http://schemas.datacontract.org/2004/07/WcfMessageContract")]
    [System.SerializableAttribute()]
    public partial class Employee : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CompanyNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int EmployeeIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string JoiningDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Address {
            get {
                return this.AddressField;
            }
            set {
                if ((object.ReferenceEquals(this.AddressField, value) != true)) {
                    this.AddressField = value;
                    this.RaisePropertyChanged("Address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CompanyName {
            get {
                return this.CompanyNameField;
            }
            set {
                if ((object.ReferenceEquals(this.CompanyNameField, value) != true)) {
                    this.CompanyNameField = value;
                    this.RaisePropertyChanged("CompanyName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int EmployeeId {
            get {
                return this.EmployeeIdField;
            }
            set {
                if ((this.EmployeeIdField.Equals(value) != true)) {
                    this.EmployeeIdField = value;
                    this.RaisePropertyChanged("EmployeeId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string JoiningDate {
            get {
                return this.JoiningDateField;
            }
            set {
                if ((object.ReferenceEquals(this.JoiningDateField, value) != true)) {
                    this.JoiningDateField = value;
                    this.RaisePropertyChanged("JoiningDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="EmpRefMessage.IEmployeeService")]
    public interface IEmployeeService {
        
        // CODEGEN: Generating message contract since the operation GetEmployeeById is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/GetEmployeeById", ReplyAction="http://tempuri.org/IEmployeeService/GetEmployeeByIdResponse")]
        WCFClient.EmpRefMessage.EmployeeInfoResponseMessage GetEmployeeById(WCFClient.EmpRefMessage.EmployeeInfoRequestMessage request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/GetEmployeeById", ReplyAction="http://tempuri.org/IEmployeeService/GetEmployeeByIdResponse")]
        System.Threading.Tasks.Task<WCFClient.EmpRefMessage.EmployeeInfoResponseMessage> GetEmployeeByIdAsync(WCFClient.EmpRefMessage.EmployeeInfoRequestMessage request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class EmployeeInfoRequestMessage {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public string AuthenticationCode;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public int EmployeeId;
        
        public EmployeeInfoRequestMessage() {
        }
        
        public EmployeeInfoRequestMessage(string AuthenticationCode, int EmployeeId) {
            this.AuthenticationCode = AuthenticationCode;
            this.EmployeeId = EmployeeId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class EmployeeInfoResponseMessage {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public WCFClient.EmpRefMessage.Employee EmployeeInfo;
        
        public EmployeeInfoResponseMessage() {
        }
        
        public EmployeeInfoResponseMessage(WCFClient.EmpRefMessage.Employee EmployeeInfo) {
            this.EmployeeInfo = EmployeeInfo;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEmployeeServiceChannel : WCFClient.EmpRefMessage.IEmployeeService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EmployeeServiceClient : System.ServiceModel.ClientBase<WCFClient.EmpRefMessage.IEmployeeService>, WCFClient.EmpRefMessage.IEmployeeService {
        
        public EmployeeServiceClient() {
        }
        
        public EmployeeServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EmployeeServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmployeeServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmployeeServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WCFClient.EmpRefMessage.EmployeeInfoResponseMessage WCFClient.EmpRefMessage.IEmployeeService.GetEmployeeById(WCFClient.EmpRefMessage.EmployeeInfoRequestMessage request) {
            return base.Channel.GetEmployeeById(request);
        }
        
        public WCFClient.EmpRefMessage.Employee GetEmployeeById(string AuthenticationCode, int EmployeeId) {
            WCFClient.EmpRefMessage.EmployeeInfoRequestMessage inValue = new WCFClient.EmpRefMessage.EmployeeInfoRequestMessage();
            inValue.AuthenticationCode = AuthenticationCode;
            inValue.EmployeeId = EmployeeId;
            WCFClient.EmpRefMessage.EmployeeInfoResponseMessage retVal = ((WCFClient.EmpRefMessage.IEmployeeService)(this)).GetEmployeeById(inValue);
            return retVal.EmployeeInfo;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WCFClient.EmpRefMessage.EmployeeInfoResponseMessage> WCFClient.EmpRefMessage.IEmployeeService.GetEmployeeByIdAsync(WCFClient.EmpRefMessage.EmployeeInfoRequestMessage request) {
            return base.Channel.GetEmployeeByIdAsync(request);
        }
        
        public System.Threading.Tasks.Task<WCFClient.EmpRefMessage.EmployeeInfoResponseMessage> GetEmployeeByIdAsync(string AuthenticationCode, int EmployeeId) {
            WCFClient.EmpRefMessage.EmployeeInfoRequestMessage inValue = new WCFClient.EmpRefMessage.EmployeeInfoRequestMessage();
            inValue.AuthenticationCode = AuthenticationCode;
            inValue.EmployeeId = EmployeeId;
            return ((WCFClient.EmpRefMessage.IEmployeeService)(this)).GetEmployeeByIdAsync(inValue);
        }
    }
}
