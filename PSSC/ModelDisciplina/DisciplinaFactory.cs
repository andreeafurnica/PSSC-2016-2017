using ModelGeneric;
using ModelGeneric.Exception;
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
            List<Disciplina> ListaDiscipline = new List<Disciplina>();
        }
    
        public Disciplina CreeazaDisciplina(int Id, string nume)
        {
            Contract.Requires<ArgumentNullException>(nume != null, "text");
            Contract.Requires<ArgumentInvalidLengthException>(
                    nume.Length >= 2 && nume.Length <= 50,
                    "Numele disciplinei trebuie sa contina intre 2 si 50 de caractere.");

            var disciplina = new Disciplina(Id,
                                        new PlainText(nume));

            return disciplina;
        }
    }
}
