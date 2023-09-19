using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sikidom
{
    internal class Negyzet : Sikidom
    {
        double aoldal;
        public Negyzet(double aoldal) : base("Négyzet")
        {
            this.aoldal = aoldal;
        }

        public override double Kerulet()
        {
            return (4 * this.aoldal);
        }

        public override double Terulet()
        {
            return (this.aoldal * this.aoldal);
        }
    }
}