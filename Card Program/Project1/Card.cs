using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{

    class Card
    {
        /// <summary>
        /// The Card color style which matches the two suit color. (red or black)
        /// </summary>
        public enum Color
        {
            Red = 2,
            Black = 4
        }

        /// <summary>
        /// The Card suit. (heart, diamon, spade, or club)
        /// </summary>
        public enum Suit
        {
            Hearts = 1,
            Diamonds = 2,
            Spades = 4,
            Clubs = 8
        }

        /// <summary>
        /// The Card face (Joker, Ace, Two, ...King)
        /// </summary>
        public enum Face
        {
            Joker = 0,
            Ace = 1,
            Two = 2,
            Three = 3,
            Four = 4,
            Five = 5,
            Six = 6,
            Seven = 7,
            Eight = 8,
            Nine = 9,
            Ten = 10,
            Jack = 11,
            Queen = 12,
            King = 13
        }

        /// <summary>
        /// The Card object's Suit
        /// 
        /// A Card object's suit may be null. This typically will occur when it is a Joker
        /// at which point the Card object's Color is used.
        /// </summary>
        private readonly Suit? _suit;
        /// <summary>
        /// The Card object's Face
        /// </summary>
        private readonly Face _face;
        /// <summary>
        /// The Card object's Color
        /// </summary>
        private readonly Color _color;

        /// <summary>
        /// Constucts a Card object with a color, face, and optional suit.
        /// </summary>
        /// <param name="color">The Card object's Color</param>
        /// <param name="face">The Card object's Face</param>
        /// <param name="suit">The Card object's optional Suit</param>
        public Card(Color color, Face face, Suit? suit)
        {
            _color = color;
            _face = face;
            _suit = suit;
        }

        /// <summary>
        /// Constructs a Card object with a color and face. 
        /// </summary>
        /// <param name="color">The Card object's Color</param>
        /// <param name="face">The Card object's Face</param>
        public Card(Color color, Face face) : this(color, face, null) {}

        /// <summary>
        /// Gets the Card objects Suit as a String; Null Suit will return and 
        /// empty string.
        /// </summary>
        public String SuitStr
        {
            get => (null == _suit) ? String.Empty : _suit.ToString();
        }

        /// <summary>
        /// Gets the Card object's Color as a String
        /// </summary>
        public String ColorStr
        {
            get => _color.ToString();
        }

        /// <summary>
        /// Gets the Card object's Face as a String
        /// </summary>
        public String FaceStr
        {
            get => _face.ToString();
        }

        /// <summary>
        /// Gets the Card objects String representation; Alias for Card.ToString()
        /// </summary>
        public String Text
        {
            get
            {
                return ToString();
            }
        }

        /// <summary>
        /// Gets the Card object's image file locations. 
        /// 
        /// Image files MUST be stored withing the working directory under .\Cards\Small\*.bmp
        /// </summary>
        public String ImageFile
        {
            get
            {
                String file = "Cards\\Small\\";
                switch(_face)
                {
                    case Face.Joker:
                        file += "Joker";
                        break;
                    case Face.Ace:
                        file += "Ace";
                        break;
                    case Face.Jack:
                        file += "Jack";
                        break;
                    case Face.King:
                        file += "King";
                        break;
                    case Face.Queen:
                        file += "Queen";
                        break;
                    default:
                        file += _face.ToString("D");
                        break;
                }

                if(null != _suit)
                {
                    file += "_" + _suit.ToString();
                } else
                {
                    file += "_" + _color.ToString();
                }

                return file + ".bmp";
            }
        }

        public override string ToString() {
            if (null == _suit)
            {
                return String.Format("{0} {1}", this.ColorStr, this.FaceStr);
            }
            return String.Format("{0} of {1}", this.FaceStr, this.SuitStr);
        }
    }


}
