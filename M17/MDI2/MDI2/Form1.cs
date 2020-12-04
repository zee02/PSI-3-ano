using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void abrirAtravésDeUmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach(Form f in Application.OpenForms)
            {
                if(f.Text == "Form2")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if(IsOpen == false)
            {
                Form2 f2 = new Form2();
                f2.MdiParent = this;
                f2.Show();
            }
        }

        private void abrirFormMuitasVezesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.MdiParent = this;
            f3.Show();
        }

        private void fecharTodosOsFormsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(Form frm in this.MdiChildren)
            {
                if(!frm.Focused)
                {
                    frm.Visible = false;
                    frm.Dispose();
                }
            }
        }
    }
}
