using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            BlackJack_Game game = new BlackJack_Game();
            game.Players = new List<string>() { "Garrett", "Aliza", "Abel" };
            game.ListPlayers();
            Console.ReadLine();

            Deck deck = new Deck();
            deck.shuffle(3);

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }
    }
}
