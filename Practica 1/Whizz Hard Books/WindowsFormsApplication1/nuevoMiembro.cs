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
    public partial class nuevoMiembro : Form
    {

        
        public nuevoMiembro()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PaginaPrincipal pg = new PaginaPrincipal();
            
            pg.Show();
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string carnet, nombre, dpi, dir, tel;
            //ServiceReference1.Biblioteca servicio = ne
            //WebServiceBiblio Servicio = new WebServiceBiblio();
            
            ServiceReference1.ServicioBibliotecaSoapClient servicio = new ServiceReference1.ServicioBibliotecaSoapClient();    


            carnet = textBox1.Text;
            nombre = textBox2.Text;
            dpi = textBox3.Text;
            dir = textBox4.Text;
            tel = textBox5.Text;

            servicio.InsertarCliente(carnet, nombre, dpi, dir, tel);
            
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";

            

            
            
            



        }
    }
}
