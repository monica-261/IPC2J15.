using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Quetzal_Express
{
    public partial class DespEmp : System.Web.UI.Page
    {
        WebService1 servicio = new WebService1();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            string cod;
            cod = TextBox1.Text;
            string connectionString = "Data Source=MONICA-DELL\\MONICA;Initial Catalog=QuetzalExpress;Integrated Security=True";
            string sql = "SELECT cod_emp, nombre,apellido,cargo  FROM Empleado where cod_emp = '"+TextBox1.Text+"'";

            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            SqlDataReader leer = cmd.ExecuteReader();
            if (leer.Read() == true)
            {
                Label1.Text = leer["nombre"].ToString();
                Label2.Text = leer["apellido"].ToString();
                TextBox3.Text = leer["cargo"].ToString();
            }
            else
            {
                TextBox1.Text= "";
                Label1.Text= "";
                Label2.Text = "";
                TextBox3.Text= "";
                



            }
            conn.Close();
              
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int buscar;
            buscar = Convert.ToInt32(TextBox1.Text);
            servicio.Despedir(buscar);

            TextBox1.Text = "";
            Label1.Text = "";
            Label2.Text = "";
            TextBox3.Text = "";
                
        }
        
    }
}