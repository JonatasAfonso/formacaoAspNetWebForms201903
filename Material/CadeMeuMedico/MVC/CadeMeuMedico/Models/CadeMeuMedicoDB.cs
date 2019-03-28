using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CadeMeuMedico.Models
{
    public class CadeMeuMedicoDB : DbContext
    {
        public CadeMeuMedicoDB() : base("name=MedicosDB")
        {  }

        
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<Especialidade> Especialidades { get; set; }
    } 
}