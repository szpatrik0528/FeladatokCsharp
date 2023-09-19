using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sikidom
{
    abstract class Sikidom
    {
        public string Nev;

        public Sikidom(string nev)
        {
            Nev = nev;
        }

        abstract public double Terulet();
        abstract public double Kerulet();

        public override string ToString()
        {
            return Nev;
        }
    }
}