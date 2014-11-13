﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace client.FortuneService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://luka.sh/fortune/tools/", ConfigurationName="FortuneService.FortuneSrvSoap")]
    public interface FortuneSrvSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://luka.sh/fortune/tools/getFortuneHtml", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        string getFortuneHtml(string path);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://luka.sh/fortune/tools/getFortuneHtml", ReplyAction="*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        System.Threading.Tasks.Task<string> getFortuneHtmlAsync(string path);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://luka.sh/fortune/tools/getFortuneStr", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true, Use=System.ServiceModel.OperationFormatUse.Encoded)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        string getFortuneStr(string path);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://luka.sh/fortune/tools/getFortuneStr", ReplyAction="*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        System.Threading.Tasks.Task<string> getFortuneStrAsync(string path);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface FortuneSrvSoapChannel : client.FortuneService.FortuneSrvSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class FortuneSrvSoapClient : System.ServiceModel.ClientBase<client.FortuneService.FortuneSrvSoap>, client.FortuneService.FortuneSrvSoap {
        
        public FortuneSrvSoapClient() {
        }
        
        public FortuneSrvSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public FortuneSrvSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FortuneSrvSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FortuneSrvSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string getFortuneHtml(string path) {
            return base.Channel.getFortuneHtml(path);
        }
        
        public System.Threading.Tasks.Task<string> getFortuneHtmlAsync(string path) {
            return base.Channel.getFortuneHtmlAsync(path);
        }
        
        public string getFortuneStr(string path) {
            return base.Channel.getFortuneStr(path);
        }
        
        public System.Threading.Tasks.Task<string> getFortuneStrAsync(string path) {
            return base.Channel.getFortuneStrAsync(path);
        }
    }
}
