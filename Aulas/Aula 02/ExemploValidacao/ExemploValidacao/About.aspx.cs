using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExemploValidacao
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Nome = txtNome.Text;


        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            string telefone = txtTelefoneTeste.Text.Trim();

            if (telefone.StartsWith("+351"))
            {
                if(telefone.Length == 13)
                {
                    CustomValidator1.IsValid = true;
                }
            }

            CustomValidator1.IsValid = false;
            CustomValidator1.Text = "falha";
        }
    }
}