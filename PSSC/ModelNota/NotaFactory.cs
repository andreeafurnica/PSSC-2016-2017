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

        }

        public InformatiiNota CreeazaNota(decimal Actvitate, decimal Examen)
        {
            

            var nota = new InformatiiNota(
                                        new Nota(Actvitate),
                                        new Nota(Examen));

            return nota;
        }
    }

}

