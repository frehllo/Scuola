using System;
using System.Collections.Generic;

namespace Scuola
{
    public class Scuola
    {
        public string Nome { get; private set; }

        public List<Classe> Classi { get; private set; }

        public List<Materia> Materie { get; private set; } = new List<Materia>();

        public List<Studente> Studenti { get; private set; };

        public Scuola (string n)
        {
            Nome = n;
            Classi = new List<Classe>();
        }
        public Classe CreateClasse (int anno, string sezione)
        {
            Classe c = new Classe(anno, sezione);
            Classi.Add(c);
            return c;
        }

        public Materia CreateMateria (string nome)
        {
            Materia m = new Materia(nome);
            Materie.Add(m);
            return m;
        }

        public Votazione TrovaVotoMassimo()
        {
            double max = -1;
            int indice = 0;
            for (int i = 0; i < Studenti.Count; i++)
            {
                Votazione Voto = Studenti[i].TrovaVotoMassimo();
                if (Voto.GetVotoDouble() > max)
                {
                    max = Voto.GetVotoDouble();
                    indice = i;
                }
            }
            return Studenti[indice].TrovaVotoMassimo();
        }

        public Votazione TrovaVotoMinimo()
        {
            double min = 11;
            int indice = 0;
            for (int i = 0; i < Studenti.Count; i++)
            {
                Votazione Voto = Studenti[i].TrovaVotoMassimo();
                if (Voto.GetVotoDouble() < min)
                {
                    min = Voto.GetVotoDouble();
                    indice = i;
                }
            }
            return Studenti[indice].TrovaVotoMinimo();
        }
    }
}
