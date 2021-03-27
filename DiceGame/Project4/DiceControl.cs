using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using Project4.Properties;
using System.Threading;

namespace Project4
{
    public partial class DiceControl : UserControl
    {
        public event EventHandler RollStarted; // This is used thought I may needed it 
        public event EventHandler RollFinished;
        private readonly Random random;
        private int diceOneValue;
        private int diceTwoValue;

        public DiceControl()
        {
            this.random = new Random();
            InitializeComponent();
            this.DiceOneValue = 1;
            this.DiceTwoValue = 1;
        }

        /// <summary>
        /// Simulates a dice roll. 
        /// </summary>
        public void Roll()
        {
            this.RollStarted?.Invoke(this, EventArgs.Empty);
            this.rollProgressBar.Value = 0;

            int tumblesOne = this.random.Next(50, 100);
            int tumblesTwo = this.random.Next(50, 100);
            this.rollProgressBar.Maximum = tumblesOne + tumblesTwo;

            this.DiceOneValue = this.RollDice(tumblesOne);
            this.DiceTwoValue = this.RollDice(tumblesTwo);

            Thread.Sleep(500);
            this.RollFinished?.Invoke(this, EventArgs.Empty);
            this.scoreField.Text = this.Score.ToString();
        }

        /// <summary>
        /// Indicates whether doubles had been rolled or not
        /// </summary>
        public bool IsDoubles
        {
            get => this.diceOneValue == this.diceTwoValue;
        }

        /// <summary>
        /// Simulates a dice roll with numberTumbles iterations.
        /// 
        /// Method puts the current Thread asleep for 0.002 seconds
        /// between iterators. 
        /// 
        /// Maximum delay is ~ 0.2 seconds
        /// Minimum delay is ~ 0.1 seconds
        /// </summary>
        /// <param name="numTumbles"></param>
        /// <returns></returns>
        private int RollDice(int numTumbles)
        {
            int value = 0; ;
            for(int i = 0;i<numTumbles;i++)
            {
                value = this.random.Next(1, 6);
                this.rollProgressBar.Value++;
                Thread.Sleep(2);
            }

            return value;
        }

        /// <summary>
        /// Utility method to see if the dice value is valid.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private bool IsDiceValueValid(int value)
        {
            return value >= 1 && value <= 6;
        }

        /// <summary>
        /// Getter/Setter for dice one's value
        /// </summary>
        public int DiceOneValue
        {
            get => this.diceOneValue;
            set {
                if(!this.IsDiceValueValid(value))
                {
                    throw new ArgumentException($"Dice value must be between 1 - 6, found {value}!");
                }
                this.diceOneValue = value;
                object obj = Resources.ResourceManager.GetObject("Die" + value);
                this.diceOneField.Image = ((System.Drawing.Bitmap)(obj));
            }
        }

        /// <summary>
        /// Getter/Setter for dice two's value
        /// </summary>
        public int DiceTwoValue
        {
            get => this.diceTwoValue;
            set
            {
                if (!this.IsDiceValueValid(value))
                {
                    throw new ArgumentException($"Dice value must be between 1 - 6, found {value}!");
                }
                this.diceTwoValue = value;
                object obj = Resources.ResourceManager.GetObject("Die" + value);
                this.diceTwoField.Image = ((System.Drawing.Bitmap)(obj));
            }
        }

        /// <summary>
        /// Getter (readonly) for the score. (dice1 + dice2)
        /// </summary>
        public int Score
        {
            get => this.diceOneValue + this.diceTwoValue;
        }
    }


}
