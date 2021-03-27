using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    /// <summary>
    /// Represents a standard deck of cards with optional jokers.
    /// </summary>
    class CardDeck52 : ICardDeck 
    {
        /// <summary>
        /// There is currently two styles red or blue.
        /// </summary>
        public enum Style
        {
            Blue, // Deck will use the blue backface style
            Red   // Deck will use the read backface style
        }

        // A stack of Card objects
        private Stack<Card> _cards;
        // Deck's style property
        private readonly Style _style;

        /// <summary>
        /// Constructs a standard red backface deck of 52 cards, plus an optional 2 jokes when 
        /// intialized with true
        /// </summary>
        /// <param name="includeJoker">Indicates whether the deck is initialized 
        /// with joker cards or not</param>
        public CardDeck52(bool includeJoker = false) : this(Style.Red, includeJoker) { }

        /// <summary>
        /// Constructs a standard deck of 52 cards, plus an optional 2 jokers when
        /// initialized with true.
        /// </summary>
        /// <param name="style">The deck's style</param>
        /// <param name="includeJoker">Indicates whether the deck is initialized 
        /// with joker cards or not</param>
        public CardDeck52(Style style, bool includeJoker = false)
        {
            _style = style;
            int cardCount = (!includeJoker) ? 52 : 52 + 2;
            _cards = new Stack<Card>(cardCount);
            foreach(Card.Suit suit in Enum.GetValues(typeof(Card.Suit)))
            {
                Card.Color color = Card.Color.Black;
                if(suit == Card.Suit.Hearts || suit == Card.Suit.Diamonds)
                {
                    color = Card.Color.Red;
                }
                foreach(Card.Face face in Enum.GetValues(typeof(Card.Face)))
                {
                    if(face == Card.Face.Joker)
                    {
                        continue;
                    }
                    _cards.Push(new Card(color, face, suit));
                }
            }
            if(includeJoker)
            {
                _cards.Push(new Card(Card.Color.Black, Card.Face.Joker));
                _cards.Push(new Card(Card.Color.Red, Card.Face.Joker));
            }
            Shuffle();
        }

        /// <summary>
        /// See ICardDeck.Shuffle()
        /// </summary>
        public void Shuffle()
        {
            Random rnd = new Random();
            _cards = new Stack<Card>(_cards.OrderBy(x => rnd.Next()));
        }

        /// <summary>
        /// See ICardDec.Deal()
        /// </summary>
        /// <returns></returns>
        public Card Deal()
        {
            return _cards.Pop();
        }

        /// <summary>
        /// See ICardDeck.BackfaceImage
        /// </summary>
        public String BackfaceImage
        {
            get
            {
                return String.Format("Cards\\Small\\Backface_{0}.bmp", _style.ToString());
            }
        }

        /// <summary>
        /// See ICardDeck.IsEmpty
        /// </summary>
        public bool IsEmpty
        {
            get => _cards.Count == 0;
        }

        /// <summary>
        /// See ICardDeck.Count
        /// </summary>
        public int Count
        {
            get => _cards.Count;
        }
    }
}
