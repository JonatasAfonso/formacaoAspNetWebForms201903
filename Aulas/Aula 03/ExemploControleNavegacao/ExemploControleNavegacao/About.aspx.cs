using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExemploControleNavegacao
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string nomeCarregado = Request.QueryString["Nome"];
            string enderecoCarregado = Request.QueryString["Endereco"];


            lblNomeCarregado.Text = nomeCarregado;
            lblEnderecoCarregado.Text = enderecoCarregado;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string meuValor = TextBox1.Text;
            //só eu tenho acesso
            Session["minhaSessao"] = meuValor;
            Label1.Text = (string)Session["minhaSessao"];



            //qualquer um usando meu site tem acesso
            if (Application["contador"] == null)
                Application["contador"] = 0;

            int contadorValorNovo = (int)Application["contador"] + 1;
            Application["contador"] = contadorValorNovo;

            lblContadorClicks.Text = ((int)Application["contador"]).ToString();
        }
    }
}