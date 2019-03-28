using CadeMeuMedico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CadeMeuMedico.AreaAdministrativa
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var especialidades = new List<Especialidade>();
                if (Session["Especialidades"] != null)
                {
                    especialidades = (List<Especialidade>)Session["Especialidades"];
                }

                foreach (var item in especialidades)
                {
                    ddlEspecialidades.Items.Add(new ListItem(item.Nome, item.Descricao));
                }
            }
        }

        protected void btnGravar_Click(object sender, EventArgs e)
        {

        }

        protected void ddlEspecialidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblEspecialidade.Text = ddlEspecialidades.SelectedItem.Value;
        }
    }
}