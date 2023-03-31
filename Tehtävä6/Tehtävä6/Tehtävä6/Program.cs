using System;

namespace Harjoitus6
{
    class Program
    {
        static void Main(string[] args)
        {
            

            
            Hämähäkki Jussi = new Hämähäkki("Jussi", 20, "SHEES SHEESH");
            Hämähäkki Simpukka = new Hämähäkki("Simpukka", 60, "GRRRRPAAU");

            Jussi.Ääni();
            Simpukka.Ääni();

            Koira huffe = new Koira("Mopsi", 6);
            Koira truffe = new Koira("Mopsi", 0);

            huffe.Ääni();

            Eläin.Määrä();
            Hämähäkki.Määrä();
            Koira.Määrä();
        }
    }
}