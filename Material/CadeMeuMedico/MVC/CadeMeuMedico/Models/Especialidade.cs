using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CadeMeuMedico.Models
{
    public class Especialidade
    {
        public int Id { get; set; }

        [DisplayName("Nome da Especialidade")]
        [MaxLength(60, ErrorMessage = "Nome muito grande")]
        [Required]
        public string Nome { get; set; }

        [DisplayName("Descrição da Especialidade")]
        [MaxLength(255, ErrorMessage = "Descrição muito grande")]
        public string Descricao { get; set; }


        public virtual List<Medico> Medicos { get; set; }
    }
}