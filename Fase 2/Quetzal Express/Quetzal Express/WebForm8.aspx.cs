using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Quetzal_Express
{
    public partial class WebForm8 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
           
            string connectionString = "Data Source=MONICA-DELL\\MONICA;Initial Catalog=QuetzalExpress;Integrated Security=True";
            string sql = "SELECT cod_cliente, nombre,apellido  FROM Cliente where cod_cliente = '"+TextBox1.Text+"'";

            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            SqlDataReader leer = cmd.ExecuteReader();
            if (leer.Read() == true)
            {
                Label1.Text = leer["nombre"].ToString();
                Label2.Text = leer["apellido"].ToString();
                
            }
            else
            {
                TextBox1.Text= "";
                Label1.Text= "";
                Label2.Text = "";
              
                



            }
            conn.Close();
        }
    }
}