using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Quetzal_Express
{
    public partial class InicioAdm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {

            if (RadioButton1.Checked)
            {
                Server.Transfer("CargaMasiva.aspx");
            }
            if (RadioButton2.Checked)
            {
                Server.Transfer("ModContr.aspx");
            }
        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
        }
    }
}