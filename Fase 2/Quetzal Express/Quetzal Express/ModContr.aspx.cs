using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Quetzal_Express
{
    public partial class ModContr : System.Web.UI.Page
    {
        string sueldo,puesto,sucursal,departamento;
        WebService1 servicio = new WebService1();
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            string buscar;
            buscar = TextBox1.Text;

            string connectionString = "Data Source=MONICA-DELL\\MONICA;Initial Catalog=QuetzalExpress;Integrated Security=True";
            string sql = "SELECT cod_emp, nombre, apellido, sueldo,cargo,sucursal,departamento FROM Empleado where cod_emp = '"+TextBox1.Text+"'";

            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            SqlDataReader leer = cmd.ExecuteReader();
            if (leer.Read() == true)
            {
                Label1.Text = leer["nombre"].ToString();
                Label2.Text = leer ["apellido"].ToString();
                TextBox3.Text = leer ["sueldo"].ToString();
                TextBox4.Text = leer ["cargo"].ToString();
                TextBox5.Text = leer ["sucursal"].ToString();
                TextBox6.Text = leer ["departamento"].ToString();
            }
            else
            {
                Label1.Text= "";
                Label2.Text = "";
                TextBox3.Text= "";
                TextBox4.Text= "";
                TextBox5.Text= "";
                TextBox6.Text= "";




            }
            conn.Close();
              
           
        }


        

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int buscar;
            buscar = Convert.ToInt32(TextBox1.Text);
           // buscar = TextBox1.Text;
            sueldo = TextBox3.Text;
            puesto = TextBox4.Text;
            sucursal = TextBox5.Text;
            departamento = TextBox6.Text;

            servicio.Modificar(buscar, sueldo, puesto, sucursal, departamento);

            Label1.Text = "";
            Label2.Text = "";
            TextBox1.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
        }
    }
}