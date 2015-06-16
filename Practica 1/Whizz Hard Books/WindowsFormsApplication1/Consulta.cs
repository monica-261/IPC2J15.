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
    public partial class Consulta : Form
    {
        
        public Consulta()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            PaginaPrincipal pg = new PaginaPrincipal();
            pg.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ServiceReference1.ServicioBibliotecaSoapClient servicio = new ServiceReference1.ServicioBibliotecaSoapClient();
            string buscar;
            buscar = textBox1.Text;
            string connectionString = "Data Source=MONICA;Initial Catalog=Practica1;Integrated Security=True";
            string sql = "SELECT * FROM Libro where nombre = @nombre ";
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.CommandText = sql; 
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@nombre",buscar);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;



            servicio.Consulta(buscar);
           

           
        }
    }
}
