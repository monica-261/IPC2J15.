﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18449
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApplication1.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Name="Servicio BibliotecaSoap", Namespace="http://LocalHost/WebServiceBiblioteca", ConfigurationName="ServiceReference1.ServicioBibliotecaSoap")]
    public interface ServicioBibliotecaSoap {
        
        // CODEGEN: Generating message contract since element name carnet from namespace http://LocalHost/WebServiceBiblioteca is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://LocalHost/WebServiceBiblioteca/InsertarCliente", ReplyAction="*")]
        WindowsFormsApplication1.ServiceReference1.InsertarClienteResponse InsertarCliente(WindowsFormsApplication1.ServiceReference1.InsertarClienteRequest request);
        
        // CODEGEN: Generating message contract since element name nombre from namespace http://LocalHost/WebServiceBiblioteca is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://LocalHost/WebServiceBiblioteca/NuevoLibro", ReplyAction="*")]
        WindowsFormsApplication1.ServiceReference1.NuevoLibroResponse NuevoLibro(WindowsFormsApplication1.ServiceReference1.NuevoLibroRequest request);
        
        // CODEGEN: Generating message contract since element name buscar from namespace http://LocalHost/WebServiceBiblioteca is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://LocalHost/WebServiceBiblioteca/Consulta", ReplyAction="*")]
        WindowsFormsApplication1.ServiceReference1.ConsultaResponse Consulta(WindowsFormsApplication1.ServiceReference1.ConsultaRequest request);
        
        // CODEGEN: Generating message contract since element name libro from namespace http://LocalHost/WebServiceBiblioteca is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://LocalHost/WebServiceBiblioteca/Prestamo", ReplyAction="*")]
        WindowsFormsApplication1.ServiceReference1.PrestamoResponse Prestamo(WindowsFormsApplication1.ServiceReference1.PrestamoRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class InsertarClienteRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="InsertarCliente", Namespace="http://LocalHost/WebServiceBiblioteca", Order=0)]
        public WindowsFormsApplication1.ServiceReference1.InsertarClienteRequestBody Body;
        
        public InsertarClienteRequest() {
        }
        
        public InsertarClienteRequest(WindowsFormsApplication1.ServiceReference1.InsertarClienteRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://LocalHost/WebServiceBiblioteca")]
    public partial class InsertarClienteRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string carnet;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string nombre;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string dpi;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string direc;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string tel;
        
        public InsertarClienteRequestBody() {
        }
        
        public InsertarClienteRequestBody(string carnet, string nombre, string dpi, string direc, string tel) {
            this.carnet = carnet;
            this.nombre = nombre;
            this.dpi = dpi;
            this.direc = direc;
            this.tel = tel;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class InsertarClienteResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="InsertarClienteResponse", Namespace="http://LocalHost/WebServiceBiblioteca", Order=0)]
        public WindowsFormsApplication1.ServiceReference1.InsertarClienteResponseBody Body;
        
        public InsertarClienteResponse() {
        }
        
        public InsertarClienteResponse(WindowsFormsApplication1.ServiceReference1.InsertarClienteResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://LocalHost/WebServiceBiblioteca")]
    public partial class InsertarClienteResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string InsertarClienteResult;
        
        public InsertarClienteResponseBody() {
        }
        
        public InsertarClienteResponseBody(string InsertarClienteResult) {
            this.InsertarClienteResult = InsertarClienteResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class NuevoLibroRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="NuevoLibro", Namespace="http://LocalHost/WebServiceBiblioteca", Order=0)]
        public WindowsFormsApplication1.ServiceReference1.NuevoLibroRequestBody Body;
        
        public NuevoLibroRequest() {
        }
        
        public NuevoLibroRequest(WindowsFormsApplication1.ServiceReference1.NuevoLibroRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://LocalHost/WebServiceBiblioteca")]
    public partial class NuevoLibroRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string nombre;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string autor;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string tema;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string pag;
        
        public NuevoLibroRequestBody() {
        }
        
        public NuevoLibroRequestBody(string nombre, string autor, string tema, string pag) {
            this.nombre = nombre;
            this.autor = autor;
            this.tema = tema;
            this.pag = pag;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class NuevoLibroResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="NuevoLibroResponse", Namespace="http://LocalHost/WebServiceBiblioteca", Order=0)]
        public WindowsFormsApplication1.ServiceReference1.NuevoLibroResponseBody Body;
        
        public NuevoLibroResponse() {
        }
        
        public NuevoLibroResponse(WindowsFormsApplication1.ServiceReference1.NuevoLibroResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://LocalHost/WebServiceBiblioteca")]
    public partial class NuevoLibroResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string NuevoLibroResult;
        
        public NuevoLibroResponseBody() {
        }
        
        public NuevoLibroResponseBody(string NuevoLibroResult) {
            this.NuevoLibroResult = NuevoLibroResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ConsultaRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Consulta", Namespace="http://LocalHost/WebServiceBiblioteca", Order=0)]
        public WindowsFormsApplication1.ServiceReference1.ConsultaRequestBody Body;
        
        public ConsultaRequest() {
        }
        
        public ConsultaRequest(WindowsFormsApplication1.ServiceReference1.ConsultaRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://LocalHost/WebServiceBiblioteca")]
    public partial class ConsultaRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string buscar;
        
        public ConsultaRequestBody() {
        }
        
        public ConsultaRequestBody(string buscar) {
            this.buscar = buscar;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ConsultaResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ConsultaResponse", Namespace="http://LocalHost/WebServiceBiblioteca", Order=0)]
        public WindowsFormsApplication1.ServiceReference1.ConsultaResponseBody Body;
        
        public ConsultaResponse() {
        }
        
        public ConsultaResponse(WindowsFormsApplication1.ServiceReference1.ConsultaResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://LocalHost/WebServiceBiblioteca")]
    public partial class ConsultaResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string ConsultaResult;
        
        public ConsultaResponseBody() {
        }
        
        public ConsultaResponseBody(string ConsultaResult) {
            this.ConsultaResult = ConsultaResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class PrestamoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Prestamo", Namespace="http://LocalHost/WebServiceBiblioteca", Order=0)]
        public WindowsFormsApplication1.ServiceReference1.PrestamoRequestBody Body;
        
        public PrestamoRequest() {
        }
        
        public PrestamoRequest(WindowsFormsApplication1.ServiceReference1.PrestamoRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://LocalHost/WebServiceBiblioteca")]
    public partial class PrestamoRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string libro;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string estudiante;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string salida;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string devolucion;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string estado;
        
        public PrestamoRequestBody() {
        }
        
        public PrestamoRequestBody(string libro, string estudiante, string salida, string devolucion, string estado) {
            this.libro = libro;
            this.estudiante = estudiante;
            this.salida = salida;
            this.devolucion = devolucion;
            this.estado = estado;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class PrestamoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="PrestamoResponse", Namespace="http://LocalHost/WebServiceBiblioteca", Order=0)]
        public WindowsFormsApplication1.ServiceReference1.PrestamoResponseBody Body;
        
        public PrestamoResponse() {
        }
        
        public PrestamoResponse(WindowsFormsApplication1.ServiceReference1.PrestamoResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://LocalHost/WebServiceBiblioteca")]
    public partial class PrestamoResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string PrestamoResult;
        
        public PrestamoResponseBody() {
        }
        
        public PrestamoResponseBody(string PrestamoResult) {
            this.PrestamoResult = PrestamoResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ServicioBibliotecaSoapChannel : WindowsFormsApplication1.ServiceReference1.ServicioBibliotecaSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicioBibliotecaSoapClient : System.ServiceModel.ClientBase<WindowsFormsApplication1.ServiceReference1.ServicioBibliotecaSoap>, WindowsFormsApplication1.ServiceReference1.ServicioBibliotecaSoap {
        
        public ServicioBibliotecaSoapClient() {
        }
        
        public ServicioBibliotecaSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicioBibliotecaSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioBibliotecaSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioBibliotecaSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WindowsFormsApplication1.ServiceReference1.InsertarClienteResponse WindowsFormsApplication1.ServiceReference1.ServicioBibliotecaSoap.InsertarCliente(WindowsFormsApplication1.ServiceReference1.InsertarClienteRequest request) {
            return base.Channel.InsertarCliente(request);
        }
        
        public string InsertarCliente(string carnet, string nombre, string dpi, string direc, string tel) {
            WindowsFormsApplication1.ServiceReference1.InsertarClienteRequest inValue = new WindowsFormsApplication1.ServiceReference1.InsertarClienteRequest();
            inValue.Body = new WindowsFormsApplication1.ServiceReference1.InsertarClienteRequestBody();
            inValue.Body.carnet = carnet;
            inValue.Body.nombre = nombre;
            inValue.Body.dpi = dpi;
            inValue.Body.direc = direc;
            inValue.Body.tel = tel;
            WindowsFormsApplication1.ServiceReference1.InsertarClienteResponse retVal = ((WindowsFormsApplication1.ServiceReference1.ServicioBibliotecaSoap)(this)).InsertarCliente(inValue);
            return retVal.Body.InsertarClienteResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WindowsFormsApplication1.ServiceReference1.NuevoLibroResponse WindowsFormsApplication1.ServiceReference1.ServicioBibliotecaSoap.NuevoLibro(WindowsFormsApplication1.ServiceReference1.NuevoLibroRequest request) {
            return base.Channel.NuevoLibro(request);
        }
        
        public string NuevoLibro(string nombre, string autor, string tema, string pag) {
            WindowsFormsApplication1.ServiceReference1.NuevoLibroRequest inValue = new WindowsFormsApplication1.ServiceReference1.NuevoLibroRequest();
            inValue.Body = new WindowsFormsApplication1.ServiceReference1.NuevoLibroRequestBody();
            inValue.Body.nombre = nombre;
            inValue.Body.autor = autor;
            inValue.Body.tema = tema;
            inValue.Body.pag = pag;
            WindowsFormsApplication1.ServiceReference1.NuevoLibroResponse retVal = ((WindowsFormsApplication1.ServiceReference1.ServicioBibliotecaSoap)(this)).NuevoLibro(inValue);
            return retVal.Body.NuevoLibroResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WindowsFormsApplication1.ServiceReference1.ConsultaResponse WindowsFormsApplication1.ServiceReference1.ServicioBibliotecaSoap.Consulta(WindowsFormsApplication1.ServiceReference1.ConsultaRequest request) {
            return base.Channel.Consulta(request);
        }
        
        public string Consulta(string buscar) {
            WindowsFormsApplication1.ServiceReference1.ConsultaRequest inValue = new WindowsFormsApplication1.ServiceReference1.ConsultaRequest();
            inValue.Body = new WindowsFormsApplication1.ServiceReference1.ConsultaRequestBody();
            inValue.Body.buscar = buscar;
            WindowsFormsApplication1.ServiceReference1.ConsultaResponse retVal = ((WindowsFormsApplication1.ServiceReference1.ServicioBibliotecaSoap)(this)).Consulta(inValue);
            return retVal.Body.ConsultaResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WindowsFormsApplication1.ServiceReference1.PrestamoResponse WindowsFormsApplication1.ServiceReference1.ServicioBibliotecaSoap.Prestamo(WindowsFormsApplication1.ServiceReference1.PrestamoRequest request) {
            return base.Channel.Prestamo(request);
        }
        
        public string Prestamo(string libro, string estudiante, string salida, string devolucion, string estado) {
            WindowsFormsApplication1.ServiceReference1.PrestamoRequest inValue = new WindowsFormsApplication1.ServiceReference1.PrestamoRequest();
            inValue.Body = new WindowsFormsApplication1.ServiceReference1.PrestamoRequestBody();
            inValue.Body.libro = libro;
            inValue.Body.estudiante = estudiante;
            inValue.Body.salida = salida;
            inValue.Body.devolucion = devolucion;
            inValue.Body.estado = estado;
            WindowsFormsApplication1.ServiceReference1.PrestamoResponse retVal = ((WindowsFormsApplication1.ServiceReference1.ServicioBibliotecaSoap)(this)).Prestamo(inValue);
            return retVal.Body.PrestamoResult;
        }
    }
}
