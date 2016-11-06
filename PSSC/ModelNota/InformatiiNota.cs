using ModelGeneric;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelNota
{
   public class InformatiiNota
    {
       
        public Coeficient PondereExamen { get; internal set; }
        public Nota NotaActivitate{ get; internal set; }
        public Nota NotaExamen { get; internal set; }
        public Nota NotaFinala { get; internal set; }

        internal InformatiiNota(Nota Activitate, Nota Examen)
        {
            NotaActivitate = Activitate;
            NotaExamen = Examen;

        }
        public void CalculeazaNotaFinala(Coeficient PondereExamen)
        {
           
        }
    }
}
