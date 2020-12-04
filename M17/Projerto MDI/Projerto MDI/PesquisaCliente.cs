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

namespace Projerto_MDI
{
    public partial class PesquisaCliente : Form
    {
        string connection = "server = localhost; port = 3307; database=eventos; uid=root; pwd=root ";

        public PesquisaCliente()
        {
            InitializeComponent();
        }

        private void PesquisaCliente_Load(object sender, EventArgs e)
        {
            preenche();
        }

        private void preenche()
        {
            using (MySqlConnection mysqlcon = new MySqlConnection(connection))
            {
                mysqlcon.Open();

                MySqlDataAdapter sqlada = new MySqlDataAdapter("ClienteProcura", mysqlcon);

                sqlada.SelectCommand.CommandType = CommandType.StoredProcedure;


                DataTable dtblBook = new DataTable();

                sqlada.Fill(dtblBook);

                dgvCliente.DataSource = dtblBook;
            }
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlcon = new MySqlConnection(connection))
            {
                mysqlcon.Open();
                MySqlDataAdapter sqlAda = new MySqlDataAdapter("ClienteProcuraValor", mysqlcon);
                sqlAda.SelectCommand.CommandType = CommandType.StoredProcedure;

                sqlAda.SelectCommand.Parameters.AddWithValue("_SearchValue", txtPesquisa.Text);


                DataTable dtblBook = new DataTable();

                sqlAda.Fill(dtblBook);

                dgvCliente.DataSource = dtblBook;

                dgvCliente.Columns[0].Visible = false;
            }
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
