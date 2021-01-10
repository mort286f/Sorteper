using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorteper
{
    class Program
    {
        static void Main(string[] args)
        {
            CardDeck cd = new CardDeck();

            //Generates 10 number cards for each card type
            cd.GenerateNumberCards(CardType.Clubs);
            cd.GenerateNumberCards(CardType.Diamonds);
            cd.GenerateNumberCards(CardType.Hearts);
            cd.GenerateNumberCards(CardType.Spades);

            //Generates each picture card
            cd.GeneratePictureCards(PictureCardType.Jack);
            cd.GeneratePictureCards(PictureCardType.Queen);
            cd.GeneratePictureCards(PictureCardType.King);

            cd.CreateDeck();
            foreach (var card in cd.FinishedDeck)
            {
                Console.WriteLine(card.CardType + " of " );
            }
            Console.ReadLine();
        }
    }
}
