﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace winAppSAIC.LucasServCancela {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="objComprobante40", Namespace="http://schemas.datacontract.org/2004/07/")]
    [System.SerializableAttribute()]
    public partial class objComprobante40 : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CodigoErrorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ExtraInfoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MensajeIncidenciaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool bGeneradoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string strComprobanteField;
        
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
        public string CodigoError {
            get {
                return this.CodigoErrorField;
            }
            set {
                if ((object.ReferenceEquals(this.CodigoErrorField, value) != true)) {
                    this.CodigoErrorField = value;
                    this.RaisePropertyChanged("CodigoError");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ExtraInfo {
            get {
                return this.ExtraInfoField;
            }
            set {
                if ((object.ReferenceEquals(this.ExtraInfoField, value) != true)) {
                    this.ExtraInfoField = value;
                    this.RaisePropertyChanged("ExtraInfo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MensajeIncidencia {
            get {
                return this.MensajeIncidenciaField;
            }
            set {
                if ((object.ReferenceEquals(this.MensajeIncidenciaField, value) != true)) {
                    this.MensajeIncidenciaField = value;
                    this.RaisePropertyChanged("MensajeIncidencia");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool bGenerado {
            get {
                return this.bGeneradoField;
            }
            set {
                if ((this.bGeneradoField.Equals(value) != true)) {
                    this.bGeneradoField = value;
                    this.RaisePropertyChanged("bGenerado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string strComprobante {
            get {
                return this.strComprobanteField;
            }
            set {
                if ((object.ReferenceEquals(this.strComprobanteField, value) != true)) {
                    this.strComprobanteField = value;
                    this.RaisePropertyChanged("strComprobante");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="objCancelar", Namespace="http://schemas.datacontract.org/2004/07/")]
    [System.SerializableAttribute()]
    public partial class objCancelar : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string cIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string cMessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime fFechaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int iCodeField;
        
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
        public string cId {
            get {
                return this.cIdField;
            }
            set {
                if ((object.ReferenceEquals(this.cIdField, value) != true)) {
                    this.cIdField = value;
                    this.RaisePropertyChanged("cId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string cMessage {
            get {
                return this.cMessageField;
            }
            set {
                if ((object.ReferenceEquals(this.cMessageField, value) != true)) {
                    this.cMessageField = value;
                    this.RaisePropertyChanged("cMessage");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime fFecha {
            get {
                return this.fFechaField;
            }
            set {
                if ((this.fFechaField.Equals(value) != true)) {
                    this.fFechaField = value;
                    this.RaisePropertyChanged("fFecha");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int iCode {
            get {
                return this.iCodeField;
            }
            set {
                if ((this.iCodeField.Equals(value) != true)) {
                    this.iCodeField = value;
                    this.RaisePropertyChanged("iCode");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="objEstadoSAT", Namespace="http://schemas.datacontract.org/2004/07/")]
    [System.SerializableAttribute()]
    public partial class objEstadoSAT : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string cCodigoEstatusField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string cDescripcionEstatusField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string cEsCancelableField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string cEstadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string cEstatusCancelacionField;
        
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
        public string cCodigoEstatus {
            get {
                return this.cCodigoEstatusField;
            }
            set {
                if ((object.ReferenceEquals(this.cCodigoEstatusField, value) != true)) {
                    this.cCodigoEstatusField = value;
                    this.RaisePropertyChanged("cCodigoEstatus");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string cDescripcionEstatus {
            get {
                return this.cDescripcionEstatusField;
            }
            set {
                if ((object.ReferenceEquals(this.cDescripcionEstatusField, value) != true)) {
                    this.cDescripcionEstatusField = value;
                    this.RaisePropertyChanged("cDescripcionEstatus");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string cEsCancelable {
            get {
                return this.cEsCancelableField;
            }
            set {
                if ((object.ReferenceEquals(this.cEsCancelableField, value) != true)) {
                    this.cEsCancelableField = value;
                    this.RaisePropertyChanged("cEsCancelable");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string cEstado {
            get {
                return this.cEstadoField;
            }
            set {
                if ((object.ReferenceEquals(this.cEstadoField, value) != true)) {
                    this.cEstadoField = value;
                    this.RaisePropertyChanged("cEstado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string cEstatusCancelacion {
            get {
                return this.cEstatusCancelacionField;
            }
            set {
                if ((object.ReferenceEquals(this.cEstatusCancelacionField, value) != true)) {
                    this.cEstatusCancelacionField = value;
                    this.RaisePropertyChanged("cEstatusCancelacion");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="LucasServCancela.IFacturacion40Service")]
    public interface IFacturacion40Service {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFacturacion40Service/GenerarComprobante", ReplyAction="http://tempuri.org/IFacturacion40Service/GenerarComprobanteResponse")]
        winAppSAIC.LucasServCancela.objComprobante40 GenerarComprobante(string cGuid, string strComprobante);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFacturacion40Service/GenerarComprobanteSellado", ReplyAction="http://tempuri.org/IFacturacion40Service/GenerarComprobanteSelladoResponse")]
        winAppSAIC.LucasServCancela.objComprobante40 GenerarComprobanteSellado(string cGuid, string strComprobante);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFacturacion40Service/FacturacionCancelar40", ReplyAction="http://tempuri.org/IFacturacion40Service/FacturacionCancelar40Response")]
        winAppSAIC.LucasServCancela.objCancelar FacturacionCancelar40(string cGuid, string cRfcEmisor, string cUuid, string cRfcReceptor, decimal dMonto, string cPublicKeyPem, string cPrivateKeyPem, string cMotivo, string cFolioSustitucion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFacturacion40Service/FacturacionCancelar40v02", ReplyAction="http://tempuri.org/IFacturacion40Service/FacturacionCancelar40v02Response")]
        winAppSAIC.LucasServCancela.objCancelar FacturacionCancelar40v02(string cGuid, string cRfcEmisor, string cUuid, string cMotivo, string cFolioSustitucion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFacturacion40Service/FacturacionConsultarEstadoSAT", ReplyAction="http://tempuri.org/IFacturacion40Service/FacturacionConsultarEstadoSATResponse")]
        winAppSAIC.LucasServCancela.objEstadoSAT FacturacionConsultarEstadoSAT(string cGuid, string cRfcEmisor, string cUuid, string cRfcReceptor, decimal dMonto);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IFacturacion40ServiceChannel : winAppSAIC.LucasServCancela.IFacturacion40Service, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Facturacion40ServiceClient : System.ServiceModel.ClientBase<winAppSAIC.LucasServCancela.IFacturacion40Service>, winAppSAIC.LucasServCancela.IFacturacion40Service {
        
        public Facturacion40ServiceClient() {
        }
        
        public Facturacion40ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Facturacion40ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Facturacion40ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Facturacion40ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public winAppSAIC.LucasServCancela.objComprobante40 GenerarComprobante(string cGuid, string strComprobante) {
            return base.Channel.GenerarComprobante(cGuid, strComprobante);
        }
        
        public winAppSAIC.LucasServCancela.objComprobante40 GenerarComprobanteSellado(string cGuid, string strComprobante) {
            return base.Channel.GenerarComprobanteSellado(cGuid, strComprobante);
        }
        
        public winAppSAIC.LucasServCancela.objCancelar FacturacionCancelar40(string cGuid, string cRfcEmisor, string cUuid, string cRfcReceptor, decimal dMonto, string cPublicKeyPem, string cPrivateKeyPem, string cMotivo, string cFolioSustitucion) {
            return base.Channel.FacturacionCancelar40(cGuid, cRfcEmisor, cUuid, cRfcReceptor, dMonto, cPublicKeyPem, cPrivateKeyPem, cMotivo, cFolioSustitucion);
        }
        
        public winAppSAIC.LucasServCancela.objCancelar FacturacionCancelar40v02(string cGuid, string cRfcEmisor, string cUuid, string cMotivo, string cFolioSustitucion) {
            return base.Channel.FacturacionCancelar40v02(cGuid, cRfcEmisor, cUuid, cMotivo, cFolioSustitucion);
        }
        
        public winAppSAIC.LucasServCancela.objEstadoSAT FacturacionConsultarEstadoSAT(string cGuid, string cRfcEmisor, string cUuid, string cRfcReceptor, decimal dMonto) {
            return base.Channel.FacturacionConsultarEstadoSAT(cGuid, cRfcEmisor, cUuid, cRfcReceptor, dMonto);
        }
    }
}
