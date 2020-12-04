using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ex1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed3_Click(object sender, EventArgs e)
        {
            if (txtMsg.Text != "")
            {
                lblNome.Text = "<h1>Bem vindo/a " + txtMsg.Text + "</h1>";

            }
            else
            {
                lblNome.Text = "<h1>Primeiro escreva o seu nome.</h1>";
            }
        }
    }
}