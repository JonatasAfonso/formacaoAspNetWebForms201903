using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExemploControleNavegacao
{
    public partial class PaginaConsulta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = (string)Session["minhaSessao"];
        }

        protected void btnBuscaQueryString_Click(object sender, EventArgs e)
        {
            Response.Redirect("about.aspx?Nome=" + txtNome.Text +
                "&Endereco=" + txtEndereco.Text);
        }
    }
}