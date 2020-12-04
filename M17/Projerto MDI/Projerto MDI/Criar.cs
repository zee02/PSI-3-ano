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
    public partial class GestãoEventos : Form
    {
        string connections = "server = localhost; port = 3307; database=eventos; uid=root; pwd=root ";

        public GestãoEventos()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            int evento;

            using (var connection = new MySqlConnection(connections))
            {
                using (var command = connection.CreateCommand())
                {

                    {
                        
                        command.CommandText = "select idtipoeventos from tipoeventos where idtipoeventos = '" + txtEvento.Text + "'";


                        connection.Open();
                        string che = @"(select count(*) from cliente where nif = '" + txtNIF.Text + "')";


                        MySqlCommand com2 = new MySqlCommand(che, connection);
                        double count = Convert.ToDouble(com2.ExecuteScalar());

                        using (MySqlDataReader r = command.ExecuteReader())
                        {
                            while (r.Read())
                            {
                                evento = r.GetInt32(0);

                            }

                            if (r.HasRows)

                            {
                                if (count > 0)
                                {
                                    connection.Close();
                                    string dtpDate = dataPicker.Value.Date.ToString("yyyy-MM-dd HH:mm");

                                    if (txtEvento.Text != "" && txtHora.Text != "" && txtNIF.Text != "")
                                    {


                                        command.CommandText = "INSERT INTO eventos(nif,idtipevento,data,hora) VALUES (?nif,?idtipevento,?data,?hora)";
                                        command.Parameters.AddWithValue("?nif", txtNIF.Text);
                                        command.Parameters.AddWithValue("?idtipevento", txtEvento.Text);
                                        command.Parameters.AddWithValue("?data", dtpDate);
                                        command.Parameters.AddWithValue("?hora", txtHora.Text.ToString());

                                        connection.Open();
                                        command.ExecuteNonQuery();
                                        MessageBox.Show("Submetido com sucesso");

                                    }
                                    else
                                        MessageBox.Show("Deves inserir todos os campos!", "Aviso!", MessageBoxButtons.OK);
                                }
                                else
                                    MessageBox.Show("Verifica se o teu NIF é válido!", "Aviso!", MessageBoxButtons.OK);
                            }

                            else
                                MessageBox.Show("Deves inserir um código de evento correto!", "Aviso!", MessageBoxButtons.OK);


                        }

                    }


                }
            }

        
        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            txtNIF.Text = " ";
            txtHora.Text = " ";
            txtNIF.Text = " ";
        }

       
        private void Criar_Load(object sender, EventArgs e)
        {

        }
        private void preenche()
        {
            using (MySqlConnection mysqlcon = new MySqlConnection(connections))
            {
                mysqlcon.Open();

                MySqlDataAdapter sqlada = new MySqlDataAdapter("EventosProcura", mysqlcon);

                sqlada.SelectCommand.CommandType = CommandType.StoredProcedure;


                DataTable dtblBook = new DataTable();

                sqlada.Fill(dtblBook);

                dgvEvento.DataSource = dtblBook;

                dgvVisua.DataSource = dtblBook;
            }
        }

  
        

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabEliminar)
            {
                preenche();
            }

            if (tabControl1.SelectedTab == tabVisualiza)
            {
                preenche();
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {

        }

        private void btnApagar_Click_1(object sender, EventArgs e)
        {


            using (var connection = new MySqlConnection(connections))
            {
                using (var command = connection.CreateCommand())
                {

                    if (dgvEvento.Rows != null && dgvEvento.Rows.Count > 1)
                    {
                        
                            MySqlCommand delcmd = new MySqlCommand();
                            if (dgvEvento.Rows.Count > 0)
                            {
                                delcmd.CommandText = "DELETE FROM eventos WHERE nif=" + dgvEvento.CurrentRow.Cells[1].Value.ToString() + "";
                                connection.Open();
                                delcmd.Connection = connection;
                                delcmd.ExecuteNonQuery();
                                connection.Close();
                                dgvEvento.Rows.RemoveAt(dgvEvento.CurrentRow.Index);
                                MessageBox.Show("Evento eliminado com sucesso!", "Aviso!", MessageBoxButtons.OK);
                            }
                    }
                    else
                        MessageBox.Show("Deves inserir um evento!");

                    

                }
            }
        }

        private void dgvEvento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
      
        }

        private void txtNIF_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNIF_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void txtEvento_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void txtHora_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
