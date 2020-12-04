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
    public partial class EventoTipoApaga : Form
    {
        string connection = "server = localhost; port = 3307; database=eventos; uid=root; pwd=root ";

        public EventoTipoApaga()
        {
            InitializeComponent();
        }

        private void EventoTipoApaga_Load(object sender, EventArgs e)
        {
            preenche();
            btnNovo.Enabled = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void preenche()
        {
            using (MySqlConnection mysqlcon = new MySqlConnection(connection))
            {
                mysqlcon.Open();

                MySqlDataAdapter sqlada = new MySqlDataAdapter("EventoProcura", mysqlcon);

                sqlada.SelectCommand.CommandType = CommandType.StoredProcedure;


                DataTable dtblBook = new DataTable();

                sqlada.Fill(dtblBook);

                dgvEventos.DataSource = dtblBook;
            }
        }
        private void dgvLivros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dgvEventos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvEventos.CurrentRow.Index != 1)
            {
                txtID.Text = dgvEventos.CurrentRow.Cells[0].Value.ToString();
                txtDesign.Text = dgvEventos.CurrentRow.Cells[1].Value.ToString();
                txtObs.Text = dgvEventos.CurrentRow.Cells[2].Value.ToString();
                txtValor.Text = dgvEventos.CurrentRow.Cells[3].Value.ToString();


                btnAltera.Enabled = true;
                btnGuarda.Enabled = false;
                btnApaga.Enabled = true;
            }
        }

        private void btnAltera_Click(object sender, EventArgs e)
        {
            txtDesign.Enabled = true;
            txtObs.Enabled = true;
            btnGuarda.Enabled = true;
            txtValor.Enabled = true;
        }
        private void limpa()
        {

            txtValor.Text = txtObs.Text = txtID.Text = txtDesign.Text = "";


            btnApaga.Enabled = false;

            btnAltera.Enabled = false;

            txtID.Enabled = false;
            txtDesign.Enabled = false;
            txtObs.Enabled = false;
            txtValor.Enabled = false;
        }

        private void btnGuarda_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "" && txtObs.Text != "" && txtDesign.Text != "" && txtValor.Text != " ")
            {
                using (MySqlConnection mysqlcon = new MySqlConnection(connection))
                {
                    mysqlcon.Open();
                    MySqlCommand mySqlCmd = new MySqlCommand("EventoAdiciona", mysqlcon);

                    mySqlCmd.CommandType = CommandType.StoredProcedure;

                    mySqlCmd.Parameters.AddWithValue("_idevento", txtID.Text.Trim());
                    mySqlCmd.Parameters.AddWithValue("_design", txtDesign.Text.Trim());
                    mySqlCmd.Parameters.AddWithValue("_obs", txtObs.Text.Trim());
                    mySqlCmd.Parameters.AddWithValue("_valor", txtValor.Text.Trim());

                    mySqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Submetido com sucesso");

                    limpa();
                    preenche();

                    btnGuarda.Enabled = false;
                }
            }
            else
                MessageBox.Show("Deves inserir todos os campos!", "Aviso!", MessageBoxButtons.OK);
        }

        private void btnApaga_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlcon = new MySqlConnection(connection))
            {
                mysqlcon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("EventoApaga", mysqlcon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_idevento", long.Parse(txtID.Text));
                mySqlCmd.ExecuteNonQuery();
                MessageBox.Show("Apagado com sucesso");
                limpa();
                preenche();
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            limpa();
            txtID.Text = "";
            txtDesign.Text = "";
            txtObs.Text = "";
            txtValor.Text = "";
            txtID.Enabled = true;
            txtDesign.Enabled = true;
            txtValor.Enabled = true;
            txtObs.Enabled = true;
            btnGuarda.Enabled = true;
            btnInserir.Visible = true;

            dgvEventos.Enabled = false;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "" && txtObs.Text != "" && txtDesign.Text != "" && txtValor.Text != " ")
            {
                using (MySqlConnection mysqlcon = new MySqlConnection(connection))
                {
                    mysqlcon.Open();
                    MySqlCommand mySqlCmd = new MySqlCommand("EventoTipoCria", mysqlcon);

                    mySqlCmd.CommandType = CommandType.StoredProcedure;

                    mySqlCmd.Parameters.AddWithValue("_idevento", txtID.Text.Trim());
                    mySqlCmd.Parameters.AddWithValue("_design", txtDesign.Text.Trim());
                    mySqlCmd.Parameters.AddWithValue("_obs", txtObs.Text.Trim());
                    mySqlCmd.Parameters.AddWithValue("_valor", txtValor.Text.Trim());

                    mySqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Submetido com sucesso");
                    dgvEventos.Enabled = true;
                    limpa();
                    preenche();

                    btnGuarda.Enabled = false;
                    btnInserir.Visible = false;
                }
            }
            else
                MessageBox.Show("Deves inserir todos os campos!", "Aviso!", MessageBoxButtons.OK);

            
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDesign_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtObs_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    }

