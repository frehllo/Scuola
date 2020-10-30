using System;
using System.Collections.Generic;
using System.Text;

namespace Scuola
{
    public class Votazione
    {
        public int Voto { get; set; }
        public DateTime Data { get; set; }
        public Materia Materia { get; private set; }
        public Votazione(int v, DateTime d )
        {
            Voto = v;
            Data = d;
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
