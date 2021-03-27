using System;
using System.Windows.Forms;

namespace Project4
{
    public partial class PlayerControl : UserControl
    {
        /// <summary>
        /// EventHandler for when the roll button is clicked.
        /// </summary>
        public event EventHandler PlayerRollHandler;
        /// <summary>
        /// EventHandler for when the player's score changes.
        /// </summary>
        public event EventHandler ScoreChangedHandler;

        /// <summary>
        /// Holds the number of rolls this player has made
        /// </summary>
        private int rollCounter;

        public PlayerControl()
        {
            this.rollCounter = 0;
            InitializeComponent();
        }

        /// <summary>
        /// Sets the group boxes text property
        /// </summary>
        public override string Text
        {
            get => this.playerGroupBox.Text;
            set => this.playerGroupBox.Text = value;
        }

        /// <summary>
        /// Getter for the number of rolls the player has performed
        /// </summary>
        public int NumRolls
        {
            get => this.rollCounter;
        }

        /// <summary>
        /// Getter/Setter for the PlayerControl's Score
        /// </summary>
        public int Score
        {
            get => int.Parse(this.scoreField.Text);
            set
            {
                this.scoreField.Text = value.ToString();
                this.ScoreChangedHandler?.Invoke(this, EventArgs.Empty); //Empty EventArgs
            }
        }

        /// <summary>
        /// Getter/Setter to enable the PlayerControl's. 
        /// 
        /// Since the project expects to only enable/disable the roll
        /// button this hides the parent UserControl.Enabled property.
        /// </summary>
        public new bool Enabled
        {
            get => this.rollButton.Enabled;
            set => this.rollButton.Enabled = value;
        }

        /// <summary>
        /// EventHandler for the roll button
        ///     1. increments the roll conter
        ///     2. Delegates the button click event to any
        ///        registered PlayerRollHanders
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RollButton_Click(object sender, EventArgs e)
        {
            this.rollCounter++;
            this.PlayerRollHandler?.Invoke(this, e);
        }
    }
}
