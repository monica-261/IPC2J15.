using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Prestamo : Form
    {
        public Prestamo()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string buscar;
            buscar = textBox1.Text;
            string connectionString = "Data Source=MONICA;Initial Catalog=Practica1;Integrated Security=True";
            string sql = "SELECT cod_libro, autor, estado FROM Libro where ((nombre = '"+textBox1.Text+"') and (estado = 'disponible') )";
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            SqlDataReader leer = cmd.ExecuteReader();
            if (leer.Read() == true)
            {
                textBox4.Text = leer["cod_libro"].ToString();
                textBox2.Text = leer["autor"].ToString();
                textBox3.Text = leer["estado"].ToString();
            }
            else
            {
                textBox2.Text = "";
                textBox3.Text = "";
            }
            conn.Close();
              
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            PaginaPrincipal pg = new PaginaPrincipal();
            pg.Show();
            this.Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string carnet;
            carnet = textBox5.Text;
            string connectionString = "Data Source=MONICA;Initial Catalog=Practica1;Integrated Security=True";
            string sql1 = "SELECT cod_miembro FROM Miembro where carnet = '" + textBox5.Text + "'";
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql1, conn);
            conn.Open();
            SqlDataReader leer = cmd.ExecuteReader();
            if (leer.Read() == true)
            {
                textBox6.Text = leer["cod_miembro"].ToString();

            }
            else
            {
                textBox5.Text = "";
            }
            conn.Close();
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            string cod_libro, cod_est, salida, entrada,estado;
            ServiceReference1.ServicioBibliotecaSoapClient servicio = new ServiceReference1.ServicioBibliotecaSoapClient();

            cod_libro = textBox4.Text;
            cod_est = textBox6.Text;
            salida = textBox7.Text;
            entrada = textBox8.Text;
            estado = textBox3.Text;
            
            servicio.Prestamo(cod_libro,cod_est,salida,entrada,estado);





        }
    }
}
