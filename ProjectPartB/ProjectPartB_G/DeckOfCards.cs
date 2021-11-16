using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPartB_B1
{
    class DeckOfCards : IDeckOfCards
    {
        #region cards List related
        int nrOfCards = 52;

        protected const int MaxNrOfCards = 52;

        protected List<PlayingCard>cards = new List<PlayingCard>(MaxNrOfCards);

        public PlayingCard this[int idx]
        {
            get
            {
                return cards[idx];
            }
        }

        public int Count => nrOfCards;
        #endregion

        #region ToString() related
        public override string ToString()
        {
            /* string sRet = "";
             for (int i = 0; i < cards.Count; i++)
             {
                 sRet += cards[i].ToString() + "\n";
             }
             return sRet;*/
            return null;
        }
        #endregion

        #region Shuffle and Sorting
        public void Shuffle()
        {
           /* var rnd = new Random();
            int nrOfShuffles = rnd.Next(100, 100000);
            for (int shuffle = 0; shuffle < nrOfShuffles; shuffle++)
            {
                //Swap to random cards with each other
                int loCard = rnd.Next(0, 52);
                int hiCard = rnd.Next(0, 52);

                (cards[loCard], cards[hiCard]) = (cards[hiCard], cards[loCard]);
            }*/
        }
        public void Sort()
        {
        
        }
        #endregion

        #region Creating a fresh Deck
        public void Clear()
        {

        }
        public void CreateFreshDeck()
        {
            int cardNr = 0;
            for (PlayingCardColor c = PlayingCardColor.Clubs; c <= PlayingCardColor.Spades; c++)
            {
                for (PlayingCardValue v = PlayingCardValue.Two; v <= PlayingCardValue.Ace; v++)
                {
                    cards[cardNr] = new PlayingCard { Color = c, Value = v };
                    cardNr++;
                }
            }
        }
        public DeckOfCards()
        {
            CreateFreshDeck();
        }
        #endregion

        #region Dealing
        public PlayingCard RemoveTopCard()
        {
            return null;
        }
        #endregion
    }
}
