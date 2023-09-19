using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sikidom
{
    internal class Teglalap : Sikidom
    {
        double aoldal;
        double boldal;
        public Teglalap(double aoldal, double boldal) : base("Téglalap")
        {
            this.aoldal = aoldal;
            this.boldal = boldal;
        }

        public override double Kerulet()
        {
            return (aoldal + boldal) * 2;
        }

        public override double Terulet()
        {
            return (aoldal * boldal);
        }
    }
}