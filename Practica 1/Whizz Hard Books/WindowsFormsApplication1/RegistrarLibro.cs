using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class RegistrarLibro : Form
    {
        
        public RegistrarLibro()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PaginaPrincipal pg = new PaginaPrincipal();
            pg.Show();
            this.Close();

            
        }
    }
}
