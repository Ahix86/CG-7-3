using System;
using System.Collections.Generic;
using System.Text;

namespace DeckOfCards
{
    // method that gives full card name like Ace of Spades
    public class Card
    {
        // number/face value and suit value
        public string face { get; set;}
        public string suit { get; set;}

     public string GetFullName()
        {
            return $"{face} of {suit}";

        }
    }
}
