using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t12
{
    class Card
    {
        private string luku;
        private string maa; 

        public Card(string cardLuku, string cardMaa)
        {
            luku = cardLuku;
            maa = cardMaa;
        }

        public override string ToString()
        {
            return luku + " of " +  maa;
        }


    }
}
