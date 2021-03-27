using System;
using System.Windows.Forms;

/// <summary>
/// Michael Lucas
/// </summary>
namespace Project1
{
    /// <summary>
    /// 
    /// </summary>
    public partial class CardDisplayForm : Form
    {
        private ICardDeck deck;
        private readonly PictureBox[] cardsFields;


        public CardDisplayForm()
        {
            InitializeComponent();
            cardsFields = new PictureBox[] { cardOneField, cardTwoField, cardThreeField, cardFourField, cardFiveField };
        }

        /// <summary>
        /// CardDisplayForm_Load method
        ///   1. iterate through the five PictureBox objects setting their image to null
        ///      & visiblity to false
        ///   2. Make sure the label used to display the select card is set to "None" to 
        ///      indicate that no card is selected
        ///   3. initial a deck of 52 cards pluse 2 jokers
        ///   4. sets the PictureBox that represents the up side down deck is set to its
        ///      style (backface image)
        ///   5. Deal five initial cards
        ///   6. update the deck card counter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CardDisplayForm_Load(object sender, EventArgs e)
        {
            foreach (PictureBox cardField in cardsFields)
            {
                cardField.ImageLocation = null;
                cardField.Visible = false;
            }
            selectedCardField.Text = "None";
            deck = new CardDeck52(true);
            deckField.ImageLocation = deck.BackfaceImage;
            DealCards();
            UpdateCardsInDeckField();
        }


        /// <summary>
        /// DealCards method
        ///   1. Iterator through the five PictureBox objects
        ///     a. if the deck is not empty
        ///         - Deal a card from the deck (pop a card from the stack)
        ///         - Attached the card object to the PictureBox.Tag property
        ///         - update the PictureBox objects image location
        ///         - make sure it is visible
        ///     b. if the deck is empty
        ///         - set the PictureBox object visiblity to fasle
        ///         - set it image to null
        ///   2. If the deck is empty
        ///     a. Go to ShowEmptyDeck()
        ///   3. Update the card counter
        /// </summary>
        public void DealCards()
        {
            foreach (PictureBox cardField in cardsFields)
            {
                if (!deck.IsEmpty)
                {
                    Card card = deck.Deal();
                    cardField.Tag = card;
                    cardField.ImageLocation = card.ImageFile;
                    cardField.Visible = true;
                } else
                {
                    cardField.Visible = false;
                    cardField.ImageLocation = null;
                }
            }
            if(deck.IsEmpty)
            {
                ShowEmptyDeck();
            }
            UpdateCardsInDeckField();
        }

        /// <summary>
        /// ShowEmptyDeck method is a utility method used to update the GUI 
        /// when the ICardDeck is empty.
        /// </summary>
        private void ShowEmptyDeck()
        {
            deckField.Image = null;
            dealButton.Enabled = false;
            shuffleButton.Enabled = true;
        }

        /// <summary>
        /// UpdatCardsInDeckField is a utility method used to update the 
        /// card counter GUI.
        /// </summary>
        private void UpdateCardsInDeckField()
        {
            cardsInDeckField.Text = deck.Count.ToString();
        }

        /// <summary>
        /// CardField_Click method is called when the user clicks on one
        /// of the PictureBox objects. This will display the name of the 
        /// card click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CardField_Click(object sender, EventArgs e)
        {
            Card card = (Card) ((PictureBox)sender).Tag;
            if(null != card)
            {
                selectedCardField.Text = card.Text;
            }
        }

        /// <summary>
        /// ShuffleCardButton_Click method shuffles the deck of cards by 
        /// calling CardDisplayForm_Load method effectivly resetting the 
        /// GUI but handels setting the shuffle & deal button's enabled
        /// property. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShuffleCardsButton_Click(object sender, EventArgs e)
        {
            CardDisplayForm_Load(sender, e);
            shuffleButton.Enabled = false;
            dealButton.Enabled = true;
        }

        /// <summary>
        /// DealCardsButton_Click method is an event handler for when
        /// the user click on the deal button or the deck PictureBox. 
        /// This method delegates to the DealCards method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DealCardsButton_Click(object sender, EventArgs e)
        {
            DealCards();
        }

        /// <summary>
        /// ExitButton_Click method is an event handler for the 
        /// exit button. This method will close the application 
        /// when called. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeckField_DoubleClick(object sender, EventArgs e)
        {
            if (deck.IsEmpty)
            {
                DialogResult result = MessageBox.Show(this, "Out of cards, would you like to redeal?",
                    "Redeal?", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    ShuffleCardsButton_Click(sender, e);
                }
            }
            else
            {
                DealCards();
            }
        }
    }
}
