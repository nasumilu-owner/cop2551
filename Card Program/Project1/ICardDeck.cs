using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    /// <summary>
    /// I have always found it silly to prefix a class with an I to indicate its a interface
    /// When the API is programmed correctly the interface is almost always what you will 
    /// interact with not its underlying implementation. Especially with DependencyInjection. 
    /// Then again I find alot of Microsoft stuff peculiar and haphazardly bloated.
    /// Though I have seen a fair share of Java applications that should get sunset and 
    /// redesigned.
    /// 
    /// I would have create an abstract class which would have handled much of this classes 
    /// implementation but since I have already thinked this simple project, I will keep it 
    /// as is. 
    /// </summary>
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
