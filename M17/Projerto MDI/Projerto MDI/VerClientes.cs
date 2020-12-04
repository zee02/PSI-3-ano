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
    public partial class VerClientes : Form
    {
        string connection = "server = localhost; port = 3307; database=eventos; uid=root; pwd=root ";

        public VerClientes()
        {
            InitializeComponent();
        }

        private void VerClientes_Load(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlcon = new MySqlConnection(connection))
            {
                mysqlcon.Open();

                MySqlDataAdapter sqlada = new MySqlDataAdapter("ClienteProcura", mysqlcon);

                sqlada.SelectCommand.CommandType = CommandType.StoredProcedure;


                DataTable dtblBook = new DataTable();

                sqlada.Fill(dtblBook);

                dgvClientes.DataSource = dtblBook;
            }
        }
    }
}
