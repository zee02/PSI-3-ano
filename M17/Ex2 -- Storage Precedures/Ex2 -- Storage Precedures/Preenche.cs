using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Ex2____Storage_Precedures
{
    public partial class PesquisaLivros : Form
    {
        string connection = "server = localhost; port = 3307; database=biblioteca; uid=root; pwd=root ";

        public PesquisaLivros()
        {
            InitializeComponent();
        }

        private void dgvLivros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Preenche_Load(object sender, EventArgs e)
        {
            preenche();
        }


        private void preenche()
        {

            using (MySqlConnection mysqlcon = new MySqlConnection(connection))
            {
                mysqlcon.Open();

                MySqlDataAdapter sqlada = new MySqlDataAdapter("LivroVeTudo", mysqlcon);

                sqlada.SelectCommand.CommandType = CommandType.StoredProcedure;


                DataTable dtblBook = new DataTable();

                sqlada.Fill(dtblBook);

                dgvLivros.DataSource = dtblBook;

                // dgvLivros.Columns[0].Visible = false;



            }
        }

        private void btnProcura_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlcon = new MySqlConnection(connection))
            {
                mysqlcon.Open();
                MySqlDataAdapter sqlAda = new MySqlDataAdapter("LivroProcuraValor", mysqlcon);
                sqlAda.SelectCommand.CommandType = CommandType.StoredProcedure;

                sqlAda.SelectCommand.Parameters.AddWithValue("_SearchValue", txtProcurar.Text);


                DataTable dtblBook = new DataTable();

                sqlAda.Fill(dtblBook);

                dgvLivros.DataSource = dtblBook;

                dgvLivros.Columns[0].Visible = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Close();
        }
    }
}
