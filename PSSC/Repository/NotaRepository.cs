using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelNota;

namespace Repository
{
    class NotaRepository : IRepository<ModelNota.Nota>
    {
        public IEnumerable<Nota> List
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Add(Nota entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Nota entity)
        {
            throw new NotImplementedException();
        }

        public Nota FindById(int Id)
        {
            throw new NotImplementedException();
        }

        public void Update(Nota entity)
        {
            throw new NotImplementedException();
        }
    }
}
