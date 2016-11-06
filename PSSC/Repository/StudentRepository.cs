using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelStudent;

namespace Repository
{
    class StudentRepository : IRepository<ModelStudent.InformatiiStudent>
    {
        public IEnumerable<InformatiiStudent> List
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Add(InformatiiStudent entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(InformatiiStudent entity)
        {
            throw new NotImplementedException();
        }

        public InformatiiStudent FindById(int Id)
        {
            throw new NotImplementedException();
        }

        public void Update(InformatiiStudent entity)
        {
            throw new NotImplementedException();
        }
    }
}
