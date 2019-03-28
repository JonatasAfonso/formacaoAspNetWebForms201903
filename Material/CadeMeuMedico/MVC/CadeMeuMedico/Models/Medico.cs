using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CadeMeuMedico.Models
{
    public class Medico
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }  //Por causa da Convenção de Configuração Não precisa do atributo KEY

        [Required]
        [MaxLength(255, ErrorMessage = "Nome muito grande")]
        [MinLength(5, ErrorMessage = "Nome muito pequeno")]
        public string Nome { get; set; }

        [Required]
        [MaxLength(255, ErrorMessage = "Email muito grande")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }


        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }

      
        public virtual Cidade Cidade { get; set; }
              
        public virtual Especialidade Especialidade { get; set; }
    }
}