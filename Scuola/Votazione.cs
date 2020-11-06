using System;
using System.Collections.Generic;
using System.Text;

namespace Scuola
{
    internal class Votazione
    {
        public int Voto { get; private set; }
        public DateTime Data { get; set; }
        public Materia Materia { get; private set; }
        public List<Docente> Docenti { get; private set; }

        public Votazione(int v, Studente s, Materia m )
        {
            Voto = v;
            Materia = m;
            s.AddVoto(this);
            Data = DateTime.Now;
        }

        public double GetVotoDouble()
        {
            return Voto;
        }

        public bool isSufficiente()
        {
            if (Voto < 6)
            {
                return false;
            }
            else return true;
        }
    }
}
