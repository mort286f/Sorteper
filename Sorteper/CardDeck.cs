using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorteper
{
    //Represents a deck
    class CardDeck : IDeck
    {
        private List<ICard> numberCards;
        public List<ICard> NumberCards
        {
            get { return numberCards; }
            set { numberCards = value; }
        }
        private List<ICard> pictureCards;

        public List<ICard> PictureCards
        {
            get { return pictureCards; }
            set { pictureCards = value; }
        }
        private List<ICard> finishedDeck;

        public List<ICard> FinishedDeck
        {
            get { return finishedDeck; }
            set { finishedDeck = value; }
        }

        public CardDeck()
        {

        }
        public void GenerateNumberCards(CardType cardType) 
        {
            for (int i = 1; i <= 10; i++)
            {
                NumberCards.Add(new NumberCard(cardType, i));
            }
        }
        public void GeneratePictureCards(PictureCardType picCardType)
        {
            for (int i = 1; i <= 4; i++)
            {
                if (picCardType == PictureCardType.Jack)
                {
                    PictureCards.Add(new PictureCard(CardType.Diamonds, picCardType));
                    PictureCards.Add(new PictureCard(CardType.Hearts, picCardType));
                    PictureCards.Add(new PictureCard(CardType.Spades, picCardType));
                }
                else
                {
                    pictureCards.Add(new PictureCard(CardType.Clubs, picCardType));
                    pictureCards.Add(new PictureCard(CardType.Diamonds, picCardType));
                    pictureCards.Add(new PictureCard(CardType.Hearts, picCardType));
                    pictureCards.Add(new PictureCard(CardType.Spades, picCardType));
                }
            }
        }
        public void CreateDeck()
        {
            NumberCards.AddRange(PictureCards);
            FinishedDeck.AddRange(NumberCards);
        }
    }
}
