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
    public partial class Form1 : Form
    {
        string connection = "server = localhost; port = 3307; database=biblioteca; uid=root; pwd=root ";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            limpa();
            preenche();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            limpa();
            txtAutor.Text = "";
            txtEditora.Text = "";
            txtISBN.Text = "";
            txtTitulo.Text = "";
            txtISBN.Enabled = true;
            txtEditora.Enabled = true;
            txtAutor.Enabled = true;
            txtTitulo.Enabled = true;
            btnGuarda.Enabled = true;
        }

        private void btnAltera_Click(object sender, EventArgs e)
        {
            txtEditora.Enabled = true;
            txtAutor.Enabled = true;
            txtTitulo.Enabled = true;
            btnGuarda.Enabled = true;

        }

        private void limpa()
        {

            txtISBN.Text = txtAutor.Text = txtEditora.Text = txtTitulo.Text = "";


            btnAltera.Enabled = false;

            btnRemove.Enabled = false;

            txtISBN.Enabled = false;
            txtEditora.Enabled = false;
            txtAutor.Enabled = false;
            txtTitulo.Enabled = false;
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

        private void dgvLivros_DoubleClick(object sender, EventArgs e)
        {

            if (dgvLivros.CurrentRow.Index != 1)
            {
                txtISBN.Text = dgvLivros.CurrentRow.Cells[0].Value.ToString();
                txtTitulo.Text = dgvLivros.CurrentRow.Cells[1].Value.ToString();
                txtAutor.Text = dgvLivros.CurrentRow.Cells[2].Value.ToString();
                txtEditora.Text = dgvLivros.CurrentRow.Cells[3].Value.ToString();


                btnAltera.Enabled = true;
                btnGuarda.Enabled = false;
                btnRemove.Enabled = true;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlcon = new MySqlConnection(connection))
            {
                mysqlcon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("LivroApagaporID", mysqlcon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_ISBN", long.Parse(txtISBN.Text));
                mySqlCmd.ExecuteNonQuery();
                MessageBox.Show("Apagado com sucesso");
                limpa();
                preenche();
            }
        }

        private void btnGuarda_Click(object sender, EventArgs e)
        {
            if (txtAutor.Text != "" && txtEditora.Text != "" && txtISBN.Text != "" && txtTitulo.Text != " ")
            {
                using (MySqlConnection mysqlcon = new MySqlConnection(connection))
                {
                    mysqlcon.Open();
                    MySqlCommand mySqlCmd = new MySqlCommand("LivroAdiciona", mysqlcon);

                    mySqlCmd.CommandType = CommandType.StoredProcedure;

                    mySqlCmd.Parameters.AddWithValue("_ISBN", long.Parse(txtISBN.Text));
                    mySqlCmd.Parameters.AddWithValue("_Titulo", txtTitulo.Text.Trim());
                    mySqlCmd.Parameters.AddWithValue("_Author", txtAutor.Text.Trim());
                    mySqlCmd.Parameters.AddWithValue("_Editora", txtEditora.Text.Trim());

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

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            this.Hide();
            PesquisaLivros form2 = new PesquisaLivros();
            form2.ShowDialog();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvLivros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvLivros_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
