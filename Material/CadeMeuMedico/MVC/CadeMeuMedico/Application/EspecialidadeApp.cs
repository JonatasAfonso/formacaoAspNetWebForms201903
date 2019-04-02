using CadeMeuMedico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CadeMeuMedico.Application
{
    public class EspecialidadeApp
    {
        public List<Especialidade> Get()
        {
            var db = new CadeMeuMedicoDB();
            var especialidades = db.Especialidades.ToList();

            return especialidades;
        }


        public Especialidade Get(int id)
        {
            var db = new CadeMeuMedicoDB();
            var especialidade = db.Especialidades.FirstOrDefault(x => x.Id == id);

            return especialidade;
        } 

        public void Create(Especialidade especialidade)
        {
            var db = new CadeMeuMedicoDB();
            db.Especialidades.Add(especialidade);
            db.SaveChanges();
        }

        public void Update(int id, Especialidade especialidade)
        {
            var db = new CadeMeuMedicoDB();

            var especialidadeNew = db.Especialidades.FirstOrDefault(x => x.Id == id);
            especialidadeNew.Nome = especialidade.Nome;
            especialidadeNew.Descricao = especialidade.Descricao;
       
            db.SaveChanges();
        }


        public void Delete(int id)
        {
            var db = new CadeMeuMedicoDB();

            var especialidade = db.Especialidades.FirstOrDefault(x => x.Id == id);
            db.Especialidades.Remove(especialidade);
            db.SaveChanges();
        }
    }
}