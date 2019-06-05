﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApp.OrderService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="OrderEntity", Namespace="http://schemas.datacontract.org/2004/07/Order.Core")]
    [System.SerializableAttribute()]
    public partial class OrderEntity : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string OrderIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal PriceField;
        
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
        public string OrderId {
            get {
                return this.OrderIdField;
            }
            set {
                if ((object.ReferenceEquals(this.OrderIdField, value) != true)) {
                    this.OrderIdField = value;
                    this.RaisePropertyChanged("OrderId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Price {
            get {
                return this.PriceField;
            }
            set {
                if ((this.PriceField.Equals(value) != true)) {
                    this.PriceField = value;
                    this.RaisePropertyChanged("Price");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="OrderService.IOrderService")]
    public interface IOrderService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderService/Add", ReplyAction="http://tempuri.org/IOrderService/AddResponse")]
        bool Add();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderService/Add", ReplyAction="http://tempuri.org/IOrderService/AddResponse")]
        System.Threading.Tasks.Task<bool> AddAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderService/Modify", ReplyAction="http://tempuri.org/IOrderService/ModifyResponse")]
        bool Modify();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderService/Modify", ReplyAction="http://tempuri.org/IOrderService/ModifyResponse")]
        System.Threading.Tasks.Task<bool> ModifyAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderService/Remove", ReplyAction="http://tempuri.org/IOrderService/RemoveResponse")]
        bool Remove();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderService/Remove", ReplyAction="http://tempuri.org/IOrderService/RemoveResponse")]
        System.Threading.Tasks.Task<bool> RemoveAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderService/Find", ReplyAction="http://tempuri.org/IOrderService/FindResponse")]
        WebApp.OrderService.OrderEntity Find();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderService/Find", ReplyAction="http://tempuri.org/IOrderService/FindResponse")]
        System.Threading.Tasks.Task<WebApp.OrderService.OrderEntity> FindAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IOrderServiceChannel : WebApp.OrderService.IOrderService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class OrderServiceClient : System.ServiceModel.ClientBase<WebApp.OrderService.IOrderService>, WebApp.OrderService.IOrderService {
        
        public OrderServiceClient() {
        }
        
        public OrderServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public OrderServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public OrderServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public OrderServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool Add() {
            return base.Channel.Add();
        }
        
        public System.Threading.Tasks.Task<bool> AddAsync() {
            return base.Channel.AddAsync();
        }
        
        public bool Modify() {
            return base.Channel.Modify();
        }
        
        public System.Threading.Tasks.Task<bool> ModifyAsync() {
            return base.Channel.ModifyAsync();
        }
        
        public bool Remove() {
            return base.Channel.Remove();
        }
        
        public System.Threading.Tasks.Task<bool> RemoveAsync() {
            return base.Channel.RemoveAsync();
        }
        
        public WebApp.OrderService.OrderEntity Find() {
            return base.Channel.Find();
        }
        
        public System.Threading.Tasks.Task<WebApp.OrderService.OrderEntity> FindAsync() {
            return base.Channel.FindAsync();
        }
    }
}
