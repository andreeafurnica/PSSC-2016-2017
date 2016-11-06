using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelDisciplina;

namespace Repository
{
    public class DisciplinaRepository : IRepository<ModelDisciplina.InformatiiDisciplina>
    {
        public IEnumerable<InformatiiDisciplina> List
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Add(InformatiiDisciplina entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(InformatiiDisciplina entity)
        {
            throw new NotImplementedException();
        }

        public InformatiiDisciplina FindById(int Id)
        {
            throw new NotImplementedException();
        }

        public void Update(InformatiiDisciplina entity)
        {
            throw new NotImplementedException();
        }
    }
}
