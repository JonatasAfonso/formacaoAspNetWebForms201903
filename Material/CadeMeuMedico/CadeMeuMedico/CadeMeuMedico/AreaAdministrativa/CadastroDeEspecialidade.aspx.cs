using CadeMeuMedico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CadeMeuMedico.AreaAdministrativa
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGravar_Click(object sender, EventArgs e)
        {
            var especialidades = new List<Especialidade>();
            if (Session["Especialidades"] != null)
            {
                especialidades = (List<Especialidade>)Session["Especialidades"];
            }
            
            var novaEspecialidade = new Especialidade();
            novaEspecialidade.Nome = txtNome.Text;
            novaEspecialidade.Descricao = txtDescricao.Text;

            especialidades.Add(novaEspecialidade);
            Session["Especialidades"] = especialidades;


            LimparCampos();
        }

        private void LimparCampos()
        {
            txtNome.Text = string.Empty;
            txtDescricao.Text = string.Empty;
        }
    }
}