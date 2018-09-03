using System;
using System.Collections.Generic;
using System.Text;

namespace DeckOfCards
{
   public  class Deck
    {
        public Card[] Cards { get; set; }

        public Deck(int numberofcards)
        {
            Cards = new Card[numberofcards];
        }

        public Card Draw()
        {
            var rnd = new Random();
            var number = rnd.Next(Cards.Length);
            return Cards[number];


          

        }
    }
}
