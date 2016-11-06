using ModelGeneric;
using ModelProfesor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelDisciplina
{
    public class InformatiiDisciplina
    {
        public int IdDisciplina { get; internal set; }
        public  PlainText NumeDisciplina { get; internal set; }
        public int NumarCredite { get; internal set; }
        public InformatiiProfesor Profesor { get; internal set; }

    internal InformatiiDisciplina(int Id, PlainText Nume, int NrCredite)
        {
            IdDisciplina = Id;
            NumeDisciplina = Nume;
            NumarCredite = NrCredite;
        }
    internal InformatiiDisciplina(InformatiiProfesor Prof)
        {
            Profesor = Prof; 
        }



    }
}
