using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä8s
{
    class Pomo : Henkilö
    {
        private static int määrä = 0;

        public Pomo()
        {
            määrä++;
       
        }
        public void pomolasku()
        {
            if(Pomo.määrä > 1)
            {
                Console.WriteLine("Pomoja ei voi olla kuin yksi nyt niitä on " + Pomo.määrä);
            }
        }
    }

}
