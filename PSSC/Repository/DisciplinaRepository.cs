using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelDisciplina;

namespace Repository
{
    public class DisciplinaRepository : IRepository<ModelDisciplina.Disciplina>
    {
        public IEnumerable<Disciplina> List
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Add(Disciplina entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Disciplina entity)
        {
            throw new NotImplementedException();
        }

        public Disciplina FindById(int Id)
        {
            throw new NotImplementedException();
        }

        public void Update(Disciplina entity)
        {
            throw new NotImplementedException();
        }
    }
}
