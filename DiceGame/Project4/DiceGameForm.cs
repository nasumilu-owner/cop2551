using Project4.Properties;
using System;
using System.Windows.Forms;

namespace Project4
{
    public partial class DiceGameForm : Form
    {
        public DiceGameForm()
        {
            InitializeComponent();
            //Set the PlayerControl.Text property
            this.playerOneControl.Text = Resources.PLAYER_ONE;
            this.playerTwoControl.Text = Resources.PLAYER_TWO;
        }

        /// <summary>
        /// EventHandler for when the start new game button is clicked
        ///     1. Set the Player's Score to 0\
        ///     2. Enable Player 1 and disabled Player 2
        ///     3. Disable start new button
        ///     4. Sets focus to the player one's roll button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartNewGame_ButtonClicked(object sender, EventArgs e)
        {
            //Start a new game
            this.playerOneControl.Score = 0;
            this.playerTwoControl.Score = 0;
            this.playerOneControl.Enabled = true;
            this.startGameButton.Enabled = false;
            this.playerOneControl.Focus();
        }

        /// <summary>
        /// EventHandler to roll the dice when a player's roll dice
        /// button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlayerControl_Rolled(object sender, EventArgs e)
        {
            this.diceControl.Roll();
        }
        
        /// <summary>
        /// EventHandler for when a Player's score changes.
        /// 
        /// If the Player's whose score has changed is >= 50:
        ///     1. MessageBox is shown indicating the winner
        ///     2. Disable the Player's roll buttons.
        ///     3. Set focus to the start game button
        /// otherwise: 
        ///     Nothing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void Player_ScoreChanged(object sender, EventArgs args)
        {
            PlayerControl player = (PlayerControl)sender;

            if(player.Score >= 50)
            {
                MessageBox.Show($"Player {player.Text} is the winner!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.playerOneControl.Enabled = false;
                this.playerTwoControl.Enabled = false;
                this.startGameButton.Enabled = true;
                this.startGameButton.Focus();
            }
        }

        /// <summary>
        /// EventHandler for when the a dice roll is finished.
        ///     1. Determine the current and next players
        ///     2. Adds the dice roll score to the current player's score
        ///     2. Checks to see if double where rolled
        ///         a. No, disables current player and enables and focus other player
        ///     
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void Player_DiceRoleFinished(object sender, EventArgs args)
        {
            DiceControl dice = (DiceControl)sender;
            PlayerControl currentPlayer = this.playerTwoControl;
            PlayerControl otherPlayer = this.playerOneControl;
            if(this.playerOneControl.Enabled)
            {
                currentPlayer = this.playerOneControl;
                otherPlayer = this.playerTwoControl;
            }
            currentPlayer.Score += dice.Score;

            if (!dice.IsDoubles)
            {
                currentPlayer.Enabled = false;
                otherPlayer.Enabled = true;
                otherPlayer.Focus();
            }
        }

        /// <summary>
        /// EventHandler for the exit button.
        /// Closed the application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
