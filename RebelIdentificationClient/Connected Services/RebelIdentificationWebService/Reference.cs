﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RebelIdentificationClient.RebelIdentificationWebService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ArrayOfString", Namespace="http://tempuri.org/", ItemName="string")]
    [System.SerializableAttribute()]
    public class ArrayOfString : System.Collections.Generic.List<string> {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="RebelIdentificationWebService.WebService1Soap")]
    public interface WebService1Soap {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento rebelName del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/RebelSighting", ReplyAction="*")]
        RebelIdentificationClient.RebelIdentificationWebService.RebelSightingResponse RebelSighting(RebelIdentificationClient.RebelIdentificationWebService.RebelSightingRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/RebelSighting", ReplyAction="*")]
        System.Threading.Tasks.Task<RebelIdentificationClient.RebelIdentificationWebService.RebelSightingResponse> RebelSightingAsync(RebelIdentificationClient.RebelIdentificationWebService.RebelSightingRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento ReadAllResult del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ReadAll", ReplyAction="*")]
        RebelIdentificationClient.RebelIdentificationWebService.ReadAllResponse ReadAll(RebelIdentificationClient.RebelIdentificationWebService.ReadAllRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ReadAll", ReplyAction="*")]
        System.Threading.Tasks.Task<RebelIdentificationClient.RebelIdentificationWebService.ReadAllResponse> ReadAllAsync(RebelIdentificationClient.RebelIdentificationWebService.ReadAllRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento rebelName del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ReadByName", ReplyAction="*")]
        RebelIdentificationClient.RebelIdentificationWebService.ReadByNameResponse ReadByName(RebelIdentificationClient.RebelIdentificationWebService.ReadByNameRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ReadByName", ReplyAction="*")]
        System.Threading.Tasks.Task<RebelIdentificationClient.RebelIdentificationWebService.ReadByNameResponse> ReadByNameAsync(RebelIdentificationClient.RebelIdentificationWebService.ReadByNameRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class RebelSightingRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="RebelSighting", Namespace="http://tempuri.org/", Order=0)]
        public RebelIdentificationClient.RebelIdentificationWebService.RebelSightingRequestBody Body;
        
        public RebelSightingRequest() {
        }
        
        public RebelSightingRequest(RebelIdentificationClient.RebelIdentificationWebService.RebelSightingRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class RebelSightingRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string rebelName;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string planetName;
        
        public RebelSightingRequestBody() {
        }
        
        public RebelSightingRequestBody(string rebelName, string planetName) {
            this.rebelName = rebelName;
            this.planetName = planetName;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class RebelSightingResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="RebelSightingResponse", Namespace="http://tempuri.org/", Order=0)]
        public RebelIdentificationClient.RebelIdentificationWebService.RebelSightingResponseBody Body;
        
        public RebelSightingResponse() {
        }
        
        public RebelSightingResponse(RebelIdentificationClient.RebelIdentificationWebService.RebelSightingResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class RebelSightingResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool RebelSightingResult;
        
        public RebelSightingResponseBody() {
        }
        
        public RebelSightingResponseBody(bool RebelSightingResult) {
            this.RebelSightingResult = RebelSightingResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ReadAllRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ReadAll", Namespace="http://tempuri.org/", Order=0)]
        public RebelIdentificationClient.RebelIdentificationWebService.ReadAllRequestBody Body;
        
        public ReadAllRequest() {
        }
        
        public ReadAllRequest(RebelIdentificationClient.RebelIdentificationWebService.ReadAllRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class ReadAllRequestBody {
        
        public ReadAllRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ReadAllResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ReadAllResponse", Namespace="http://tempuri.org/", Order=0)]
        public RebelIdentificationClient.RebelIdentificationWebService.ReadAllResponseBody Body;
        
        public ReadAllResponse() {
        }
        
        public ReadAllResponse(RebelIdentificationClient.RebelIdentificationWebService.ReadAllResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ReadAllResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public RebelIdentificationClient.RebelIdentificationWebService.ArrayOfString ReadAllResult;
        
        public ReadAllResponseBody() {
        }
        
        public ReadAllResponseBody(RebelIdentificationClient.RebelIdentificationWebService.ArrayOfString ReadAllResult) {
            this.ReadAllResult = ReadAllResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ReadByNameRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ReadByName", Namespace="http://tempuri.org/", Order=0)]
        public RebelIdentificationClient.RebelIdentificationWebService.ReadByNameRequestBody Body;
        
        public ReadByNameRequest() {
        }
        
        public ReadByNameRequest(RebelIdentificationClient.RebelIdentificationWebService.ReadByNameRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ReadByNameRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string rebelName;
        
        public ReadByNameRequestBody() {
        }
        
        public ReadByNameRequestBody(string rebelName) {
            this.rebelName = rebelName;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ReadByNameResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ReadByNameResponse", Namespace="http://tempuri.org/", Order=0)]
        public RebelIdentificationClient.RebelIdentificationWebService.ReadByNameResponseBody Body;
        
        public ReadByNameResponse() {
        }
        
        public ReadByNameResponse(RebelIdentificationClient.RebelIdentificationWebService.ReadByNameResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ReadByNameResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public RebelIdentificationClient.RebelIdentificationWebService.ArrayOfString ReadByNameResult;
        
        public ReadByNameResponseBody() {
        }
        
        public ReadByNameResponseBody(RebelIdentificationClient.RebelIdentificationWebService.ArrayOfString ReadByNameResult) {
            this.ReadByNameResult = ReadByNameResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebService1SoapChannel : RebelIdentificationClient.RebelIdentificationWebService.WebService1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebService1SoapClient : System.ServiceModel.ClientBase<RebelIdentificationClient.RebelIdentificationWebService.WebService1Soap>, RebelIdentificationClient.RebelIdentificationWebService.WebService1Soap {
        
        public WebService1SoapClient() {
        }
        
        public WebService1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        RebelIdentificationClient.RebelIdentificationWebService.RebelSightingResponse RebelIdentificationClient.RebelIdentificationWebService.WebService1Soap.RebelSighting(RebelIdentificationClient.RebelIdentificationWebService.RebelSightingRequest request) {
            return base.Channel.RebelSighting(request);
        }
        
        public bool RebelSighting(string rebelName, string planetName) {
            RebelIdentificationClient.RebelIdentificationWebService.RebelSightingRequest inValue = new RebelIdentificationClient.RebelIdentificationWebService.RebelSightingRequest();
            inValue.Body = new RebelIdentificationClient.RebelIdentificationWebService.RebelSightingRequestBody();
            inValue.Body.rebelName = rebelName;
            inValue.Body.planetName = planetName;
            RebelIdentificationClient.RebelIdentificationWebService.RebelSightingResponse retVal = ((RebelIdentificationClient.RebelIdentificationWebService.WebService1Soap)(this)).RebelSighting(inValue);
            return retVal.Body.RebelSightingResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<RebelIdentificationClient.RebelIdentificationWebService.RebelSightingResponse> RebelIdentificationClient.RebelIdentificationWebService.WebService1Soap.RebelSightingAsync(RebelIdentificationClient.RebelIdentificationWebService.RebelSightingRequest request) {
            return base.Channel.RebelSightingAsync(request);
        }
        
        public System.Threading.Tasks.Task<RebelIdentificationClient.RebelIdentificationWebService.RebelSightingResponse> RebelSightingAsync(string rebelName, string planetName) {
            RebelIdentificationClient.RebelIdentificationWebService.RebelSightingRequest inValue = new RebelIdentificationClient.RebelIdentificationWebService.RebelSightingRequest();
            inValue.Body = new RebelIdentificationClient.RebelIdentificationWebService.RebelSightingRequestBody();
            inValue.Body.rebelName = rebelName;
            inValue.Body.planetName = planetName;
            return ((RebelIdentificationClient.RebelIdentificationWebService.WebService1Soap)(this)).RebelSightingAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        RebelIdentificationClient.RebelIdentificationWebService.ReadAllResponse RebelIdentificationClient.RebelIdentificationWebService.WebService1Soap.ReadAll(RebelIdentificationClient.RebelIdentificationWebService.ReadAllRequest request) {
            return base.Channel.ReadAll(request);
        }
        
        public RebelIdentificationClient.RebelIdentificationWebService.ArrayOfString ReadAll() {
            RebelIdentificationClient.RebelIdentificationWebService.ReadAllRequest inValue = new RebelIdentificationClient.RebelIdentificationWebService.ReadAllRequest();
            inValue.Body = new RebelIdentificationClient.RebelIdentificationWebService.ReadAllRequestBody();
            RebelIdentificationClient.RebelIdentificationWebService.ReadAllResponse retVal = ((RebelIdentificationClient.RebelIdentificationWebService.WebService1Soap)(this)).ReadAll(inValue);
            return retVal.Body.ReadAllResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<RebelIdentificationClient.RebelIdentificationWebService.ReadAllResponse> RebelIdentificationClient.RebelIdentificationWebService.WebService1Soap.ReadAllAsync(RebelIdentificationClient.RebelIdentificationWebService.ReadAllRequest request) {
            return base.Channel.ReadAllAsync(request);
        }
        
        public System.Threading.Tasks.Task<RebelIdentificationClient.RebelIdentificationWebService.ReadAllResponse> ReadAllAsync() {
            RebelIdentificationClient.RebelIdentificationWebService.ReadAllRequest inValue = new RebelIdentificationClient.RebelIdentificationWebService.ReadAllRequest();
            inValue.Body = new RebelIdentificationClient.RebelIdentificationWebService.ReadAllRequestBody();
            return ((RebelIdentificationClient.RebelIdentificationWebService.WebService1Soap)(this)).ReadAllAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        RebelIdentificationClient.RebelIdentificationWebService.ReadByNameResponse RebelIdentificationClient.RebelIdentificationWebService.WebService1Soap.ReadByName(RebelIdentificationClient.RebelIdentificationWebService.ReadByNameRequest request) {
            return base.Channel.ReadByName(request);
        }
        
        public RebelIdentificationClient.RebelIdentificationWebService.ArrayOfString ReadByName(string rebelName) {
            RebelIdentificationClient.RebelIdentificationWebService.ReadByNameRequest inValue = new RebelIdentificationClient.RebelIdentificationWebService.ReadByNameRequest();
            inValue.Body = new RebelIdentificationClient.RebelIdentificationWebService.ReadByNameRequestBody();
            inValue.Body.rebelName = rebelName;
            RebelIdentificationClient.RebelIdentificationWebService.ReadByNameResponse retVal = ((RebelIdentificationClient.RebelIdentificationWebService.WebService1Soap)(this)).ReadByName(inValue);
            return retVal.Body.ReadByNameResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<RebelIdentificationClient.RebelIdentificationWebService.ReadByNameResponse> RebelIdentificationClient.RebelIdentificationWebService.WebService1Soap.ReadByNameAsync(RebelIdentificationClient.RebelIdentificationWebService.ReadByNameRequest request) {
            return base.Channel.ReadByNameAsync(request);
        }
        
        public System.Threading.Tasks.Task<RebelIdentificationClient.RebelIdentificationWebService.ReadByNameResponse> ReadByNameAsync(string rebelName) {
            RebelIdentificationClient.RebelIdentificationWebService.ReadByNameRequest inValue = new RebelIdentificationClient.RebelIdentificationWebService.ReadByNameRequest();
            inValue.Body = new RebelIdentificationClient.RebelIdentificationWebService.ReadByNameRequestBody();
            inValue.Body.rebelName = rebelName;
            return ((RebelIdentificationClient.RebelIdentificationWebService.WebService1Soap)(this)).ReadByNameAsync(inValue);
        }
    }
}