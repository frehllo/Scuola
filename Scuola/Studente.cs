using System;
using System.Collections.Generic;
using System.Text;

namespace Scuola
{
    public class Studente
    {
        public string Nome { get; private set; }
        public string Cognome { get; private set; }

        public DateTime DataNascita {private get; set; }

        public List<Votazione> Voti { get; private set; } = new List<Votazione>();

        public List<Studente> Studenti { get; set; }

        public Studente (string nome, string cognome)
        {
            Nome = nome;
            Cognome = cognome;
        }

        private DateTime GetDataNascita(DateTime d)
        {
            DateTime DataNascita = d;
            return DataNascita;
        }

        public void AddVoto(Votazione v)
        {
            Voti.Add(v);
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
                    max = Voto.GetVotoDouble();
                    indice = i;
                }
            }
            return Studenti[indice].TrovaVotoMassimo();
        }
    }
}
