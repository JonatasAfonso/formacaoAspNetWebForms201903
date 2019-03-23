using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Resources;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Threading;
using System.Reflection;

namespace ExemploControleNavegacao
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ResourceManager rm = new ResourceManager("ExemploControleNavegacao.Languages", Assembly.GetExecutingAssembly());
                lblNomePorTraduzir.Text = rm.GetString("lblNome");
            }
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            string[] cultureNames = { "en", "fr", "pt" };

            foreach (var cultureName in cultureNames)
            {
                ResourceManager rm = new ResourceManager("ExemploControleNavegacao.Languages", Assembly.GetExecutingAssembly());

                CultureInfo culture = CultureInfo.CreateSpecificCulture(cultureName);
                Thread.CurrentThread.CurrentCulture = culture;
                Thread.CurrentThread.CurrentUICulture = culture;

                Console.WriteLine("Current UI Culture: {0}", CultureInfo.CurrentUICulture.Name);
                string exemplo = rm.GetString("lblNome");

                lblExemplo.Text += "  " + exemplo + "  " + cultureName;
            }
        }
    }
}