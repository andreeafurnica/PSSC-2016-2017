using ModelGeneric;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelDisciplina
{
   public class Disciplina
    {
        public int IdDisciplina { get; internal set; }
        public PlainText NumeDisciplina { get; internal set; }


        internal Disciplina(int Id, PlainText Nume)
        {
            IdDisciplina = Id;
            NumeDisciplina = Nume;
        }
    }
}
