using System;
using Tehtävä5;

namespace Tehtävä5
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = 2.0f;
            float b = 1.5f;

            float summa = Laskin.Summa(a, b);
            float erotus = Laskin.Erotus(a, b);
            float kertolasku = Laskin.Kertolasku(a, b);
            float jakolasku = Laskin.Jakolasku(a, b);

            Console.WriteLine("Numeroiden " + a + " ja " + b);
            Console.WriteLine("Summa: " + summa);
            Console.WriteLine("Erotus: " + erotus);
            Console.WriteLine("Kertolasku: " + kertolasku);
            Console.WriteLine("Jakolasku: " + jakolasku);
        }
    }
}