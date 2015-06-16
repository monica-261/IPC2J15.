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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre, autor, tema, pag;
            ServiceReference1.ServicioBibliotecaSoapClient servicio = new ServiceReference1.ServicioBibliotecaSoapClient();
            
            nombre = textBox1.Text;
            autor = textBox2.Text;
            tema = textBox3.Text;
            pag = textBox4.Text;

            servicio.NuevoLibro(nombre, autor, tema, pag);


            
        }
    }
}
