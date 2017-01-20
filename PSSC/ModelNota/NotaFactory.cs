using ModelGeneric;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelNota
{
   public class NotaFactory
    {
        public static readonly NotaFactory Instance = new NotaFactory();
        private List<InformatiiNota> _listaNote;
        public ReadOnlyCollection<InformatiiNota> ListaNote { get { return _listaNote.AsReadOnly(); } }

        private NotaFactory()
        {
            List<Nota> ListaNote = new List<Nota>();
        }

        public Nota CreeazaNotaExamen(Note Activitate, Note Examen)
        {

            var nota = new Nota(
                                Activitate,
                                Examen);

            return nota;
        }
        public Nota CreeazaNotaDistribuita(Note Activitate, Note D1, Note D2)
        {

            var nota = new Nota(
                                Activitate,
                                D1,
                                D2);

            return nota;
        }

    }

}

