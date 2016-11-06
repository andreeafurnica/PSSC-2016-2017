using ModelGeneric;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelStudent
{
    public class InformatiiStudent
    {
        public Guid IdStudent { get; internal set; }
        public NumarMatricol NumarMatricol {get; internal set;}
        public PlainText NumeStudent { get; internal set; }
        internal InformatiiStudent(NumarMatricol NrMatricol, PlainText Nume)
        {
            Contract.Requires(NrMatricol != null, "numar matricol");
            Contract.Requires(Nume != null, "nume");
            NumarMatricol = NrMatricol;
            NumeStudent = Nume;
        }

    }
}
