using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelProfesor;

namespace Repository
{
    class ProfesorRepository: IRepository<ModelProfesor.Profesor>
    {
        public IEnumerable<Profesor> List
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Add(Profesor entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Profesor entity)
        {
            throw new NotImplementedException();
        }

        public Profesor FindById(int Id)
        {
            throw new NotImplementedException();
        }

        public void Update(Profesor entity)
        {
            throw new NotImplementedException();
        }

  
    }
}
