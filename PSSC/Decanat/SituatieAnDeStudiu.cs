using ModelDisciplina;
using ModelProfesor;
using ModelStudent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelDecanat
{
    public class SituatieAnDeStudiu
    {
        public int AnDeStudiu;
        private List<InformatiiDisciplina> ListaDiscipline;
        private List<InformatiiStudent> ListaStudenti;
        private List<InformatiiProfesor> ListaProfesori;
        internal SituatieAnDeStudiu(int An)
        {
            AnDeStudiu = An;
        }
    }
}
