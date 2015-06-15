using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace BibliotecaWebService
{
    /// <summary>
    /// Summary description for Service1
    /// </summary>
    [WebService(Namespace = "http://LocalHost/WebServiceBiblioteca",Name= "Servicio Biblioteca",Description="Servicio web para biblioteca" )]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Service1 : System.Web.Services.WebService
    {
        string conexion = "Data Source=MONICA;Initial Catalog=Practica1;Integrated Security=True";
        string cadenaconsulta;
        SqlConnection CN;
        SqlCommand comando;

        string error = "";

        public void Insertar(string CadenaAInsertar)
        {
            CN = new SqlConnection(conexion);
            comando = new SqlCommand(CadenaAInsertar, CN);
            CN.Open();
            comando.ExecuteNonQuery();
            CN.Close();
        }
        [WebMethod]
        public string InsertarCliente(string carnet, string nombre, string dpi, string direc, string tel)
        {
            cadenaconsulta = "insert into Miembro (nombre,carnet,dpi,direccion,telefono) values ('" + nombre + "','" + carnet + "','" + dpi + "','" + direc + "','" + tel + "')";
            Insertar(cadenaconsulta);
            return error = "datos ingresados";
       }

    }
}