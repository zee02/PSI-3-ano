using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ex2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                for (int i = 1; i < 11; i++)
                {
                    ddLista.Items.Add(i.ToString());
                }
            }
        }

        protected void ddLista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnTab_Click(object sender, EventArgs e)
        {
            //ListBox1.Items.Clear();

            int n = int.Parse(ddLista.Text);
            //int res = 0;
            //for (int i = 0; i < 11; i++)
            //{
            //    res = i * n;
            //    ListBox1.Items.Add(i.ToString() + " X " + n.ToString() + " = " + res.ToString());

            //    tblTabela.Rows[i].Cells[0].Text = n.ToString();
            //    tblTabela.Rows[i].Cells[4].Text = res.ToString();


            //}
            Table tabela = new Table();

            int res = 0;
            for(int i = 0; i <= 10; i++)
            {
                TableRow linha = new TableRow();
                TableCell coluna = new TableCell();
                coluna.Text = n.ToString() + " X " + i.ToString() + " = ";
                linha.Cells.Add(coluna);
                coluna = new TableCell();
                res = i * n;
                coluna.Text = res.ToString();
                linha.Cells.Add(coluna);
                tabela.Rows.Add(linha);

            }

            PlaceHolder1.Controls.Add(tabela);


        }
    }
}