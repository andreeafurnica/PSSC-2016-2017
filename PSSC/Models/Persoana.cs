using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public enum disciplina { distribuita, examen };
    class Persoana
    {
        private string nume;
        private int an;
        private disciplina disciplina;
        public Persoana(string nume, int an, disciplina d)
        {
            this.nume = nume;
            this.an = an;
            this.disciplina = d;
        }

        public string Nume
        {
            get { return nume; }
            set { nume = value; }
        }

        public int An
        {
            get { return an; }
            set { an = value; }
        }

        public disciplina Disciplina
        {
            get { return disciplina; }
            set { disciplina = value; }
        }

    }
}
