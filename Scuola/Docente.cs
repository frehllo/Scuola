using System;
using System.Collections.Generic;
using System.Text;

namespace Scuola
{
    internal class Docente
    {
        public string Nome { get; private set; }
        public string Cognome { get; private set; }
        public Materia Materia { get; private set; }
        public Votazione Voto { get; private set; }

        public Docente(string n, string c, Materia m)
        {
            Nome = n;
            Cognome = c;
            Materia = m;
        }

        public Votazione AssegnaVoto (Votazione v, Studente s)
        {
            Voto = v;
            s.AddVoto(Voto);
            return Voto;
        }

    }
}
