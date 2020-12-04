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
    public partial class Form1 : Form
    {
        MySqlConnection connection = new MySqlConnection("server = localhost; port = 3307;" + "database=eventos; uid=root; pwd=root ");
        public Form1()
        {
            InitializeComponent();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void criarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Criar")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {
                GestãoEventos f2 = new GestãoEventos();
                f2.MdiParent = this;
                f2.Show();
            }
        }

        private void registoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Registo")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {
                Registo registo = new Registo();
                registo.MdiParent = this;
                registo.Show();
            }
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "VerClientes")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {
                VerClientes ver = new VerClientes();
                ver.MdiParent = this;
                ver.Show();
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Click(object sender, EventArgs e)
        {
        }

        private void registoLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void visualizarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "TipoEventosVis")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {
                TipoEventosVis visualiza = new TipoEventosVis();
                visualiza.MdiParent = this;
                visualiza.Show();
            }
        }

        private void apagarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "EventoTipoApaga")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {
                EventoTipoApaga apaga = new EventoTipoApaga();
                apaga.MdiParent = this;
                apaga.Show();
            }
        }

        private void criarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "VerClientes")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {
                VerClientes ver = new VerClientes();
                ver.MdiParent = this;
                ver.Show();
            }
        }

        private void apagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "GestãoCliente")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {
                GestãoCliente gerir = new GestãoCliente();
                gerir.MdiParent = this;
                gerir.Show();
            }
        }

        private void pesquisarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "PesquisaCliente")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {
                PesquisaCliente cliente = new PesquisaCliente();
                cliente.MdiParent = this;
                cliente.Show();
            }
        }

        private void pesquisarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "PesquisaEvento")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {
                PesquisaEvento evento = new PesquisaEvento();
                evento.MdiParent = this;
                evento.Show();
            }
        }

        private void loginToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Visualiza Clientes";
        }

        private void apagarToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Gerir Clientes";

        }

        private void pesquisarToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Pesquisar Clientes";
        }

        private void registoToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Registar Clientes";
        }

        private void criarToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Gerir Eventos";
        }

        private void pesquisarToolStripMenuItem1_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Pesquisar Eventos";

        }

        private void apagarToolStripMenuItem1_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Gerir Tipos de Eventos";

        }

        private void visualizarToolStripMenuItem1_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Visualizar Tipos de Eventos";

        }
    }
}
