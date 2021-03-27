namespace Project1
{
    partial class CardDisplayForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.selectedCardField = new System.Windows.Forms.Label();
            this.dealButton = new System.Windows.Forms.Button();
            this.shuffleButton = new System.Windows.Forms.Button();
            this.cardsInDeckField = new System.Windows.Forms.Label();
            this.deckField = new System.Windows.Forms.PictureBox();
            this.cardFiveField = new System.Windows.Forms.PictureBox();
            this.cardFourField = new System.Windows.Forms.PictureBox();
            this.cardThreeField = new System.Windows.Forms.PictureBox();
            this.cardTwoField = new System.Windows.Forms.PictureBox();
            this.cardOneField = new System.Windows.Forms.PictureBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.horizontalLine = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.deckField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardFiveField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardFourField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardThreeField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardTwoField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardOneField)).BeginInit();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectedCardField
            // 
            this.selectedCardField.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.selectedCardField.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedCardField.Location = new System.Drawing.Point(34, 121);
            this.selectedCardField.Name = "selectedCardField";
            this.selectedCardField.Size = new System.Drawing.Size(326, 42);
            this.selectedCardField.TabIndex = 5;
            this.selectedCardField.Text = "None";
            this.selectedCardField.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dealButton
            // 
            this.dealButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dealButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealButton.Location = new System.Drawing.Point(377, 178);
            this.dealButton.Name = "dealButton";
            this.dealButton.Size = new System.Drawing.Size(86, 40);
            this.dealButton.TabIndex = 6;
            this.dealButton.Text = "&Deal";
            this.dealButton.UseVisualStyleBackColor = true;
            this.dealButton.Click += new System.EventHandler(this.DealCardsButton_Click);
            // 
            // shuffleButton
            // 
            this.shuffleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.shuffleButton.Enabled = false;
            this.shuffleButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shuffleButton.Location = new System.Drawing.Point(377, 224);
            this.shuffleButton.Name = "shuffleButton";
            this.shuffleButton.Size = new System.Drawing.Size(86, 40);
            this.shuffleButton.TabIndex = 8;
            this.shuffleButton.Text = "&Shuffle";
            this.shuffleButton.UseVisualStyleBackColor = true;
            this.shuffleButton.Click += new System.EventHandler(this.ShuffleCardsButton_Click);
            // 
            // cardsInDeckField
            // 
            this.cardsInDeckField.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cardsInDeckField.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardsInDeckField.Location = new System.Drawing.Point(413, 123);
            this.cardsInDeckField.Name = "cardsInDeckField";
            this.cardsInDeckField.Size = new System.Drawing.Size(50, 42);
            this.cardsInDeckField.TabIndex = 11;
            this.cardsInDeckField.Text = "0";
            this.cardsInDeckField.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // deckField
            // 
            this.deckField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.deckField.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deckField.Location = new System.Drawing.Point(413, 31);
            this.deckField.Margin = new System.Windows.Forms.Padding(0);
            this.deckField.MaximumSize = new System.Drawing.Size(50, 70);
            this.deckField.MinimumSize = new System.Drawing.Size(50, 70);
            this.deckField.Name = "deckField";
            this.deckField.Size = new System.Drawing.Size(50, 70);
            this.deckField.TabIndex = 7;
            this.deckField.TabStop = false;
            this.deckField.DoubleClick += new System.EventHandler(this.DeckField_DoubleClick);
            // 
            // cardFiveField
            // 
            this.cardFiveField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardFiveField.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cardFiveField.Location = new System.Drawing.Point(310, 31);
            this.cardFiveField.Margin = new System.Windows.Forms.Padding(0);
            this.cardFiveField.MaximumSize = new System.Drawing.Size(50, 70);
            this.cardFiveField.MinimumSize = new System.Drawing.Size(50, 70);
            this.cardFiveField.Name = "cardFiveField";
            this.cardFiveField.Size = new System.Drawing.Size(50, 70);
            this.cardFiveField.TabIndex = 4;
            this.cardFiveField.TabStop = false;
            this.cardFiveField.Click += new System.EventHandler(this.CardField_Click);
            // 
            // cardFourField
            // 
            this.cardFourField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardFourField.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cardFourField.Location = new System.Drawing.Point(241, 31);
            this.cardFourField.Margin = new System.Windows.Forms.Padding(0);
            this.cardFourField.MaximumSize = new System.Drawing.Size(50, 70);
            this.cardFourField.MinimumSize = new System.Drawing.Size(50, 70);
            this.cardFourField.Name = "cardFourField";
            this.cardFourField.Size = new System.Drawing.Size(50, 70);
            this.cardFourField.TabIndex = 3;
            this.cardFourField.TabStop = false;
            this.cardFourField.Click += new System.EventHandler(this.CardField_Click);
            // 
            // cardThreeField
            // 
            this.cardThreeField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardThreeField.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cardThreeField.Location = new System.Drawing.Point(172, 31);
            this.cardThreeField.Margin = new System.Windows.Forms.Padding(0);
            this.cardThreeField.MaximumSize = new System.Drawing.Size(50, 70);
            this.cardThreeField.MinimumSize = new System.Drawing.Size(50, 70);
            this.cardThreeField.Name = "cardThreeField";
            this.cardThreeField.Size = new System.Drawing.Size(50, 70);
            this.cardThreeField.TabIndex = 2;
            this.cardThreeField.TabStop = false;
            this.cardThreeField.Click += new System.EventHandler(this.CardField_Click);
            // 
            // cardTwoField
            // 
            this.cardTwoField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardTwoField.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cardTwoField.Location = new System.Drawing.Point(103, 31);
            this.cardTwoField.Margin = new System.Windows.Forms.Padding(0);
            this.cardTwoField.MaximumSize = new System.Drawing.Size(50, 70);
            this.cardTwoField.MinimumSize = new System.Drawing.Size(50, 70);
            this.cardTwoField.Name = "cardTwoField";
            this.cardTwoField.Size = new System.Drawing.Size(50, 70);
            this.cardTwoField.TabIndex = 1;
            this.cardTwoField.TabStop = false;
            this.cardTwoField.Click += new System.EventHandler(this.CardField_Click);
            // 
            // cardOneField
            // 
            this.cardOneField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardOneField.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cardOneField.Location = new System.Drawing.Point(34, 31);
            this.cardOneField.Margin = new System.Windows.Forms.Padding(0);
            this.cardOneField.MaximumSize = new System.Drawing.Size(50, 70);
            this.cardOneField.MinimumSize = new System.Drawing.Size(50, 70);
            this.cardOneField.Name = "cardOneField";
            this.cardOneField.Size = new System.Drawing.Size(50, 70);
            this.cardOneField.TabIndex = 0;
            this.cardOneField.TabStop = false;
            this.cardOneField.Click += new System.EventHandler(this.CardField_Click);
            // 
            // exitButton
            // 
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(34, 178);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(85, 40);
            this.exitButton.TabIndex = 12;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // horizontalLine
            // 
            this.horizontalLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.horizontalLine.Location = new System.Drawing.Point(34, 246);
            this.horizontalLine.Margin = new System.Windows.Forms.Padding(0);
            this.horizontalLine.Name = "horizontalLine";
            this.horizontalLine.Size = new System.Drawing.Size(312, 2);
            this.horizontalLine.TabIndex = 0;
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mainPanel.Controls.Add(this.cardFiveField);
            this.mainPanel.Controls.Add(this.horizontalLine);
            this.mainPanel.Controls.Add(this.cardOneField);
            this.mainPanel.Controls.Add(this.exitButton);
            this.mainPanel.Controls.Add(this.cardTwoField);
            this.mainPanel.Controls.Add(this.cardsInDeckField);
            this.mainPanel.Controls.Add(this.cardThreeField);
            this.mainPanel.Controls.Add(this.shuffleButton);
            this.mainPanel.Controls.Add(this.cardFourField);
            this.mainPanel.Controls.Add(this.deckField);
            this.mainPanel.Controls.Add(this.selectedCardField);
            this.mainPanel.Controls.Add(this.dealButton);
            this.mainPanel.Location = new System.Drawing.Point(36, 26);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(520, 324);
            this.mainPanel.TabIndex = 13;
            // 
            // CardDisplayForm
            // 
            this.AcceptButton = this.dealButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(585, 386);
            this.Controls.Add(this.mainPanel);
            this.Name = "CardDisplayForm";
            this.Text = "Project 1 - Card Display";
            this.Load += new System.EventHandler(this.CardDisplayForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.deckField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardFiveField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardFourField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardThreeField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardTwoField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardOneField)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox cardOneField;
        private System.Windows.Forms.PictureBox cardTwoField;
        private System.Windows.Forms.PictureBox cardThreeField;
        private System.Windows.Forms.PictureBox cardFourField;
        private System.Windows.Forms.PictureBox cardFiveField;
        private System.Windows.Forms.Label selectedCardField;
        private System.Windows.Forms.Button dealButton;
        private System.Windows.Forms.PictureBox deckField;
        private System.Windows.Forms.Button shuffleButton;
        private System.Windows.Forms.Label cardsInDeckField;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label horizontalLine;
        private System.Windows.Forms.Panel mainPanel;
    }
}

