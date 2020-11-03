using System;
using System.Collections.Generic;
using System.Text;

namespace Scuola
{
    public class Classe
    {
        public int Anno { get; set; }
        public string Sezione { get; set; }

        public List<Studente> Studenti { get; private set; }

        public Classe(int a, string sezione)
        {
            Anno = a;
            this.Sezione = sezione;
        }

        public string GetNome()
        {
            string Nome = $"{Anno}{Sezione}";
            return Nome;
        }

        public void AddStudente(Studente s)
        {
            Studenti.Add(s);
        }

        public Votazione TrovaVotoMassimo()
        {
            double max = -1;
            int indice = 0;
            for(int i = 0; i < Studenti.Count; i++)
            {
                Votazione Voto = Studenti[i].TrovaVotoMassimo();
                if(Voto.GetVotoDouble() > max)
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
