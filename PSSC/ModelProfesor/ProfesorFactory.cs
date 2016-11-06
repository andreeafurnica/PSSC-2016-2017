using ModelGeneric;
using ModelGeneric.Exception;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelProfesor
{
    public class ProfesorFactory
    {
        public static readonly ProfesorFactory Instance = new ProfesorFactory();
        
        

        private ProfesorFactory()
        {

        }

        public InformatiiProfesor CreeazaProfesor(int Id, string Nume)
        {
            Contract.Requires<ArgumentNullException>(Nume != null, "text");
            Contract.Requires<ArgumentInvalidLengthException>(
                     Nume.Length >= 2 && Nume.Length <= 50,
                    "Numele profesorului trebuie sa contina intre 2 si 50 de caractere.");

            var profesor = new InformatiiProfesor(
                                        Id,
                                        new PlainText(Nume));

            return profesor;
        }
    }
}
