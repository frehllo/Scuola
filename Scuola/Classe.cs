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
    }
}
