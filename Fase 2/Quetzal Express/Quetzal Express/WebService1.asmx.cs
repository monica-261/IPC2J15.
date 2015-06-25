using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Quetzal_Express
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://LocalHost/WebServiceProyecto")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        string conexion = "Data Source=MONICA-DELL\\MONICA;Initial Catalog=QuetzalExpress;Integrated Security=True";
        string cadenaconsulta;
        SqlConnection CN;
        SqlCommand comando;
        

        string datos = "";
        public void Insertar(string CadenaAInsertar)
        {
            CN = new SqlConnection(conexion);
            comando = new SqlCommand(CadenaAInsertar, CN);
            CN.Open();
            comando.ExecuteNonQuery();
            CN.Close();
        }

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
         [WebMethod]
        public string InsertarCliente(string nombre, string apellido, string usuario, string pass, string dpi, string nit, string tel, string dir, string tar)
        {
            cadenaconsulta = "insert into Cliente (nombre,apellido,usuario,contrasenia,dpi,nit,telefono,direccion,tarjeta) values ('" + nombre + "','" + apellido + "','" + usuario + "','" + pass + "','" + dpi + "','" + nit + "','" + tel + "','" + dir + "','" + tar + "')";
            Insertar(cadenaconsulta);
            return datos = "datos ingresados";
        }
        [WebMethod]
         public string InsertarEmpleado(string nombre, string apellido, string user, string pass, string sueldo, string sucursal, string puesto, string cargo)
         {
             cadenaconsulta = "insert into Empleado (nombre,apellido,usuario,contrasenia,sueldo,sucursal,cargo,departamento) values ('" + nombre + "','" + apellido + "','" + user + "','" + pass + "','" + sueldo + "','" + sucursal + "','" + puesto + "','" + cargo + "')";
             Insertar(cadenaconsulta);
             return datos = "Empleado Creado";
         
         }
        [WebMethod]
        public string Modificar(int buscar, string sueldo, string puesto, string sucursal, string departamento )
        {
            cadenaconsulta = "update Empleado set sueldo = '" + sueldo + "',cargo ='" + puesto + "',sucursal='" + sucursal + "',departamento ='" + departamento + "' where cod_emp ='" + buscar + "'";
            Insertar(cadenaconsulta);
            return datos = "Empleado modificado";
        }
        [WebMethod]
        public string Despedir(int buscar)
        { 
            cadenaconsulta = "delete from Empleado where cod_emp ='" + buscar + "'";
            Insertar(cadenaconsulta);
            return datos = "Empleado Despedido";
        
        
        
        }
    }
}
