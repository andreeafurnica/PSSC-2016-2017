using ModelDisciplina;
using ModelGeneric;
using ModelNota;
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
        public Disciplina Disciplina { get; internal set; }
        public Nota Nota { get; internal set; }
        internal InformatiiStudent(Nota N, Disciplina Discip)
        {
            Nota = N;
            Disciplina = Discip;
        }

    }
}
