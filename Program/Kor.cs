using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sikidom
{
    internal class Kor : Sikidom
    {
        double sugar;
        public Kor(double sugar) : base("Kör")
        {
            this.sugar = sugar;
        }

        public override double Kerulet()
        {
            return Math.Round((2 * this.sugar) * Math.PI,2);
        }

        public override double Terulet()
        {
            return Math.Round((this.sugar * this.sugar) * Math.PI,2);
        }
    }
}