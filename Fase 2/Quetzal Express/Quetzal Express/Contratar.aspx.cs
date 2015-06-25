using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data.SqlClient;

namespace Quetzal_Express
{
    public partial class Contratacion : System.Web.UI.Page
    {
        string nombre, apellido, usuario, contrasenia, confirmacion, sueldo, sucursal, puesto, cargo;
        WebService1 servicio = new WebService1();
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



        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            nombre = TextBox1.Text.Trim();
            apellido = TextBox2.Text.Trim();
            usuario = TextBox3.Text.Trim();
            contrasenia = TextBox4.Text.Trim();
            confirmacion = TextBox5.Text.Trim();
            sueldo = TextBox6.Text.Trim();
            sucursal = TextBox7.Text.Trim();
            puesto = TextBox8.Text.Trim();
            cargo = TextBox9.Text.Trim();
            

            if (contrasenia != confirmacion)
            {
                string error = "Las contraseñas no coinciden";
                Label1.Text = error;

            }
            else
            {
                Label1.Text = " ";
                servicio.InsertarEmpleado(nombre,apellido,usuario,contrasenia,sueldo,sucursal,puesto,cargo);
                
            }
            TextBox1.Text = " ";
            TextBox2.Text = " ";
            TextBox3.Text = " ";
            TextBox1.Text = " ";
            TextBox2.Text = " ";
            TextBox4.Text = " ";
            TextBox5.Text = " ";
            TextBox6.Text = " ";
            TextBox7.Text = " ";
            TextBox8.Text = " ";
            TextBox9.Text = " ";


        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {

            Boolean fileOK = false;
            String DireccionArchivo = Server.MapPath(FileUpload1.FileName);
            if (FileUpload1.HasFile)
            {
                String fileExtension =
                    System.IO.Path.GetExtension(FileUpload1.FileName).ToLower();
                String[] allowedExtensions = { ".xml" };
                for (int i = 0; i < allowedExtensions.Length; i++)
                {
                    if (fileExtension == allowedExtensions[i])
                    {
                        fileOK = true;
                        //}
                        //}
                    }
                }
                cargarArchivo(DireccionArchivo);
            }
        }

        public void cargarArchivo(string path)
        {
            using (StreamReader fielRead = new StreamReader(path))
            {
                string line = null;

                while ((line = fielRead.ReadLine()) != null)
                {
                    string[] datos = line.Split(new char[] { ',' });
                    cadenaconsulta = "insert into Empleado (nombre,apellido,sueldo,sucursal,departamento) values ('" + datos[1] + "','" + datos[0] + "','" + datos[2] + "','" + datos[3] + "','" + datos[4] + "')";
                    Insertar(cadenaconsulta);
                }
            }



        }
        

    }
}