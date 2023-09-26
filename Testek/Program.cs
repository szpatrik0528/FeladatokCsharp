using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testek
{
    internal class Program
    {
        static List<Testek> tests = new List<Testek>();
        static void Main(string[] args)
        {
            tests.Add(new Henger(3,6));
            tests.Add(new Kocka(5));
            tests.Add(new Teglatest(3, 4, 5));

            foreach (var test in tests)
            {
                if (test.GetType().Equals(typeof(Henger)))
                {
                    Henger henger = (Henger)test;
                    Console.WriteLine($"A henger felszíne: {test.Felszin()}m2  - térfogat: {test.Terfogat()}m3");
                }
                else if (test.GetType().Equals (typeof(Kocka)))
                {
                    Kocka kocka = (Kocka)test; 
                    Console.WriteLine($"A kocka felszíne: {test.Felszin()}m2 - térfogat: {test.Terfogat()}m3");

                }
                else if (test.GetType().Equals(typeof(Teglatest)))
                {
                    Teglatest teglatest = (Teglatest)test;
                    Console.WriteLine($"A Téglatest felszíne: {test.Felszin()}m2 - térfogat: {test.Terfogat()}m3");
                }
            }


            Console.WriteLine("Program vége!");
            Console.ReadLine();
        }
    }
}
