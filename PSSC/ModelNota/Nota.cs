using ModelGeneric;
using System;

namespace ModelNota
{
    public class Nota
    {
        private decimal actvitate;

        public Note NotaActivitate { get; internal set; }
        public Note NotaExamen { get; internal set; }
        public Note NotaDistribuita1 { get; internal set; }
        public Note NotaDistribuita2 { get; internal set; }

        internal Nota(Note Activitate, Note Examen)
        {
            NotaActivitate = Activitate;
            NotaExamen = Examen;

        }

        internal Nota(Note Activitate, Note D1, Note D2)
        {
            NotaActivitate = Activitate;
            NotaDistribuita1 = D1;
            NotaDistribuita2 = D2;
        }

        public Nota(decimal actvitate)
        {
            this.actvitate = actvitate;
        }

        public void CalculeazaNotaFinala(Coeficient PondereExamen)
        {

        }

       
    }
}