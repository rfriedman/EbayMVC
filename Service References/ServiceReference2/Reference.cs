﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EbayMVC.ServiceReference2 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="tblItem", Namespace="http://schemas.datacontract.org/2004/07/EbayFactory")]
    [System.SerializableAttribute()]
    public partial class tblItem : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string gallery_urlField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string item_categoryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string item_idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string item_titleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string listing_urlField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private EbayMVC.ServiceReference2.tblCategory tblCategoryField;
        
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
        public string gallery_url {
            get {
                return this.gallery_urlField;
            }
            set {
                if ((object.ReferenceEquals(this.gallery_urlField, value) != true)) {
                    this.gallery_urlField = value;
                    this.RaisePropertyChanged("gallery_url");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string item_category {
            get {
                return this.item_categoryField;
            }
            set {
                if ((object.ReferenceEquals(this.item_categoryField, value) != true)) {
                    this.item_categoryField = value;
                    this.RaisePropertyChanged("item_category");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string item_id {
            get {
                return this.item_idField;
            }
            set {
                if ((object.ReferenceEquals(this.item_idField, value) != true)) {
                    this.item_idField = value;
                    this.RaisePropertyChanged("item_id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string item_title {
            get {
                return this.item_titleField;
            }
            set {
                if ((object.ReferenceEquals(this.item_titleField, value) != true)) {
                    this.item_titleField = value;
                    this.RaisePropertyChanged("item_title");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string listing_url {
            get {
                return this.listing_urlField;
            }
            set {
                if ((object.ReferenceEquals(this.listing_urlField, value) != true)) {
                    this.listing_urlField = value;
                    this.RaisePropertyChanged("listing_url");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public EbayMVC.ServiceReference2.tblCategory tblCategory {
            get {
                return this.tblCategoryField;
            }
            set {
                if ((object.ReferenceEquals(this.tblCategoryField, value) != true)) {
                    this.tblCategoryField = value;
                    this.RaisePropertyChanged("tblCategory");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="tblCategory", Namespace="http://schemas.datacontract.org/2004/07/EbayFactory")]
    [System.SerializableAttribute()]
    public partial class tblCategory : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string category_idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string category_levelField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string category_nameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string category_parentField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private EbayMVC.ServiceReference2.tblItem[] tblItemsField;
        
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
        public string category_id {
            get {
                return this.category_idField;
            }
            set {
                if ((object.ReferenceEquals(this.category_idField, value) != true)) {
                    this.category_idField = value;
                    this.RaisePropertyChanged("category_id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string category_level {
            get {
                return this.category_levelField;
            }
            set {
                if ((object.ReferenceEquals(this.category_levelField, value) != true)) {
                    this.category_levelField = value;
                    this.RaisePropertyChanged("category_level");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string category_name {
            get {
                return this.category_nameField;
            }
            set {
                if ((object.ReferenceEquals(this.category_nameField, value) != true)) {
                    this.category_nameField = value;
                    this.RaisePropertyChanged("category_name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string category_parent {
            get {
                return this.category_parentField;
            }
            set {
                if ((object.ReferenceEquals(this.category_parentField, value) != true)) {
                    this.category_parentField = value;
                    this.RaisePropertyChanged("category_parent");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public EbayMVC.ServiceReference2.tblItem[] tblItems {
            get {
                return this.tblItemsField;
            }
            set {
                if ((object.ReferenceEquals(this.tblItemsField, value) != true)) {
                    this.tblItemsField = value;
                    this.RaisePropertyChanged("tblItems");
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="EbayClient", ConfigurationName="ServiceReference2.IEbayClient")]
    public interface IEbayClient {
        
        [System.ServiceModel.OperationContractAttribute(Action="EbayClient/IEbayClient/FindByCategory", ReplyAction="EbayClient/IEbayClient/FindByCategoryResponse")]
        void FindByCategory(string[] items);
        
        [System.ServiceModel.OperationContractAttribute(Action="EbayClient/IEbayClient/EbayTopLevelCategories", ReplyAction="EbayClient/IEbayClient/EbayTopLevelCategoriesResponse")]
        void EbayTopLevelCategories();
        
        [System.ServiceModel.OperationContractAttribute(Action="EbayClient/IEbayClient/GetCategories", ReplyAction="EbayClient/IEbayClient/GetCategoriesResponse")]
        string[] GetCategories();
        
        [System.ServiceModel.OperationContractAttribute(Action="EbayClient/IEbayClient/ItemByCategory", ReplyAction="EbayClient/IEbayClient/ItemByCategoryResponse")]
        EbayMVC.ServiceReference2.tblItem[] ItemByCategory(string cat);
        
        [System.ServiceModel.OperationContractAttribute(Action="EbayClient/IEbayClient/CreateSiteDataBase", ReplyAction="EbayClient/IEbayClient/CreateSiteDataBaseResponse")]
        void CreateSiteDataBase();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEbayClientChannel : EbayMVC.ServiceReference2.IEbayClient, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EbayClientClient : System.ServiceModel.ClientBase<EbayMVC.ServiceReference2.IEbayClient>, EbayMVC.ServiceReference2.IEbayClient {
        
        public EbayClientClient() {
        }
        
        public EbayClientClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EbayClientClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EbayClientClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EbayClientClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void FindByCategory(string[] items) {
            base.Channel.FindByCategory(items);
        }
        
        public void EbayTopLevelCategories() {
            base.Channel.EbayTopLevelCategories();
        }
        
        public string[] GetCategories() {
            return base.Channel.GetCategories();
        }
        
        public EbayMVC.ServiceReference2.tblItem[] ItemByCategory(string cat) {
            return base.Channel.ItemByCategory(cat);
        }
        
        public void CreateSiteDataBase() {
            base.Channel.CreateSiteDataBase();
        }
    }
}
