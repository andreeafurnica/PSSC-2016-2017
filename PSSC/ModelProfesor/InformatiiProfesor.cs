using ModelDisciplina;
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
        public Disciplina Disciplina { get; internal set; }
        public Profesor Profesor { get; internal set; }
        internal InformatiiProfesor(Profesor Prof, Disciplina Discip)
        {
            Profesor = Prof;
            Disciplina = Discip;
        }
    }
}
