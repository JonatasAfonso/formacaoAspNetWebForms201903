using System.Data.Entity;

namespace CadeMeuMedico.Models
{
    public class CadeMeuMedicoDB : DbContext
    {
        public CadeMeuMedicoDB() : base("name=MedicosDB")
        {  }
                
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<Especialidade> Especialidades { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<DicionarioHash> DicionarioHash { get; set; }        
    } 
}
