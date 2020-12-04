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
    public partial class Registo : Form
    {
        MySqlConnection connection = new MySqlConnection("server = localhost; port = 3307;" + "database=eventos; uid=root; pwd=root ");

 
        MySqlCommand comando;
        public Registo()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != "" && txtNIF.Text != "" && txtLocal.Text != "" && txtContacto.Text != "")
            {
             
                string che = @"(select count(*) from cliente where nif = '" + txtNIF.Text + "')";
                comando = new MySqlCommand("insert into cliente (nif, nome, contacto, localidade) values ('" + txtNIF.Text + "','" + txtNome.Text + "', '" + txtContacto.Text + "','" + txtLocal.Text + "')", connection);


            connection.Open();

            MySqlCommand com2 = new MySqlCommand(che, connection);
            double count = Convert.ToDouble(com2.ExecuteScalar());

            if (count > 0)
            {
                MessageBox.Show("Este utilizador já existe...");
                connection.Close();
            }

            else
            {
                comando.ExecuteNonQuery();
                MessageBox.Show("Registado com sucesso");
                txtNIF.Text = " ";
                txtLocal.Text = " ";
                txtContacto.Text = " ";
                txtNome.Text = " ";

                connection.Close();


            }
          }
                else
                {
                    MessageBox.Show("Deves inserir todos os campos!", "Aviso!", MessageBoxButtons.OK);
                }
}

        private void txtContacto_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtNIF_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNIF_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        

        }

        private void txtLocal_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
