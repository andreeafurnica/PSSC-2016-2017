using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Student : Persoana
    {
        private int grupa;
        private float nota;
        private float media;

        public Student(string nume, int an, disciplina d, int grupa, float nota, float media)
        : base(nume, an, d)
        {
            this.grupa = grupa;
        }

        public int Grupa
        {
            get { return grupa; }
            set { grupa = value; }
        }
        public float Nota
        {
            get { return nota; }
            set { nota = value; }
        }

        public float Media
        {
            get { return media; }
            set { media = value; }
        }
    }
}
