using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorteper
{
    class PictureCard : ICard, IPictureCard
    {
        private CardType cardType;
        public CardType CardType
        {
            get { return cardType; }
            set { cardType = value; }
        }
        private PictureCardType pictureCardType;
        public PictureCardType PictureCardType
        {
            get { return pictureCardType; }
            set { pictureCardType = value; }
        }
        private int cardNumber;
        public int CardNumber
        {
            get { return cardNumber; }
            set { cardNumber = value; }
        }

        public PictureCard(CardType type, PictureCardType pictureType)
        {
            this.CardType = type;
            this.PictureCardType = pictureType;
            this.CardNumber = cardNumber;
        }
    }
}
