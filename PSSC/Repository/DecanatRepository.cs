using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelDecanat;

namespace Repository
{
    public class DecanatRepository : IRepository<ModelDecanat.SituatieAnDeStudiu>
    {
        public IEnumerable<SituatieAnDeStudiu> List
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Add(SituatieAnDeStudiu entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(SituatieAnDeStudiu entity)
        {
            throw new NotImplementedException();
        }

        public SituatieAnDeStudiu FindById(int Id)
        {
            throw new NotImplementedException();
        }

        public void Update(SituatieAnDeStudiu entity)
        {
            throw new NotImplementedException();
        }
    }
}
