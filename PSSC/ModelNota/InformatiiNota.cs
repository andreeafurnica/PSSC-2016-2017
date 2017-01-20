using ModelGeneric;

namespace ModelNota
{
    public class InformatiiNota
    {
        public Coeficient PondereExamen { get; internal set; }
        public Coeficient PondereDistribuita { get; internal set; }
        public Nota Nota { get; internal set; }
        public Note NotaFinala { get; internal set; }

        internal InformatiiNota(Nota N, Note NotaF)
        {
            Nota = N;
            NotaFinala = NotaF;
        }

        public void CalculeazaNotaFinalaExamen(Coeficient PondereExamen)
        {

        }
        public void CalculeazaNotaFinalaDistribuita(Coeficient PondereDistrbuita)
        {

        }
    }
}