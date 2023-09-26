using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testek
{
    internal class Kocka : Testek
    {
        double oldal;

        public Kocka(double oldal) : base("Kocka")
        {
            this.oldal = oldal;
        }

        public double Oldal { get => Oldal; }

        public override double Felszin()
        {
            return 6 * Math.Pow(oldal,2);
        }

        public override double Terfogat()
        {
            return Math.Pow(oldal, 3);
        }
    }
}
