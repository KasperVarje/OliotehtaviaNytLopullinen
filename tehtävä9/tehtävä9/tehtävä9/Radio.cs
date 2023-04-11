using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtävä9
{
    internal class Radio
    {
        private bool Tila { get; set; }


        public void Kytkin()
        {
            Console.WriteLine("Kytke kiuas päälle painamalla p ");
            string tarkistus = Console.ReadLine();

            if (tarkistus == null)
            {
                Console.WriteLine("Virhe joudut käynnistämään radion uudestaan!");
            }
            else if(tarkistus == "p")
            {
                Tila = true;
                Console.WriteLine("Radio on kytketty päälle");      
            }
            else
            {
                Console.WriteLine("Virhe joudut käynnistämään radion uudestaan!");
            }
        }
    }
}
