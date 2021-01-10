using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorteper
{
    //Represents a card in a deck
    public class NumberCard : ICard
    {
        private CardType cardType;
        public CardType CardType
        {
            get { return cardType; }
            set { cardType = value; }
        }
        private int cardNumber;
        public int CardNumber
        {
            get { return cardNumber; }
            set { cardNumber = value; }
        }

        public NumberCard(CardType type, int cardNumber)
        {
            this.CardType = type;
            this.CardNumber = cardNumber;
        }
    }
}
