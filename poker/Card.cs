using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poker
{
    internal class Card
    {
        string suit;
        int value;

        public Card(string suit, int value)
        {
            this.suit = suit;
            this.value = value;
        }
    }
}
