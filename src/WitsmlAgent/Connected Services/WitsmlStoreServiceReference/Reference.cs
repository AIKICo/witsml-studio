﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WitsmlAgent.WitsmlStoreServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.witsml.org/wsdl/120", ConfigurationName="WitsmlStoreServiceReference.IWitsmlStore")]
    public interface IWitsmlStore {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.witsml.org/action/120/Store.WMLS_AddToStore", ReplyAction="http://www.witsml.org/wsdl/120/IWitsmlStore/WMLS_AddToStoreResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        WitsmlAgent.WitsmlStoreServiceReference.WMLS_AddToStoreResponse WMLS_AddToStore(WitsmlAgent.WitsmlStoreServiceReference.WMLS_AddToStoreRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://www.witsml.org/action/120/Store.WMLS_AddToStore", ReplyAction="http://www.witsml.org/wsdl/120/IWitsmlStore/WMLS_AddToStoreResponse")]
        System.Threading.Tasks.Task<WitsmlAgent.WitsmlStoreServiceReference.WMLS_AddToStoreResponse> WMLS_AddToStoreAsync(WitsmlAgent.WitsmlStoreServiceReference.WMLS_AddToStoreRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.witsml.org/action/120/Store.WMLS_DeleteFromStore", ReplyAction="http://www.witsml.org/wsdl/120/IWitsmlStore/WMLS_DeleteFromStoreResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        WitsmlAgent.WitsmlStoreServiceReference.WMLS_DeleteFromStoreResponse WMLS_DeleteFromStore(WitsmlAgent.WitsmlStoreServiceReference.WMLS_DeleteFromStoreRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://www.witsml.org/action/120/Store.WMLS_DeleteFromStore", ReplyAction="http://www.witsml.org/wsdl/120/IWitsmlStore/WMLS_DeleteFromStoreResponse")]
        System.Threading.Tasks.Task<WitsmlAgent.WitsmlStoreServiceReference.WMLS_DeleteFromStoreResponse> WMLS_DeleteFromStoreAsync(WitsmlAgent.WitsmlStoreServiceReference.WMLS_DeleteFromStoreRequest request);
        
        // CODEGEN: Generating message contract since the wrapper namespace (http://www.witsml.org/message/120) of message WMLS_GetBaseMsgRequest does not match the default value (http://www.witsml.org/wsdl/120)
        [System.ServiceModel.OperationContractAttribute(Action="http://www.witsml.org/action/120/Store.WMLS_GetBaseMsg", ReplyAction="http://www.witsml.org/wsdl/120/IWitsmlStore/WMLS_GetBaseMsgResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        WitsmlAgent.WitsmlStoreServiceReference.WMLS_GetBaseMsgResponse WMLS_GetBaseMsg(WitsmlAgent.WitsmlStoreServiceReference.WMLS_GetBaseMsgRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.witsml.org/action/120/Store.WMLS_GetBaseMsg", ReplyAction="http://www.witsml.org/wsdl/120/IWitsmlStore/WMLS_GetBaseMsgResponse")]
        System.Threading.Tasks.Task<WitsmlAgent.WitsmlStoreServiceReference.WMLS_GetBaseMsgResponse> WMLS_GetBaseMsgAsync(WitsmlAgent.WitsmlStoreServiceReference.WMLS_GetBaseMsgRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.witsml.org/action/120/Store.WMLS_GetCap", ReplyAction="http://www.witsml.org/wsdl/120/IWitsmlStore/WMLS_GetCapResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        WitsmlAgent.WitsmlStoreServiceReference.WMLS_GetCapResponse WMLS_GetCap(WitsmlAgent.WitsmlStoreServiceReference.WMLS_GetCapRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://www.witsml.org/action/120/Store.WMLS_GetCap", ReplyAction="http://www.witsml.org/wsdl/120/IWitsmlStore/WMLS_GetCapResponse")]
        System.Threading.Tasks.Task<WitsmlAgent.WitsmlStoreServiceReference.WMLS_GetCapResponse> WMLS_GetCapAsync(WitsmlAgent.WitsmlStoreServiceReference.WMLS_GetCapRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.witsml.org/action/120/Store.WMLS_GetFromStore", ReplyAction="http://www.witsml.org/wsdl/120/IWitsmlStore/WMLS_GetFromStoreResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        WitsmlAgent.WitsmlStoreServiceReference.WMLS_GetFromStoreResponse WMLS_GetFromStore(WitsmlAgent.WitsmlStoreServiceReference.WMLS_GetFromStoreRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://www.witsml.org/action/120/Store.WMLS_GetFromStore", ReplyAction="http://www.witsml.org/wsdl/120/IWitsmlStore/WMLS_GetFromStoreResponse")]
        System.Threading.Tasks.Task<WitsmlAgent.WitsmlStoreServiceReference.WMLS_GetFromStoreResponse> WMLS_GetFromStoreAsync(WitsmlAgent.WitsmlStoreServiceReference.WMLS_GetFromStoreRequest request);
        
        // CODEGEN: Generating message contract since the wrapper namespace (http://www.witsml.org/message/120) of message WMLS_GetVersionRequest does not match the default value (http://www.witsml.org/wsdl/120)
        [System.ServiceModel.OperationContractAttribute(Action="http://www.witsml.org/action/120/Store.WMLS_GetVersion", ReplyAction="http://www.witsml.org/wsdl/120/IWitsmlStore/WMLS_GetVersionResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        WitsmlAgent.WitsmlStoreServiceReference.WMLS_GetVersionResponse WMLS_GetVersion(WitsmlAgent.WitsmlStoreServiceReference.WMLS_GetVersionRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.witsml.org/action/120/Store.WMLS_GetVersion", ReplyAction="http://www.witsml.org/wsdl/120/IWitsmlStore/WMLS_GetVersionResponse")]
        System.Threading.Tasks.Task<WitsmlAgent.WitsmlStoreServiceReference.WMLS_GetVersionResponse> WMLS_GetVersionAsync(WitsmlAgent.WitsmlStoreServiceReference.WMLS_GetVersionRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.witsml.org/action/120/Store.WMLS_UpdateInStore", ReplyAction="http://www.witsml.org/wsdl/120/IWitsmlStore/WMLS_UpdateInStoreResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        WitsmlAgent.WitsmlStoreServiceReference.WMLS_UpdateInStoreResponse WMLS_UpdateInStore(WitsmlAgent.WitsmlStoreServiceReference.WMLS_UpdateInStoreRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://www.witsml.org/action/120/Store.WMLS_UpdateInStore", ReplyAction="http://www.witsml.org/wsdl/120/IWitsmlStore/WMLS_UpdateInStoreResponse")]
        System.Threading.Tasks.Task<WitsmlAgent.WitsmlStoreServiceReference.WMLS_UpdateInStoreResponse> WMLS_UpdateInStoreAsync(WitsmlAgent.WitsmlStoreServiceReference.WMLS_UpdateInStoreRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="WMLS_AddToStore", WrapperNamespace="http://www.witsml.org/message/120", IsWrapped=true)]
    public partial class WMLS_AddToStoreRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public string WMLtypeIn;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=1)]
        public string XMLin;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=2)]
        public string OptionsIn;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=3)]
        public string CapabilitiesIn;
        
        public WMLS_AddToStoreRequest() {
        }
        
        public WMLS_AddToStoreRequest(string WMLtypeIn, string XMLin, string OptionsIn, string CapabilitiesIn) {
            this.WMLtypeIn = WMLtypeIn;
            this.XMLin = XMLin;
            this.OptionsIn = OptionsIn;
            this.CapabilitiesIn = CapabilitiesIn;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="WMLS_AddToStoreResponse", WrapperNamespace="http://www.witsml.org/message/120", IsWrapped=true)]
    public partial class WMLS_AddToStoreResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public short Result;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=1)]
        public string SuppMsgOut;
        
        public WMLS_AddToStoreResponse() {
        }
        
        public WMLS_AddToStoreResponse(short Result, string SuppMsgOut) {
            this.Result = Result;
            this.SuppMsgOut = SuppMsgOut;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="WMLS_DeleteFromStore", WrapperNamespace="http://www.witsml.org/message/120", IsWrapped=true)]
    public partial class WMLS_DeleteFromStoreRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public string WMLtypeIn;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=1)]
        public string QueryIn;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=2)]
        public string OptionsIn;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=3)]
        public string CapabilitiesIn;
        
        public WMLS_DeleteFromStoreRequest() {
        }
        
        public WMLS_DeleteFromStoreRequest(string WMLtypeIn, string QueryIn, string OptionsIn, string CapabilitiesIn) {
            this.WMLtypeIn = WMLtypeIn;
            this.QueryIn = QueryIn;
            this.OptionsIn = OptionsIn;
            this.CapabilitiesIn = CapabilitiesIn;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="WMLS_DeleteFromStoreResponse", WrapperNamespace="http://www.witsml.org/message/120", IsWrapped=true)]
    public partial class WMLS_DeleteFromStoreResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public short Result;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=1)]
        public string SuppMsgOut;
        
        public WMLS_DeleteFromStoreResponse() {
        }
        
        public WMLS_DeleteFromStoreResponse(short Result, string SuppMsgOut) {
            this.Result = Result;
            this.SuppMsgOut = SuppMsgOut;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="WMLS_GetBaseMsg", WrapperNamespace="http://www.witsml.org/message/120", IsWrapped=true)]
    public partial class WMLS_GetBaseMsgRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public short ReturnValueIn;
        
        public WMLS_GetBaseMsgRequest() {
        }
        
        public WMLS_GetBaseMsgRequest(short ReturnValueIn) {
            this.ReturnValueIn = ReturnValueIn;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="WMLS_GetBaseMsgResponse", WrapperNamespace="http://www.witsml.org/message/120", IsWrapped=true)]
    public partial class WMLS_GetBaseMsgResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public string Result;
        
        public WMLS_GetBaseMsgResponse() {
        }
        
        public WMLS_GetBaseMsgResponse(string Result) {
            this.Result = Result;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="WMLS_GetCap", WrapperNamespace="http://www.witsml.org/message/120", IsWrapped=true)]
    public partial class WMLS_GetCapRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public string OptionsIn;
        
        public WMLS_GetCapRequest() {
        }
        
        public WMLS_GetCapRequest(string OptionsIn) {
            this.OptionsIn = OptionsIn;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="WMLS_GetCapResponse", WrapperNamespace="http://www.witsml.org/message/120", IsWrapped=true)]
    public partial class WMLS_GetCapResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public short Result;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=1)]
        public string CapabilitiesOut;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=2)]
        public string SuppMsgOut;
        
        public WMLS_GetCapResponse() {
        }
        
        public WMLS_GetCapResponse(short Result, string CapabilitiesOut, string SuppMsgOut) {
            this.Result = Result;
            this.CapabilitiesOut = CapabilitiesOut;
            this.SuppMsgOut = SuppMsgOut;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="WMLS_GetFromStore", WrapperNamespace="http://www.witsml.org/message/120", IsWrapped=true)]
    public partial class WMLS_GetFromStoreRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public string WMLtypeIn;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=1)]
        public string QueryIn;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=2)]
        public string OptionsIn;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=3)]
        public string CapabilitiesIn;
        
        public WMLS_GetFromStoreRequest() {
        }
        
        public WMLS_GetFromStoreRequest(string WMLtypeIn, string QueryIn, string OptionsIn, string CapabilitiesIn) {
            this.WMLtypeIn = WMLtypeIn;
            this.QueryIn = QueryIn;
            this.OptionsIn = OptionsIn;
            this.CapabilitiesIn = CapabilitiesIn;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="WMLS_GetFromStoreResponse", WrapperNamespace="http://www.witsml.org/message/120", IsWrapped=true)]
    public partial class WMLS_GetFromStoreResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public short Result;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=1)]
        public string XMLout;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=2)]
        public string SuppMsgOut;
        
        public WMLS_GetFromStoreResponse() {
        }
        
        public WMLS_GetFromStoreResponse(short Result, string XMLout, string SuppMsgOut) {
            this.Result = Result;
            this.XMLout = XMLout;
            this.SuppMsgOut = SuppMsgOut;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="WMLS_GetVersion", WrapperNamespace="http://www.witsml.org/message/120", IsWrapped=true)]
    public partial class WMLS_GetVersionRequest {
        
        public WMLS_GetVersionRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="WMLS_GetVersionResponse", WrapperNamespace="http://www.witsml.org/message/120", IsWrapped=true)]
    public partial class WMLS_GetVersionResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public string Result;
        
        public WMLS_GetVersionResponse() {
        }
        
        public WMLS_GetVersionResponse(string Result) {
            this.Result = Result;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="WMLS_UpdateInStore", WrapperNamespace="http://www.witsml.org/message/120", IsWrapped=true)]
    public partial class WMLS_UpdateInStoreRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public string WMLtypeIn;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=1)]
        public string XMLin;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=2)]
        public string OptionsIn;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=3)]
        public string CapabilitiesIn;
        
        public WMLS_UpdateInStoreRequest() {
        }
        
        public WMLS_UpdateInStoreRequest(string WMLtypeIn, string XMLin, string OptionsIn, string CapabilitiesIn) {
            this.WMLtypeIn = WMLtypeIn;
            this.XMLin = XMLin;
            this.OptionsIn = OptionsIn;
            this.CapabilitiesIn = CapabilitiesIn;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="WMLS_UpdateInStoreResponse", WrapperNamespace="http://www.witsml.org/message/120", IsWrapped=true)]
    public partial class WMLS_UpdateInStoreResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        public short Result;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=1)]
        public string SuppMsgOut;
        
        public WMLS_UpdateInStoreResponse() {
        }
        
        public WMLS_UpdateInStoreResponse(short Result, string SuppMsgOut) {
            this.Result = Result;
            this.SuppMsgOut = SuppMsgOut;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWitsmlStoreChannel : WitsmlAgent.WitsmlStoreServiceReference.IWitsmlStore, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WitsmlStoreClient : System.ServiceModel.ClientBase<WitsmlAgent.WitsmlStoreServiceReference.IWitsmlStore>, WitsmlAgent.WitsmlStoreServiceReference.IWitsmlStore {
        
        public WitsmlStoreClient() {
        }
        
        public WitsmlStoreClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WitsmlStoreClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WitsmlStoreClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WitsmlStoreClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WitsmlAgent.WitsmlStoreServiceReference.WMLS_AddToStoreResponse WitsmlAgent.WitsmlStoreServiceReference.IWitsmlStore.WMLS_AddToStore(WitsmlAgent.WitsmlStoreServiceReference.WMLS_AddToStoreRequest request) {
            return base.Channel.WMLS_AddToStore(request);
        }
        
        public short WMLS_AddToStore(string WMLtypeIn, string XMLin, string OptionsIn, string CapabilitiesIn, out string SuppMsgOut) {
            WitsmlAgent.WitsmlStoreServiceReference.WMLS_AddToStoreRequest inValue = new WitsmlAgent.WitsmlStoreServiceReference.WMLS_AddToStoreRequest();
            inValue.WMLtypeIn = WMLtypeIn;
            inValue.XMLin = XMLin;
            inValue.OptionsIn = OptionsIn;
            inValue.CapabilitiesIn = CapabilitiesIn;
            WitsmlAgent.WitsmlStoreServiceReference.WMLS_AddToStoreResponse retVal = ((WitsmlAgent.WitsmlStoreServiceReference.IWitsmlStore)(this)).WMLS_AddToStore(inValue);
            SuppMsgOut = retVal.SuppMsgOut;
            return retVal.Result;
        }
        
        public System.Threading.Tasks.Task<WitsmlAgent.WitsmlStoreServiceReference.WMLS_AddToStoreResponse> WMLS_AddToStoreAsync(WitsmlAgent.WitsmlStoreServiceReference.WMLS_AddToStoreRequest request) {
            return base.Channel.WMLS_AddToStoreAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WitsmlAgent.WitsmlStoreServiceReference.WMLS_DeleteFromStoreResponse WitsmlAgent.WitsmlStoreServiceReference.IWitsmlStore.WMLS_DeleteFromStore(WitsmlAgent.WitsmlStoreServiceReference.WMLS_DeleteFromStoreRequest request) {
            return base.Channel.WMLS_DeleteFromStore(request);
        }
        
        public short WMLS_DeleteFromStore(string WMLtypeIn, string QueryIn, string OptionsIn, string CapabilitiesIn, out string SuppMsgOut) {
            WitsmlAgent.WitsmlStoreServiceReference.WMLS_DeleteFromStoreRequest inValue = new WitsmlAgent.WitsmlStoreServiceReference.WMLS_DeleteFromStoreRequest();
            inValue.WMLtypeIn = WMLtypeIn;
            inValue.QueryIn = QueryIn;
            inValue.OptionsIn = OptionsIn;
            inValue.CapabilitiesIn = CapabilitiesIn;
            WitsmlAgent.WitsmlStoreServiceReference.WMLS_DeleteFromStoreResponse retVal = ((WitsmlAgent.WitsmlStoreServiceReference.IWitsmlStore)(this)).WMLS_DeleteFromStore(inValue);
            SuppMsgOut = retVal.SuppMsgOut;
            return retVal.Result;
        }
        
        public System.Threading.Tasks.Task<WitsmlAgent.WitsmlStoreServiceReference.WMLS_DeleteFromStoreResponse> WMLS_DeleteFromStoreAsync(WitsmlAgent.WitsmlStoreServiceReference.WMLS_DeleteFromStoreRequest request) {
            return base.Channel.WMLS_DeleteFromStoreAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WitsmlAgent.WitsmlStoreServiceReference.WMLS_GetBaseMsgResponse WitsmlAgent.WitsmlStoreServiceReference.IWitsmlStore.WMLS_GetBaseMsg(WitsmlAgent.WitsmlStoreServiceReference.WMLS_GetBaseMsgRequest request) {
            return base.Channel.WMLS_GetBaseMsg(request);
        }
        
        public string WMLS_GetBaseMsg(short ReturnValueIn) {
            WitsmlAgent.WitsmlStoreServiceReference.WMLS_GetBaseMsgRequest inValue = new WitsmlAgent.WitsmlStoreServiceReference.WMLS_GetBaseMsgRequest();
            inValue.ReturnValueIn = ReturnValueIn;
            WitsmlAgent.WitsmlStoreServiceReference.WMLS_GetBaseMsgResponse retVal = ((WitsmlAgent.WitsmlStoreServiceReference.IWitsmlStore)(this)).WMLS_GetBaseMsg(inValue);
            return retVal.Result;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WitsmlAgent.WitsmlStoreServiceReference.WMLS_GetBaseMsgResponse> WitsmlAgent.WitsmlStoreServiceReference.IWitsmlStore.WMLS_GetBaseMsgAsync(WitsmlAgent.WitsmlStoreServiceReference.WMLS_GetBaseMsgRequest request) {
            return base.Channel.WMLS_GetBaseMsgAsync(request);
        }
        
        public System.Threading.Tasks.Task<WitsmlAgent.WitsmlStoreServiceReference.WMLS_GetBaseMsgResponse> WMLS_GetBaseMsgAsync(short ReturnValueIn) {
            WitsmlAgent.WitsmlStoreServiceReference.WMLS_GetBaseMsgRequest inValue = new WitsmlAgent.WitsmlStoreServiceReference.WMLS_GetBaseMsgRequest();
            inValue.ReturnValueIn = ReturnValueIn;
            return ((WitsmlAgent.WitsmlStoreServiceReference.IWitsmlStore)(this)).WMLS_GetBaseMsgAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WitsmlAgent.WitsmlStoreServiceReference.WMLS_GetCapResponse WitsmlAgent.WitsmlStoreServiceReference.IWitsmlStore.WMLS_GetCap(WitsmlAgent.WitsmlStoreServiceReference.WMLS_GetCapRequest request) {
            return base.Channel.WMLS_GetCap(request);
        }
        
        public short WMLS_GetCap(string OptionsIn, out string CapabilitiesOut, out string SuppMsgOut) {
            WitsmlAgent.WitsmlStoreServiceReference.WMLS_GetCapRequest inValue = new WitsmlAgent.WitsmlStoreServiceReference.WMLS_GetCapRequest();
            inValue.OptionsIn = OptionsIn;
            WitsmlAgent.WitsmlStoreServiceReference.WMLS_GetCapResponse retVal = ((WitsmlAgent.WitsmlStoreServiceReference.IWitsmlStore)(this)).WMLS_GetCap(inValue);
            CapabilitiesOut = retVal.CapabilitiesOut;
            SuppMsgOut = retVal.SuppMsgOut;
            return retVal.Result;
        }
        
        public System.Threading.Tasks.Task<WitsmlAgent.WitsmlStoreServiceReference.WMLS_GetCapResponse> WMLS_GetCapAsync(WitsmlAgent.WitsmlStoreServiceReference.WMLS_GetCapRequest request) {
            return base.Channel.WMLS_GetCapAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WitsmlAgent.WitsmlStoreServiceReference.WMLS_GetFromStoreResponse WitsmlAgent.WitsmlStoreServiceReference.IWitsmlStore.WMLS_GetFromStore(WitsmlAgent.WitsmlStoreServiceReference.WMLS_GetFromStoreRequest request) {
            return base.Channel.WMLS_GetFromStore(request);
        }
        
        public short WMLS_GetFromStore(string WMLtypeIn, string QueryIn, string OptionsIn, string CapabilitiesIn, out string XMLout, out string SuppMsgOut) {
            WitsmlAgent.WitsmlStoreServiceReference.WMLS_GetFromStoreRequest inValue = new WitsmlAgent.WitsmlStoreServiceReference.WMLS_GetFromStoreRequest();
            inValue.WMLtypeIn = WMLtypeIn;
            inValue.QueryIn = QueryIn;
            inValue.OptionsIn = OptionsIn;
            inValue.CapabilitiesIn = CapabilitiesIn;
            WitsmlAgent.WitsmlStoreServiceReference.WMLS_GetFromStoreResponse retVal = ((WitsmlAgent.WitsmlStoreServiceReference.IWitsmlStore)(this)).WMLS_GetFromStore(inValue);
            XMLout = retVal.XMLout;
            SuppMsgOut = retVal.SuppMsgOut;
            return retVal.Result;
        }
        
        public System.Threading.Tasks.Task<WitsmlAgent.WitsmlStoreServiceReference.WMLS_GetFromStoreResponse> WMLS_GetFromStoreAsync(WitsmlAgent.WitsmlStoreServiceReference.WMLS_GetFromStoreRequest request) {
            return base.Channel.WMLS_GetFromStoreAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WitsmlAgent.WitsmlStoreServiceReference.WMLS_GetVersionResponse WitsmlAgent.WitsmlStoreServiceReference.IWitsmlStore.WMLS_GetVersion(WitsmlAgent.WitsmlStoreServiceReference.WMLS_GetVersionRequest request) {
            return base.Channel.WMLS_GetVersion(request);
        }
        
        public string WMLS_GetVersion() {
            WitsmlAgent.WitsmlStoreServiceReference.WMLS_GetVersionRequest inValue = new WitsmlAgent.WitsmlStoreServiceReference.WMLS_GetVersionRequest();
            WitsmlAgent.WitsmlStoreServiceReference.WMLS_GetVersionResponse retVal = ((WitsmlAgent.WitsmlStoreServiceReference.IWitsmlStore)(this)).WMLS_GetVersion(inValue);
            return retVal.Result;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WitsmlAgent.WitsmlStoreServiceReference.WMLS_GetVersionResponse> WitsmlAgent.WitsmlStoreServiceReference.IWitsmlStore.WMLS_GetVersionAsync(WitsmlAgent.WitsmlStoreServiceReference.WMLS_GetVersionRequest request) {
            return base.Channel.WMLS_GetVersionAsync(request);
        }
        
        public System.Threading.Tasks.Task<WitsmlAgent.WitsmlStoreServiceReference.WMLS_GetVersionResponse> WMLS_GetVersionAsync() {
            WitsmlAgent.WitsmlStoreServiceReference.WMLS_GetVersionRequest inValue = new WitsmlAgent.WitsmlStoreServiceReference.WMLS_GetVersionRequest();
            return ((WitsmlAgent.WitsmlStoreServiceReference.IWitsmlStore)(this)).WMLS_GetVersionAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WitsmlAgent.WitsmlStoreServiceReference.WMLS_UpdateInStoreResponse WitsmlAgent.WitsmlStoreServiceReference.IWitsmlStore.WMLS_UpdateInStore(WitsmlAgent.WitsmlStoreServiceReference.WMLS_UpdateInStoreRequest request) {
            return base.Channel.WMLS_UpdateInStore(request);
        }
        
        public short WMLS_UpdateInStore(string WMLtypeIn, string XMLin, string OptionsIn, string CapabilitiesIn, out string SuppMsgOut) {
            WitsmlAgent.WitsmlStoreServiceReference.WMLS_UpdateInStoreRequest inValue = new WitsmlAgent.WitsmlStoreServiceReference.WMLS_UpdateInStoreRequest();
            inValue.WMLtypeIn = WMLtypeIn;
            inValue.XMLin = XMLin;
            inValue.OptionsIn = OptionsIn;
            inValue.CapabilitiesIn = CapabilitiesIn;
            WitsmlAgent.WitsmlStoreServiceReference.WMLS_UpdateInStoreResponse retVal = ((WitsmlAgent.WitsmlStoreServiceReference.IWitsmlStore)(this)).WMLS_UpdateInStore(inValue);
            SuppMsgOut = retVal.SuppMsgOut;
            return retVal.Result;
        }
        
        public System.Threading.Tasks.Task<WitsmlAgent.WitsmlStoreServiceReference.WMLS_UpdateInStoreResponse> WMLS_UpdateInStoreAsync(WitsmlAgent.WitsmlStoreServiceReference.WMLS_UpdateInStoreRequest request) {
            return base.Channel.WMLS_UpdateInStoreAsync(request);
        }
    }
}
