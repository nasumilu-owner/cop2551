namespace Project4
{
    partial class DiceGameForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.startGameButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.emptyPanel = new System.Windows.Forms.Panel();
            this.diceControl = new Project4.DiceControl();
            this.playerOneControl = new Project4.PlayerControl();
            this.playerTwoControl = new Project4.PlayerControl();
            this.panel1.SuspendLayout();
            this.emptyPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.diceControl);
            this.panel1.Controls.Add(this.playerOneControl);
            this.panel1.Controls.Add(this.playerTwoControl);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(362, 240);
            this.panel1.TabIndex = 3;
            // 
            // startGameButton
            // 
            this.startGameButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.startGameButton.Location = new System.Drawing.Point(0, 0);
            this.startGameButton.Name = "startGameButton";
            this.startGameButton.Size = new System.Drawing.Size(146, 31);
            this.startGameButton.TabIndex = 1;
            this.startGameButton.Text = "Start &New Game";
            this.startGameButton.UseVisualStyleBackColor = true;
            this.startGameButton.Click += new System.EventHandler(this.StartNewGame_ButtonClicked);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.exitButton.Location = new System.Drawing.Point(0, 214);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(146, 26);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "&Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // emptyPanel
            // 
            this.emptyPanel.Controls.Add(this.startGameButton);
            this.emptyPanel.Controls.Add(this.exitButton);
            this.emptyPanel.Location = new System.Drawing.Point(380, 12);
            this.emptyPanel.Name = "emptyPanel";
            this.emptyPanel.Size = new System.Drawing.Size(146, 240);
            this.emptyPanel.TabIndex = 6;
            // 
            // diceControl
            // 
            this.diceControl.DiceOneValue = 1;
            this.diceControl.DiceTwoValue = 1;
            this.diceControl.Location = new System.Drawing.Point(78, 3);
            this.diceControl.Name = "diceControl";
            this.diceControl.Size = new System.Drawing.Size(217, 149);
            this.diceControl.TabIndex = 0;
            this.diceControl.TabStop = false;
            this.diceControl.RollFinished += new System.EventHandler(this.Player_DiceRoleFinished);
            // 
            // playerOneControl
            // 
            this.playerOneControl.Enabled = false;
            this.playerOneControl.Location = new System.Drawing.Point(3, 158);
            this.playerOneControl.Name = "playerOneControl";
            this.playerOneControl.Score = 0;
            this.playerOneControl.Size = new System.Drawing.Size(144, 80);
            this.playerOneControl.TabIndex = 2;
            this.playerOneControl.PlayerRollHandler += new System.EventHandler(this.PlayerControl_Rolled);
            this.playerOneControl.ScoreChangedHandler += new System.EventHandler(this.Player_ScoreChanged);
            // 
            // playerTwoControl
            // 
            this.playerTwoControl.Enabled = false;
            this.playerTwoControl.Location = new System.Drawing.Point(215, 158);
            this.playerTwoControl.Name = "playerTwoControl";
            this.playerTwoControl.Score = 0;
            this.playerTwoControl.Size = new System.Drawing.Size(144, 80);
            this.playerTwoControl.TabIndex = 3;
            this.playerTwoControl.PlayerRollHandler += new System.EventHandler(this.PlayerControl_Rolled);
            this.playerTwoControl.ScoreChangedHandler += new System.EventHandler(this.Player_ScoreChanged);
            // 
            // DiceGameForm
            // 
            this.AcceptButton = this.startGameButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(539, 262);
            this.Controls.Add(this.emptyPanel);
            this.Controls.Add(this.panel1);
            this.Name = "DiceGameForm";
            this.Text = "Dice Game";
            this.panel1.ResumeLayout(false);
            this.emptyPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DiceControl diceControl;
        private PlayerControl playerOneControl;
        private PlayerControl playerTwoControl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button startGameButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Panel emptyPanel;
    }
}

