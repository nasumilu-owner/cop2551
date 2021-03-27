using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    interface ICardDeck
    {
        /// <summary>
        /// Suffle the deck. 
        /// 
        /// Shuffling the deck randomizes the Cards in a Stack.
        /// </summary>
        void Shuffle();

        /// <summary>
        /// Gets the deck's backface image. 
        /// </summary>
        String BackfaceImage
        {
            get;
        }

        /// <summary>
        /// Deals or better stated Pops a single card of the top of the deck.
        /// </summary>
        /// <returns></returns>
        Card Deal();

        /// <summary>
        /// Indicates whether the deck is empty. 
        /// </summary>
        bool IsEmpty
        {
            get;
        }

        /// <summary>
        /// Gets the number of cards in the deck.
        /// </summary>
        int Count
        {
            get;
        }

    }
}
