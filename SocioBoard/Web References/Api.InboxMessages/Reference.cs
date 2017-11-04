﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.34014.
// 
#pragma warning disable 1591

namespace Socioboard.Api.InboxMessages {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="InboxMessagesSoap", Namespace="http://tempuri.org/")]
    public partial class InboxMessages : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetInboxMessageOperationCompleted;
        
        private System.Threading.SendOrPostCallback getInboxMessageByMessageIdOperationCompleted;
        
        private System.Threading.SendOrPostCallback getInboxMessageCountOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetAllFollowersOfUserOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetTwitterMentionCountOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetTwitterRetweetCountOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetTwitterFollowersCountOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetTwitterFollowersOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetInstagramFollowerOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetInstagramFollowingOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public InboxMessages() {
            this.Url = global::Socioboard.Properties.Settings.Default.Socioboard_Api_InboxMessages_InboxMessages;
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
        public event GetInboxMessageCompletedEventHandler GetInboxMessageCompleted;
        
        /// <remarks/>
        public event getInboxMessageByMessageIdCompletedEventHandler getInboxMessageByMessageIdCompleted;
        
        /// <remarks/>
        public event getInboxMessageCountCompletedEventHandler getInboxMessageCountCompleted;
        
        /// <remarks/>
        public event GetAllFollowersOfUserCompletedEventHandler GetAllFollowersOfUserCompleted;
        
        /// <remarks/>
        public event GetTwitterMentionCountCompletedEventHandler GetTwitterMentionCountCompleted;
        
        /// <remarks/>
        public event GetTwitterRetweetCountCompletedEventHandler GetTwitterRetweetCountCompleted;
        
        /// <remarks/>
        public event GetTwitterFollowersCountCompletedEventHandler GetTwitterFollowersCountCompleted;
        
        /// <remarks/>
        public event GetTwitterFollowersCompletedEventHandler GetTwitterFollowersCompleted;
        
        /// <remarks/>
        public event GetInstagramFollowerCompletedEventHandler GetInstagramFollowerCompleted;
        
        /// <remarks/>
        public event GetInstagramFollowingCompletedEventHandler GetInstagramFollowingCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetInboxMessage", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetInboxMessage(string UserId, string ProfileIds, string MessageType, string noOfDataToSkip, string noOfDataFromTop) {
            object[] results = this.Invoke("GetInboxMessage", new object[] {
                        UserId,
                        ProfileIds,
                        MessageType,
                        noOfDataToSkip,
                        noOfDataFromTop});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetInboxMessageAsync(string UserId, string ProfileIds, string MessageType, string noOfDataToSkip, string noOfDataFromTop) {
            this.GetInboxMessageAsync(UserId, ProfileIds, MessageType, noOfDataToSkip, noOfDataFromTop, null);
        }
        
        /// <remarks/>
        public void GetInboxMessageAsync(string UserId, string ProfileIds, string MessageType, string noOfDataToSkip, string noOfDataFromTop, object userState) {
            if ((this.GetInboxMessageOperationCompleted == null)) {
                this.GetInboxMessageOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetInboxMessageOperationCompleted);
            }
            this.InvokeAsync("GetInboxMessage", new object[] {
                        UserId,
                        ProfileIds,
                        MessageType,
                        noOfDataToSkip,
                        noOfDataFromTop}, this.GetInboxMessageOperationCompleted, userState);
        }
        
        private void OnGetInboxMessageOperationCompleted(object arg) {
            if ((this.GetInboxMessageCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetInboxMessageCompleted(this, new GetInboxMessageCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/getInboxMessageByMessageId", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string getInboxMessageByMessageId(string UserId, string MessageId) {
            object[] results = this.Invoke("getInboxMessageByMessageId", new object[] {
                        UserId,
                        MessageId});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void getInboxMessageByMessageIdAsync(string UserId, string MessageId) {
            this.getInboxMessageByMessageIdAsync(UserId, MessageId, null);
        }
        
        /// <remarks/>
        public void getInboxMessageByMessageIdAsync(string UserId, string MessageId, object userState) {
            if ((this.getInboxMessageByMessageIdOperationCompleted == null)) {
                this.getInboxMessageByMessageIdOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetInboxMessageByMessageIdOperationCompleted);
            }
            this.InvokeAsync("getInboxMessageByMessageId", new object[] {
                        UserId,
                        MessageId}, this.getInboxMessageByMessageIdOperationCompleted, userState);
        }
        
        private void OngetInboxMessageByMessageIdOperationCompleted(object arg) {
            if ((this.getInboxMessageByMessageIdCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getInboxMessageByMessageIdCompleted(this, new getInboxMessageByMessageIdCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/getInboxMessageCount", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string getInboxMessageCount(string UserId, string ProfileId) {
            object[] results = this.Invoke("getInboxMessageCount", new object[] {
                        UserId,
                        ProfileId});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void getInboxMessageCountAsync(string UserId, string ProfileId) {
            this.getInboxMessageCountAsync(UserId, ProfileId, null);
        }
        
        /// <remarks/>
        public void getInboxMessageCountAsync(string UserId, string ProfileId, object userState) {
            if ((this.getInboxMessageCountOperationCompleted == null)) {
                this.getInboxMessageCountOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetInboxMessageCountOperationCompleted);
            }
            this.InvokeAsync("getInboxMessageCount", new object[] {
                        UserId,
                        ProfileId}, this.getInboxMessageCountOperationCompleted, userState);
        }
        
        private void OngetInboxMessageCountOperationCompleted(object arg) {
            if ((this.getInboxMessageCountCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getInboxMessageCountCompleted(this, new getInboxMessageCountCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetAllFollowersOfUser", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetAllFollowersOfUser(string userid, string profileid) {
            object[] results = this.Invoke("GetAllFollowersOfUser", new object[] {
                        userid,
                        profileid});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetAllFollowersOfUserAsync(string userid, string profileid) {
            this.GetAllFollowersOfUserAsync(userid, profileid, null);
        }
        
        /// <remarks/>
        public void GetAllFollowersOfUserAsync(string userid, string profileid, object userState) {
            if ((this.GetAllFollowersOfUserOperationCompleted == null)) {
                this.GetAllFollowersOfUserOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetAllFollowersOfUserOperationCompleted);
            }
            this.InvokeAsync("GetAllFollowersOfUser", new object[] {
                        userid,
                        profileid}, this.GetAllFollowersOfUserOperationCompleted, userState);
        }
        
        private void OnGetAllFollowersOfUserOperationCompleted(object arg) {
            if ((this.GetAllFollowersOfUserCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetAllFollowersOfUserCompleted(this, new GetAllFollowersOfUserCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetTwitterMentionCount", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetTwitterMentionCount(string UserId, string profileids, string days) {
            object[] results = this.Invoke("GetTwitterMentionCount", new object[] {
                        UserId,
                        profileids,
                        days});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetTwitterMentionCountAsync(string UserId, string profileids, string days) {
            this.GetTwitterMentionCountAsync(UserId, profileids, days, null);
        }
        
        /// <remarks/>
        public void GetTwitterMentionCountAsync(string UserId, string profileids, string days, object userState) {
            if ((this.GetTwitterMentionCountOperationCompleted == null)) {
                this.GetTwitterMentionCountOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetTwitterMentionCountOperationCompleted);
            }
            this.InvokeAsync("GetTwitterMentionCount", new object[] {
                        UserId,
                        profileids,
                        days}, this.GetTwitterMentionCountOperationCompleted, userState);
        }
        
        private void OnGetTwitterMentionCountOperationCompleted(object arg) {
            if ((this.GetTwitterMentionCountCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetTwitterMentionCountCompleted(this, new GetTwitterMentionCountCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetTwitterRetweetCount", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetTwitterRetweetCount(string UserId, string profileids, string days) {
            object[] results = this.Invoke("GetTwitterRetweetCount", new object[] {
                        UserId,
                        profileids,
                        days});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetTwitterRetweetCountAsync(string UserId, string profileids, string days) {
            this.GetTwitterRetweetCountAsync(UserId, profileids, days, null);
        }
        
        /// <remarks/>
        public void GetTwitterRetweetCountAsync(string UserId, string profileids, string days, object userState) {
            if ((this.GetTwitterRetweetCountOperationCompleted == null)) {
                this.GetTwitterRetweetCountOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetTwitterRetweetCountOperationCompleted);
            }
            this.InvokeAsync("GetTwitterRetweetCount", new object[] {
                        UserId,
                        profileids,
                        days}, this.GetTwitterRetweetCountOperationCompleted, userState);
        }
        
        private void OnGetTwitterRetweetCountOperationCompleted(object arg) {
            if ((this.GetTwitterRetweetCountCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetTwitterRetweetCountCompleted(this, new GetTwitterRetweetCountCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetTwitterFollowersCount", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetTwitterFollowersCount(string UserId, string profileids, string days) {
            object[] results = this.Invoke("GetTwitterFollowersCount", new object[] {
                        UserId,
                        profileids,
                        days});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetTwitterFollowersCountAsync(string UserId, string profileids, string days) {
            this.GetTwitterFollowersCountAsync(UserId, profileids, days, null);
        }
        
        /// <remarks/>
        public void GetTwitterFollowersCountAsync(string UserId, string profileids, string days, object userState) {
            if ((this.GetTwitterFollowersCountOperationCompleted == null)) {
                this.GetTwitterFollowersCountOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetTwitterFollowersCountOperationCompleted);
            }
            this.InvokeAsync("GetTwitterFollowersCount", new object[] {
                        UserId,
                        profileids,
                        days}, this.GetTwitterFollowersCountOperationCompleted, userState);
        }
        
        private void OnGetTwitterFollowersCountOperationCompleted(object arg) {
            if ((this.GetTwitterFollowersCountCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetTwitterFollowersCountCompleted(this, new GetTwitterFollowersCountCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetTwitterFollowers", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetTwitterFollowers(string UserId, string profileids, string days) {
            object[] results = this.Invoke("GetTwitterFollowers", new object[] {
                        UserId,
                        profileids,
                        days});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetTwitterFollowersAsync(string UserId, string profileids, string days) {
            this.GetTwitterFollowersAsync(UserId, profileids, days, null);
        }
        
        /// <remarks/>
        public void GetTwitterFollowersAsync(string UserId, string profileids, string days, object userState) {
            if ((this.GetTwitterFollowersOperationCompleted == null)) {
                this.GetTwitterFollowersOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetTwitterFollowersOperationCompleted);
            }
            this.InvokeAsync("GetTwitterFollowers", new object[] {
                        UserId,
                        profileids,
                        days}, this.GetTwitterFollowersOperationCompleted, userState);
        }
        
        private void OnGetTwitterFollowersOperationCompleted(object arg) {
            if ((this.GetTwitterFollowersCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetTwitterFollowersCompleted(this, new GetTwitterFollowersCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetInstagramFollower", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetInstagramFollower(string UserId, string ProfileIds, string days) {
            object[] results = this.Invoke("GetInstagramFollower", new object[] {
                        UserId,
                        ProfileIds,
                        days});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetInstagramFollowerAsync(string UserId, string ProfileIds, string days) {
            this.GetInstagramFollowerAsync(UserId, ProfileIds, days, null);
        }
        
        /// <remarks/>
        public void GetInstagramFollowerAsync(string UserId, string ProfileIds, string days, object userState) {
            if ((this.GetInstagramFollowerOperationCompleted == null)) {
                this.GetInstagramFollowerOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetInstagramFollowerOperationCompleted);
            }
            this.InvokeAsync("GetInstagramFollower", new object[] {
                        UserId,
                        ProfileIds,
                        days}, this.GetInstagramFollowerOperationCompleted, userState);
        }
        
        private void OnGetInstagramFollowerOperationCompleted(object arg) {
            if ((this.GetInstagramFollowerCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetInstagramFollowerCompleted(this, new GetInstagramFollowerCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetInstagramFollowing", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetInstagramFollowing(string UserId, string ProfileIds, string days) {
            object[] results = this.Invoke("GetInstagramFollowing", new object[] {
                        UserId,
                        ProfileIds,
                        days});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetInstagramFollowingAsync(string UserId, string ProfileIds, string days) {
            this.GetInstagramFollowingAsync(UserId, ProfileIds, days, null);
        }
        
        /// <remarks/>
        public void GetInstagramFollowingAsync(string UserId, string ProfileIds, string days, object userState) {
            if ((this.GetInstagramFollowingOperationCompleted == null)) {
                this.GetInstagramFollowingOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetInstagramFollowingOperationCompleted);
            }
            this.InvokeAsync("GetInstagramFollowing", new object[] {
                        UserId,
                        ProfileIds,
                        days}, this.GetInstagramFollowingOperationCompleted, userState);
        }
        
        private void OnGetInstagramFollowingOperationCompleted(object arg) {
            if ((this.GetInstagramFollowingCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetInstagramFollowingCompleted(this, new GetInstagramFollowingCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    public delegate void GetInboxMessageCompletedEventHandler(object sender, GetInboxMessageCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetInboxMessageCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetInboxMessageCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    public delegate void getInboxMessageByMessageIdCompletedEventHandler(object sender, getInboxMessageByMessageIdCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getInboxMessageByMessageIdCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getInboxMessageByMessageIdCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    public delegate void getInboxMessageCountCompletedEventHandler(object sender, getInboxMessageCountCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getInboxMessageCountCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getInboxMessageCountCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    public delegate void GetAllFollowersOfUserCompletedEventHandler(object sender, GetAllFollowersOfUserCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetAllFollowersOfUserCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetAllFollowersOfUserCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    public delegate void GetTwitterMentionCountCompletedEventHandler(object sender, GetTwitterMentionCountCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetTwitterMentionCountCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetTwitterMentionCountCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    public delegate void GetTwitterRetweetCountCompletedEventHandler(object sender, GetTwitterRetweetCountCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetTwitterRetweetCountCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetTwitterRetweetCountCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    public delegate void GetTwitterFollowersCountCompletedEventHandler(object sender, GetTwitterFollowersCountCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetTwitterFollowersCountCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetTwitterFollowersCountCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    public delegate void GetTwitterFollowersCompletedEventHandler(object sender, GetTwitterFollowersCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetTwitterFollowersCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetTwitterFollowersCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    public delegate void GetInstagramFollowerCompletedEventHandler(object sender, GetInstagramFollowerCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetInstagramFollowerCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetInstagramFollowerCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    public delegate void GetInstagramFollowingCompletedEventHandler(object sender, GetInstagramFollowingCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetInstagramFollowingCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetInstagramFollowingCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
}

#pragma warning restore 1591