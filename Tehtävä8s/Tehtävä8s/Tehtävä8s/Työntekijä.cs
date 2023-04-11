using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä8s
{
    class Työntekijä : Henkilö
    {

        public Työntekijä(string _nimi, string _työpaikka, int _palkka, int tunnit)
        {
            Nimi = _nimi;

            Työpaikka = _työpaikka;

            Palkka = _palkka;

            Tunnit = tunnit;


        }

        public void Tuntilasku()
        {
            Console.WriteLine("Työntekijän tunnit");
            Console.WriteLine(Nimi);
            Console.WriteLine(Tunnit);

        }
    }
}
