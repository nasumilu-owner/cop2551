namespace Project4
{
    partial class DiceControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dicePanel = new System.Windows.Forms.Panel();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.scoreField = new System.Windows.Forms.Label();
            this.diceTwoField = new System.Windows.Forms.PictureBox();
            this.diceOneField = new System.Windows.Forms.PictureBox();
            this.rollProgressBar = new System.Windows.Forms.ProgressBar();
            this.dicePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diceTwoField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceOneField)).BeginInit();
            this.SuspendLayout();
            // 
            // dicePanel
            // 
            this.dicePanel.Controls.Add(this.scoreLabel);
            this.dicePanel.Controls.Add(this.scoreField);
            this.dicePanel.Controls.Add(this.diceTwoField);
            this.dicePanel.Controls.Add(this.diceOneField);
            this.dicePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dicePanel.Location = new System.Drawing.Point(0, 0);
            this.dicePanel.Name = "dicePanel";
            this.dicePanel.Size = new System.Drawing.Size(231, 171);
            this.dicePanel.TabIndex = 2;
            // 
            // scoreLabel
            // 
            this.scoreLabel.Location = new System.Drawing.Point(3, 107);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(101, 21);
            this.scoreLabel.TabIndex = 0;
            this.scoreLabel.Text = "Dice Value";
            this.scoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // scoreField
            // 
            this.scoreField.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.scoreField.Location = new System.Drawing.Point(124, 107);
            this.scoreField.Name = "scoreField";
            this.scoreField.Size = new System.Drawing.Size(104, 21);
            this.scoreField.TabIndex = 0;
            this.scoreField.Text = "2";
            this.scoreField.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // diceTwoField
            // 
            this.diceTwoField.Dock = System.Windows.Forms.DockStyle.Right;
            this.diceTwoField.Image = global::Project4.Properties.Resources.Die1;
            this.diceTwoField.InitialImage = global::Project4.Properties.Resources.Die1;
            this.diceTwoField.Location = new System.Drawing.Point(127, 0);
            this.diceTwoField.MaximumSize = new System.Drawing.Size(104, 104);
            this.diceTwoField.MinimumSize = new System.Drawing.Size(104, 104);
            this.diceTwoField.Name = "diceTwoField";
            this.diceTwoField.Size = new System.Drawing.Size(104, 104);
            this.diceTwoField.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.diceTwoField.TabIndex = 1;
            this.diceTwoField.TabStop = false;
            // 
            // diceOneField
            // 
            this.diceOneField.Dock = System.Windows.Forms.DockStyle.Left;
            this.diceOneField.Image = global::Project4.Properties.Resources.Die1;
            this.diceOneField.InitialImage = global::Project4.Properties.Resources.Die1;
            this.diceOneField.Location = new System.Drawing.Point(0, 0);
            this.diceOneField.MaximumSize = new System.Drawing.Size(104, 104);
            this.diceOneField.MinimumSize = new System.Drawing.Size(104, 104);
            this.diceOneField.Name = "diceOneField";
            this.diceOneField.Size = new System.Drawing.Size(104, 104);
            this.diceOneField.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.diceOneField.TabIndex = 0;
            this.diceOneField.TabStop = false;
            // 
            // rollProgressBar
            // 
            this.rollProgressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rollProgressBar.Location = new System.Drawing.Point(0, 152);
            this.rollProgressBar.Name = "rollProgressBar";
            this.rollProgressBar.Size = new System.Drawing.Size(231, 19);
            this.rollProgressBar.TabIndex = 3;
            // 
            // DiceControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rollProgressBar);
            this.Controls.Add(this.dicePanel);
            this.Name = "DiceControl";
            this.Size = new System.Drawing.Size(231, 171);
            this.dicePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.diceTwoField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceOneField)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox diceOneField;
        private System.Windows.Forms.Panel dicePanel;
        private System.Windows.Forms.PictureBox diceTwoField;
        private System.Windows.Forms.ProgressBar rollProgressBar;
        private System.Windows.Forms.Label scoreField;
        private System.Windows.Forms.Label scoreLabel;
    }
}
