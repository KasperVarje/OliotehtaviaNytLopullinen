using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus6
{
    abstract class Eläin
    {
        public int maxIkä;
        public abstract int MaxIkä { get; set; }

        private string nimi;
        public string Nimi { get; set; }


        private int ikä;
        public virtual int Ikä
        {
            get { return ikä; }
            set
            {
                if (value < 5)
                {
                    Console.WriteLine("Annettu ikä on pienempi kuin 5 joten eläimen iäksi on asetettu 0");
                    value = 0;
                }
                else if (value > MaxIkä)
                {
                    Console.WriteLine(Nimi + " Annettu ikä ylittää {0}. Iäksi asetettu {1}", MaxIkä, MaxIkä - 1);
                    value = MaxIkä - 1;
                }

                ikä = value;
            }
        }

        private static int määrä = 0;

        public Eläin()
        {
            määrä++;
        }

        public static void Määrä()
        {
            Console.WriteLine("Eläimiä on yhteensä  " + määrä + " kappaletta");
        }

        // abstrakti metodi, ei logiikkaa sisälle.
        public abstract void Ääni();
    }
}