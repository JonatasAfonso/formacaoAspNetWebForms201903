using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CadeMeuMedico.AreaAdministrativa
{
    public partial class MasterAdm : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblData.Text = DateTime.Now.ToShortDateString();
        }
    }
}