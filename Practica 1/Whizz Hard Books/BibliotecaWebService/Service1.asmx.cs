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
        public string InsertarCliente(string carnet, string nombre, string dpi, string direc, string tel)
        {
            cadenaconsulta = "insert into Miembro (nombre,carnet,dpi,direccion,telefono) values ('" + nombre + "','" + carnet + "','" + dpi + "','" + direc + "','" + tel + "')";
            Insertar(cadenaconsulta);
            return datos = "datos ingresados";
       }
        [WebMethod]
        public string NuevoLibro(string nombre, string autor, string tema, string pag)
        {
            cadenaconsulta = "insert into Libro (nombre,paginas,tema,autor) values ('" + nombre + "','" + pag + "','" +tema+"','"+autor+"')";
            Insertar(cadenaconsulta);
                return datos = "datos ingresados";
        }
        [WebMethod]
        public string Consulta(string buscar)
        {
            cadenaconsulta = "select * from Libro where nombre='buscar'";
            Insertar(cadenaconsulta);
            return datos = "busqueda finalizada";
                   
        }
        [WebMethod]
        public string Prestamo(string libro, string estudiante, string salida, string devolucion,string estado)
        {
            cadenaconsulta = "insert into Prestamo (fecha_inicio,fecha_fin,cod_libro,cod_miembro) values ('" + salida+ "','" +devolucion+ "','" + libro + "','" + estudiante + "'); update Libro set estado= 'Prestado' where cod_libro ='"+libro+"'";
            Insertar(cadenaconsulta);
            return datos = "datos ingresados";
        }

    }
}