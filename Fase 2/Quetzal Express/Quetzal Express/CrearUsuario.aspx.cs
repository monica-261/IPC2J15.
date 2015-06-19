using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Quetzal_Express
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        string nombre, apellido, usuario, contrasenia, confirmacion, dpi, nit, tel, dir, tarjeta;
        WebService1 servicio = new WebService1();

        protected void Button2_Click(object sender, EventArgs e)
        {
            Server.Transfer("PaginaPrincipal.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            nombre = TextBox1.Text.Trim();
            apellido = TextBox2.Text.Trim();
            usuario = TextBox3.Text.Trim();
            contrasenia = TextBox4.Text.Trim();
            confirmacion = TextBox5.Text.Trim();
            dpi = TextBox6.Text.Trim();
            nit = TextBox7.Text.Trim();
            tel = TextBox8.Text.Trim();
            dir = TextBox9.Text.Trim();
            tarjeta = TextBox10.Text.Trim();

            if (contrasenia != confirmacion)
            {
                string error = "Las contraseñas no coinciden";
                Label1.Text = error;

            }
            else
            {
                Label1.Text = " ";
                servicio.InsertarCliente(nombre, apellido, usuario, contrasenia, dpi, nit, tel, dir, tarjeta);

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
            TextBox10.Text = " ";

         
        }
    }
}