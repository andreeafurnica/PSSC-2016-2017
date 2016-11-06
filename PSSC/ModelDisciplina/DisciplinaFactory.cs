using ModelGeneric;
using ModelGeneric.Exception;
using ModelStudent;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ModelDisciplina
{
    public class DisciplinaFactory
    {
        public static readonly DisciplinaFactory Instance = new DisciplinaFactory();
        

        private DisciplinaFactory()
        {

        }

        public InformatiiDisciplina CreeazaDisciplina(int Id, string nume, int NrCredite)
        {
            Contract.Requires<ArgumentNullException>(nume != null, "text");
            Contract.Requires<ArgumentInvalidLengthException>(
                    nume.Length >= 2 && nume.Length <= 50,
                    "Numele disciplinei trebuie sa contina intre 2 si 50 de caractere.");

            var disciplina = new InformatiiDisciplina(Id,
                                        new PlainText(nume),
                                        NrCredite);

            return disciplina;
        }
    }
}
