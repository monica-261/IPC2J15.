using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Quetzal_Express
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            if (RadioButton1.Checked)
            {
                Server.Transfer("WebForm8.aspx");
            }
            if (RadioButton3.Checked)
            {
                Server.Transfer("WebForm6.aspx");
            }
        }
    }
}