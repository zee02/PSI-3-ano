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

namespace Ex1____Storage_Precedures
{
    public partial class Form1 : Form
    {
        string connection = "server = localhost; port = 3307; database=bookdb; uid=root; pwd=root ";
        int bookID = 0;

        public Form1()
        {
            InitializeComponent();
        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnGuarda_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlcon = new MySqlConnection(connection))
            {
                mysqlcon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("BookAddOrEdit", mysqlcon);

                mySqlCmd.CommandType = CommandType.StoredProcedure;

                mySqlCmd.Parameters.AddWithValue("_BookID", bookID);
                mySqlCmd.Parameters.AddWithValue("_BookName", txtNomeLivro.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_Author", txtAutor.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_Description", txtDescricao.Text.Trim());

                mySqlCmd.ExecuteNonQuery();
                MessageBox.Show("Submetido com sucesso");

                Clear();
                GridFill();


            }
        }

        void GridFill()
        {
            using (MySqlConnection mysqlcon = new MySqlConnection(connection))
            {
                mysqlcon.Open();

                MySqlDataAdapter sqlada = new MySqlDataAdapter("BookViewAll", mysqlcon);

                sqlada.SelectCommand.CommandType = CommandType.StoredProcedure;


                DataTable dtblBook = new DataTable();

                sqlada.Fill(dtblBook);

                dgvInfo.DataSource = dtblBook;

                dgvInfo.Columns[0].Visible = false;

                  
                
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Clear();
            GridFill();
        }


        void Clear()
        {
            txtNomeLivro.Text = txtAutor.Text = txtDescricao.Text = txtSearch.Text = "";

            bookID = 0;

            btnGuarda.Text = "Save";

            btnApaga.Enabled = false;
        }

        private void dgvInfo_DoubleClick(object sender, EventArgs e)
        {
            if(dgvInfo.CurrentRow.Index != 1)
            {
                txtNomeLivro.Text = dgvInfo.CurrentRow.Cells[1].Value.ToString();
                txtAutor.Text = dgvInfo.CurrentRow.Cells[2].Value.ToString();
                txtDescricao.Text = dgvInfo.CurrentRow.Cells[3].Value.ToString();

                bookID = Convert.ToInt32(dgvInfo.CurrentRow.Cells[0].Value.ToString());


                btnGuarda.Text = "Update";
                btnApaga.Enabled = true;
            }
        }

        private void btnProcura_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlcon = new MySqlConnection(connection))
            {
                mysqlcon.Open();
                MySqlDataAdapter sqlAda = new MySqlDataAdapter("BookSearchbyValue", mysqlcon);
                sqlAda.SelectCommand.CommandType = CommandType.StoredProcedure;

                sqlAda.SelectCommand.Parameters.AddWithValue("_SearchValue", txtSearch.Text);


                DataTable dtblBook = new DataTable();

                sqlAda.Fill(dtblBook);

                dgvInfo.DataSource = dtblBook;

                dgvInfo.Columns[0].Visible = false;
            }
        }

        private void btnApaga_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlcon = new MySqlConnection(connection))
            {
                mysqlcon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("BookDeleteByID", mysqlcon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_BookID", bookID);
                mySqlCmd.ExecuteNonQuery();
                MessageBox.Show("Apagado com sucesso");
                Clear();
                GridFill();
            }
        }
    }
}