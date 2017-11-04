﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.17929.
// 
#pragma warning disable 1591

namespace SocioboardDataScheduler.Api.Youtube {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="YoutubeSoap", Namespace="http://tempuri.org/")]
    public partial class Youtube : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback AddYoutubeAccountOperationCompleted;
        
        private System.Threading.SendOrPostCallback getYoutubeDataOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public Youtube() {
            this.Url = global::SocioboardDataScheduler.Properties.Settings.Default.SocioboardDataScheduler_Api_Youtube_Youtube;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event AddYoutubeAccountCompletedEventHandler AddYoutubeAccountCompleted;
        
        /// <remarks/>
        public event getYoutubeDataCompletedEventHandler getYoutubeDataCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/AddYoutubeAccount", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string AddYoutubeAccount(string client_id, string client_secret, string redirect_uri, string UserId, string GroupId, string code) {
            object[] results = this.Invoke("AddYoutubeAccount", new object[] {
                        client_id,
                        client_secret,
                        redirect_uri,
                        UserId,
                        GroupId,
                        code});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void AddYoutubeAccountAsync(string client_id, string client_secret, string redirect_uri, string UserId, string GroupId, string code) {
            this.AddYoutubeAccountAsync(client_id, client_secret, redirect_uri, UserId, GroupId, code, null);
        }
        
        /// <remarks/>
        public void AddYoutubeAccountAsync(string client_id, string client_secret, string redirect_uri, string UserId, string GroupId, string code, object userState) {
            if ((this.AddYoutubeAccountOperationCompleted == null)) {
                this.AddYoutubeAccountOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAddYoutubeAccountOperationCompleted);
            }
            this.InvokeAsync("AddYoutubeAccount", new object[] {
                        client_id,
                        client_secret,
                        redirect_uri,
                        UserId,
                        GroupId,
                        code}, this.AddYoutubeAccountOperationCompleted, userState);
        }
        
        private void OnAddYoutubeAccountOperationCompleted(object arg) {
            if ((this.AddYoutubeAccountCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.AddYoutubeAccountCompleted(this, new AddYoutubeAccountCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/getYoutubeData", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void getYoutubeData(string UserId, string youtubeId) {
            this.Invoke("getYoutubeData", new object[] {
                        UserId,
                        youtubeId});
        }
        
        /// <remarks/>
        public void getYoutubeDataAsync(string UserId, string youtubeId) {
            this.getYoutubeDataAsync(UserId, youtubeId, null);
        }
        
        /// <remarks/>
        public void getYoutubeDataAsync(string UserId, string youtubeId, object userState) {
            if ((this.getYoutubeDataOperationCompleted == null)) {
                this.getYoutubeDataOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetYoutubeDataOperationCompleted);
            }
            this.InvokeAsync("getYoutubeData", new object[] {
                        UserId,
                        youtubeId}, this.getYoutubeDataOperationCompleted, userState);
        }
        
        private void OngetYoutubeDataOperationCompleted(object arg) {
            if ((this.getYoutubeDataCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getYoutubeDataCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void AddYoutubeAccountCompletedEventHandler(object sender, AddYoutubeAccountCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AddYoutubeAccountCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal AddYoutubeAccountCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void getYoutubeDataCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
}

#pragma warning restore 1591