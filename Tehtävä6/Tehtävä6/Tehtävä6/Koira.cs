using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus6
{
    class Koira : Eläin
    {

        public override int MaxIkä { get => maxIkä; set => maxIkä = value; }

        private static int määrä = 0;

        public Koira(string _nimi, int _ikä)
        {
            MaxIkä = 25;

            Nimi = _nimi;
            Ikä = _ikä;

            määrä++;

            Console.WriteLine("Uusi Koira luotu, koiran nimi: " + Nimi);
        }

        public static new void Määrä()
        {
            Console.WriteLine("Koiria on yhteensä luotu " + määrä + " kappaletta");
        }

        public override void Ääni()
        {
            Console.WriteLine(Nimi + " sanoo: Woof woof");
        }
    }
}