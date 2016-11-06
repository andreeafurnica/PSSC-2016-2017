using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelNota;

namespace Repository
{
    class NotaRepository : IRepository<ModelNota.InformatiiNota>
    {
        public IEnumerable<InformatiiNota> List
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Add(InformatiiNota entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(InformatiiNota entity)
        {
            throw new NotImplementedException();
        }

        public InformatiiNota FindById(int Id)
        {
            throw new NotImplementedException();
        }

        public void Update(InformatiiNota entity)
        {
            throw new NotImplementedException();
        }
    }
}
