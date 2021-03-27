using System;
using System.Drawing;
using System.Windows.Forms;
using Project7.Properties;
using System.Threading;

namespace Project7
{
    /// <summary>
    /// This class represents one reel of a slot machine.
    /// </summary>
    public partial class Reel : UserControl
    {

        /// <summary>
        /// The images used to display on the reel
        /// </summary>
        private readonly Bitmap[] images = new Bitmap[] {
            Resources.Apple,
            Resources.Banana,
            Resources.Cherries,
            Resources.Grapes,
            Resources.Lemon,
            Resources.Lime,
            Resources.Orange,
            Resources.Pear,
            Resources.Strawberry,
            Resources.Watermelon
        };

        /// <summary>
        /// Labels for the the Reel's images
        /// </summary>
        private readonly String[] labels = new string[] {
            "Apple",
            "Bannana",
            "Cherries",
            "Grapes",
            "Lemon",
            "Lime",
            "Orange",
            "Pear",
            "Strawberry",
            "Watermelon"
        };

        /// <summary>
        /// The current value of the reel.
        /// </summary>
        private int value = 0;

        /// <summary>
        /// The number of spins this reel should perform
        /// </summary>
        private int numSpins = 25;

        /// <summary>
        /// Generates a random number when the reel is spinning.
        /// </summary>
        private readonly Random random = new Random();

        /// <summary>
        /// Constructs a slot machine reel.
        /// </summary>
        public Reel()
        {
            InitializeComponent();
            
        }

        /// <summary>
        /// The number of spins performed by this reel.
        /// </summary>
        public int NumSpins
        {
            get => this.numSpins;
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException($"Number of spins must be greater than 0, found ${value}!");
                }
                this.numSpins = value;
            }
        }

        /// <summary>
        /// Spins the reel by displaying a random images based upon the 
        /// Reel.NumSpins property.
        /// </summary>
        public void Spin()
        {
            for (int i = 0; i <= this.numSpins; i++)
            {
                this.value = this.random.Next(0, 10);
                this.reelPictrueBox.Image = this.images[this.value];
                this.reelPictrueBox.Refresh();
                // Give us mere mortals some time to see the image display.
                Thread.Sleep(100);
            }
        }

        /// <summary>
        /// The Reels value
        /// </summary>
        public int Value
        {
            get => value;
        }

        /// <summary>
        /// String representation of the Reel
        /// </summary>
        /// <returns></returns>
        public override String ToString()
        {
            return this.labels[this.value];
        }
       
    }
}
