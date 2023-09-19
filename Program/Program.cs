using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sikidom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Sikidom> sikidom = new List<Sikidom>();
            sikidom.Add(new Kor(3.56));
            sikidom.Add(new Teglalap(3, 5));
            sikidom.Add(new Negyzet(6));

            foreach (var item in sikidom)
            {
                Console.WriteLine($"{item} - {item.Terulet()},{item.Kerulet()}");
            }
            Console.ReadLine();
        }
    }
}