using System;
using System.Collections.Generic;
using System.Text;

namespace Scuola
{
    public class Materia
    {
        public string Nome { get; private set; }

        public Materia(string n)
        {
            Nome = n;
        }
    }
}
