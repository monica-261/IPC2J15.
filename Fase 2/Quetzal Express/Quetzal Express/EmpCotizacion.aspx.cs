using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Quetzal_Express
{
    public partial class Cotizacion : System.Web.UI.Page
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


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string peso, costo, cat;

            costo = TextBox1.Text;
            peso = TextBox2.Text;
            cat = TextBox3.Text;

            string connectionString = "Data Source=MONICA-DELL\\MONICA;Initial Catalog=QuetzalExpress;Integrated Security=True";
            string sql = "select nombre, impuesto  FROM Categoria where nombre='"+cat+"'";
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            SqlDataReader leer = cmd.ExecuteReader();
            int pesoVal = Convert.ToInt32(peso);
            int costoVal = Convert.ToInt32(costo);
           // int catVal = Convert.ToInt32(cat);
            if (leer.Read() == true)
            {
                string impuesto;
                    //impuesto = leer["impuesto"].ToString();

                int imp = 15;
                int CostPerLibra = pesoVal * 5;
                int CostImp = (costoVal * imp) / 100;
                int subTotal = CostPerLibra + CostImp;

                TextBox4.Text = subTotal.ToString();



                
            }
            else
            {
                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";
            }
            conn.Close();
             


        }
    }
}