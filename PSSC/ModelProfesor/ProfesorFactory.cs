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
            List<Profesor> ListaProfesori = new List<Profesor>();
        }

        public Profesor CreeazaProfesor(int Id, string nume)
        {
            Contract.Requires<ArgumentNullException>(nume != null, "text");
            Contract.Requires<ArgumentInvalidLengthException>(
                     nume.Length >= 2 && nume.Length <= 50,
                    "Numele profesorului trebuie sa contina intre 2 si 50 de caractere.");

            var profesor = new Profesor(
                                        Id,
                                        new PlainText(nume));

            return profesor;
        }
    }
}
