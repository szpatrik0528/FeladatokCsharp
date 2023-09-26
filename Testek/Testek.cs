using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testek
{
    abstract class Testek
    {
        public string tipus;

        protected Testek(string tipus)
        {
            this.tipus = tipus;
        }

        abstract public double Terfogat();
        abstract public double Felszin();

        public override string ToString()
        {
            return tipus;
        }
    }
}
