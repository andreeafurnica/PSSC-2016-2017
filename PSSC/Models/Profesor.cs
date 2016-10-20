using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Profesor : Persoana
    {
        private float activitate;

        public Profesor(string nume, int an, disciplina d, float activitate)
            : base(nume, an, d)
        {

            this.activitate = activitate;
        }

        public float Activitate
        {
            get { return activitate; }
            set { activitate = value; }
        }

    }
}
