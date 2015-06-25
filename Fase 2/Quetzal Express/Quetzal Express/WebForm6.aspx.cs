using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Quetzal_Express
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            string cod;
            cod = TextBox1.Text;
            string connectionString = "Data Source=MONICA-DELL\\MONICA;Initial Catalog=QuetzalExpress;Integrated Security=True";
            string sql = "SELECT cod_cliente, nombre,apellido FROM Cliente where nombre = '" + TextBox1.Text + "' and apellido = '"+TextBox3.Text+"'";

            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            SqlDataReader leer = cmd.ExecuteReader();
            if (leer.Read() == true)
            {
                TextBox2.Text = leer["cod_cliente"].ToString();
            }
            else
            {
                TextBox2.Text = "";
                




            }
            conn.Close();
           
        }
    }
}