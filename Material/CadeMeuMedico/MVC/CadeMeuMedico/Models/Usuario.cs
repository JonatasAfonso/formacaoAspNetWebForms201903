using System.ComponentModel.DataAnnotations;

namespace CadeMeuMedico.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [Compare("Email", ErrorMessage = "Confirmação diferente do email")]
        [DataType(DataType.EmailAddress)]
        public string ConfirmacaoEmail { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [MaxLength(50)]
        public string Senha
        {
            get { return "senha"; }
            set
            {
                Senha = Criptografia.CalculateMD5Hash(Senha);
            }
        }
    }
}