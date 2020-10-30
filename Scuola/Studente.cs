using System;
using System.Collections.Generic;
using System.Text;

namespace Scuola
{
    public class Studente
    {
        public string Nome { get; private set; }
        public string Cognome { get; private set; }

        public DateTime DataNascita;

        public List<Votazione> Voti { get; private set; }

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
    }
}
