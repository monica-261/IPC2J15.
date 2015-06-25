using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Quetzal_Express
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Server.Transfer("CrearUsuario.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string conexion;
            conexion = "Data Source=MONICA-DELL\\MONICA;Initial Catalog=QuetzalExpress;Integrated Security=True";

            SqlConnection cnn = new SqlConnection(conexion);
            cnn.Open();
            SqlCommand cmd = new SqlCommand("Login", cnn); 
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@user", SqlDbType.VarChar).Value = TextBox1.Text;
            cmd.Parameters.Add("@pass", SqlDbType.VarChar).Value = TextBox2.Text;
            SqlParameter ParametroRetorno = new SqlParameter("@Resultado", SqlDbType.Int);
            ParametroRetorno.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(ParametroRetorno);
            cmd.ExecuteNonQuery();
            int respuesta = Convert.ToInt32(ParametroRetorno.Value);
            

            if (respuesta == 1)
            {
                Response.Redirect("InicioAdm.aspx");
                //Server.Transfer("InicioAdm.aspx");
            }
            if (respuesta == 2)
            {
                //Response.Redirect("InicioDir.aspx");
                Server.Transfer("InicioDir.aspx");
            }
            if (respuesta == 3)
            {
                Response.Redirect("InicioEmp.aspx");
                //Server.Transfer("InicioEmp.aspx");
            }
            if (respuesta == 4)
            {
                Response.Redirect("InicioClien.aspx");
            }
            

        }
    }
}