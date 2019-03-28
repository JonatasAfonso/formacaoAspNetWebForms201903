using System.Collections.Generic;

namespace CadeMeuMedico.Models
{
    public class Cidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public virtual List<Medico> Medicos { get; set; }
    }
}