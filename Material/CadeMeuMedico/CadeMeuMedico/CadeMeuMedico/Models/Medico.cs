using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CadeMeuMedico.Models
{
    public class Medico
    {
        public int IDMedico { get; set; }
        public int CedulaProfissional { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Email { get; set; }
        public bool AtendePorConvencao { get; set; }
        public bool TemClinica { get; set; }
        public string WebsiteBlog { get; set; }
        public int IDCidade { get; set; }
        public int IDEspecialidade { get; set; }
    }
}