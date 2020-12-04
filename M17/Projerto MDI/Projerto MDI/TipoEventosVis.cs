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
    public partial class TipoEventosVis : Form
    {
        string connection = "server = localhost; port = 3307; database=eventos; uid=root; pwd=root ";
        public TipoEventosVis()
        {
            InitializeComponent();
        }

        private void TipoEventosVis_Load(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlcon = new MySqlConnection(connection))
            {
                mysqlcon.Open();

                MySqlDataAdapter sqlada = new MySqlDataAdapter("EventoProcura", mysqlcon);

                sqlada.SelectCommand.CommandType = CommandType.StoredProcedure;


                DataTable dtblBook = new DataTable();

                sqlada.Fill(dtblBook);

                dgvTipEventos.DataSource = dtblBook;
            }
        }

        private void dgvTipEventos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
