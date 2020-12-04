using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoMDI
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void mnuAbrirFilho1_Click(object sender, EventArgs e)
        {
            FormFilho1 form1 = new FormFilho1();
            form1.MdiParent = this;
            form1.Show();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void mnuAbrirFilho2_Click(object sender, EventArgs e)
        {
            FormFilho2 form2 = new FormFilho2();
            form2.MdiParent = this;
            form2.Show();
        }

        private void mnuAbrirFilho3_Click(object sender, EventArgs e)
        {
            FormFilho3 form3 = new FormFilho3();
            form3.MdiParent = this;
            form3.Show();
        }

        private void formsAbertosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mnuCascata_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void mnuHorizontal_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void mnuVertical_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void mnuIconesMin_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.ArrangeIcons);
        }
    }
}
