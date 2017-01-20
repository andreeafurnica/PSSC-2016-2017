using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelStudent;

namespace Repository
{
    class StudentRepository : IRepository<ModelStudent.Student>
    {
        public IEnumerable<Student> List
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Add(Student entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Student entity)
        {
            throw new NotImplementedException();
        }

        public Student FindById(int Id)
        {
            throw new NotImplementedException();
        }

        public void Update(Student entity)
        {
            throw new NotImplementedException();
        }
    }
}
