using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Quetzal_Express
{
    public partial class CargaMasiva : System.Web.UI.Page
    {
        
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
                    if (RadioButton1.Checked) 
                    {
                        string[] datos = line.Split(new char[] { ',' });
                        cadenaconsulta = "insert into Categoria (nombre,impuesto) values ('" + datos[0] + "','" + datos[1] + "')";
                        Insertar(cadenaconsulta);
                    }
                    if(RadioButton2.Checked)
                    {
                        string[] datos = line.Split(new char[] { ',' });
                        cadenaconsulta = "insert into Categoria (nombre,impuesto) values ('" + datos[0] + "','" + datos[1] + "')";
                        Insertar(cadenaconsulta);


                    }
                }
            }



        }

    }
}