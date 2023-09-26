using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testek
{
    internal class Henger : Testek
    {
        double sugar;
        double magassag;
        public Henger(double sugar, double magassag) : base("Henger")
        {
            this.sugar = sugar;
            this.magassag = magassag;
        }

        public double Sugar { get => sugar; }
        public double Magassag { get => magassag; }

        public override double Felszin()
        {
            return (2 * Math.Pow(sugar,2) * Math.PI) + 2 * Sugar * Math.PI * Magassag;
        }

        public override double Terfogat()
        {
            return Math.Pow(sugar,2) * Math.PI * Magassag;
        }
    }
}
