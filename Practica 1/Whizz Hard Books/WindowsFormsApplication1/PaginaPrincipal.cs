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
    public partial class PaginaPrincipal : Form
    {
        //ConsultaLibro consulta = new ConsultaLibro();
        //MasPrestados maspres = new MasPrestados();
        //NuevoMiembro miembro = new NuevoMiembro();
        //Prestamo prestamo = new Prestamo();

      

        public PaginaPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            if (radioButton1.Checked)
            {
                RegistrarLibro libro = new RegistrarLibro();
                libro.Show();
                this.Hide();
            }
            if (radioButton2.Checked)
            {
                Consulta consulta = new Consulta();
                consulta.Show();
                this.Hide();
            }
            //if (radioButton3.Checked)
            //{
            //    prestamo.Show();
            //    this.Hide();
            //}
            if (radioButton4.Checked)
            {
                nuevoMiembro miembro = new nuevoMiembro();
                miembro.Show();
                this.Hide();
            }
            //if (radioButton5.Checked)
            //{
            //    maspres.Show();
            //    this.Hide();
            //}

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
