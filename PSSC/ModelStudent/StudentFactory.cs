using ModelGeneric;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelGeneric.Exception;
namespace ModelStudent
{
    public class StudentFactory
    {
        public static readonly StudentFactory Instance = new StudentFactory();
       
        

        private StudentFactory()
        {
            List<Student>ListaStudenti = new List<Student>();
        }

        public Student CreeazaStudent(string NrMatricol, string Nume )
        {
            Contract.Requires<ArgumentNullException>(NrMatricol != null, "text");
            
            Contract.Requires<ArgumentInvalidLengthException>(
                    Nume.Length >= 2 && Nume.Length <= 50,
                   "Numele studentului trebuie sa contina intre 2 si 50 de caractere.");

            Contract.Requires<ArgumentNullException>(Nume != null, "text");
            Contract.Requires<ArgumentInvalidLengthException>(
                     NrMatricol.Length >= 2 && NrMatricol.Length <= 50,
                    "Numarul Matricol al studentului trebuie sa contina 4 caractere.");

            var student = new Student(
                                        new NumarMatricol(NrMatricol),
                                        new PlainText(Nume));

            return student;
        }
    }
}
