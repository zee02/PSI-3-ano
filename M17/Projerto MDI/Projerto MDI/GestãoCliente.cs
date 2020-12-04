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
    public partial class GestãoCliente : Form
    {
        string connection = "server = localhost; port = 3307; database=eventos; uid=root; pwd=root ";
        public GestãoCliente()
        {
            InitializeComponent();
        }

        private void btnApaga_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlcon = new MySqlConnection(connection))
            {
                mysqlcon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("ClienteApaga", mysqlcon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_nif", long.Parse(txtNif.Text));
                mySqlCmd.ExecuteNonQuery();
                MessageBox.Show("Apagado com sucesso");
                limpa();
                preenche();
            }
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

        private void limpa()
        {

            txtNif.Text = txtLocal.Text = txtContacto.Text = txtNome.Text = "";


            btnApaga.Enabled = false;

            btnAltera.Enabled = false;

            txtNome.Enabled = false;
            txtNif.Enabled = false;
            txtLocal.Enabled = false;
            txtContacto.Enabled = false;
        }

        private void btnAltera_Click(object sender, EventArgs e)
        {
            txtContacto.Enabled = true;
            txtLocal.Enabled = true;
            txtNome.Enabled = true;
            btnInserir.Enabled = true;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (txtNif.Text != "" && txtNome.Text != "" && txtLocal.Text != "" && txtContacto.Text != " ")
            {
                using (MySqlConnection mysqlcon = new MySqlConnection(connection))
                {
                    mysqlcon.Open();
                    MySqlCommand mySqlCmd = new MySqlCommand("ClienteAdiciona", mysqlcon);

                    mySqlCmd.CommandType = CommandType.StoredProcedure;

                    mySqlCmd.Parameters.AddWithValue("_nif", txtNif.Text.Trim());
                    mySqlCmd.Parameters.AddWithValue("_nome", txtNome.Text.Trim());
                    mySqlCmd.Parameters.AddWithValue("_contacto", txtContacto.Text.Trim());
                    mySqlCmd.Parameters.AddWithValue("_localidade", txtLocal.Text.Trim());

                    mySqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Submetido com sucesso");

                    limpa();
                    preenche();

                    btnInserir.Enabled = false;
                }
            }
            else
                MessageBox.Show("Deves inserir todos os campos!", "Aviso!", MessageBoxButtons.OK);
        }

        private void btnGuarda_Click(object sender, EventArgs e)
        {

        }

        private void GestãoCliente_Load(object sender, EventArgs e)
        {
            preenche();
        }

        private void dgvCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCliente.CurrentRow.Index != 1)
            {
                txtNif.Text = dgvCliente.CurrentRow.Cells[0].Value.ToString();
                txtNome.Text = dgvCliente.CurrentRow.Cells[1].Value.ToString();
                txtContacto.Text = dgvCliente.CurrentRow.Cells[2].Value.ToString();
                txtLocal.Text = dgvCliente.CurrentRow.Cells[3].Value.ToString();


                btnAltera.Enabled = true;
                btnInserir.Enabled = false;
                btnApaga.Enabled = true;
            }
        }
    }
}
