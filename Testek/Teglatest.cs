using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testek
{
    internal class Teglatest : Testek
    {
        double aoldal;
        double boldal;
        double coldal;
        public Teglatest(double aoldal, double boldal, double coldal) : base("Téglatest")
        {
            this.aoldal = aoldal;
            this.boldal = boldal;
            this.coldal = coldal;
        }

        public double Aoldal { get => aoldal; }
        public double Boldal { get => boldal; }
        public double Coldal { get => coldal; }

        public override double Felszin()
        {
            return 2*(Aoldal*Boldal + Aoldal*Coldal + Coldal*Boldal);
        }

        public override double Terfogat()
        {
            return Aoldal*Boldal*Coldal;
        }
    }
}
