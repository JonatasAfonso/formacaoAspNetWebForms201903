namespace CadeMeuMedico.Models
{
    public class DicionarioHash
    {
        public int Id { get; set; }
        public string SenhaEmAberto { get; set; }
        public string HashCriptografado { get; set; }
    }
}