using ModelGeneric;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelProfesor
{
    public class InformatiiProfesor
    {
        public int IdProfesor { get; internal set; }
        public PlainText NumeProfesor{ get; internal set; }

        internal InformatiiProfesor(int Id, PlainText Nume)
        { 
            Contract.Requires(Nume != null, "nume");
            IdProfesor = Id;
            NumeProfesor = Nume;
        }
    }
}
