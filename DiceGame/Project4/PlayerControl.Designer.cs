namespace Project4
{
    partial class PlayerControl
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
            this.rollButton = new System.Windows.Forms.Button();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.scoreField = new System.Windows.Forms.TextBox();
            this.playerGroupBox = new System.Windows.Forms.GroupBox();
            this.playerGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // rollButton
            // 
            this.rollButton.Enabled = false;
            this.rollButton.Location = new System.Drawing.Point(6, 19);
            this.rollButton.Name = "rollButton";
            this.rollButton.Size = new System.Drawing.Size(128, 23);
            this.rollButton.TabIndex = 1;
            this.rollButton.Text = "&Press to Roll";
            this.rollButton.UseVisualStyleBackColor = true;
            this.rollButton.Click += new System.EventHandler(this.RollButton_Click);
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Location = new System.Drawing.Point(6, 53);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(35, 13);
            this.scoreLabel.TabIndex = 0;
            this.scoreLabel.Text = "Score";
            // 
            // scoreField
            // 
            this.scoreField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.scoreField.Location = new System.Drawing.Point(52, 53);
            this.scoreField.Name = "scoreField";
            this.scoreField.ReadOnly = true;
            this.scoreField.Size = new System.Drawing.Size(82, 13);
            this.scoreField.TabIndex = 0;
            this.scoreField.TabStop = false;
            this.scoreField.Text = "0";
            // 
            // playerGroupBox
            // 
            this.playerGroupBox.Controls.Add(this.rollButton);
            this.playerGroupBox.Controls.Add(this.scoreField);
            this.playerGroupBox.Controls.Add(this.scoreLabel);
            this.playerGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playerGroupBox.Location = new System.Drawing.Point(0, 0);
            this.playerGroupBox.Name = "playerGroupBox";
            this.playerGroupBox.Size = new System.Drawing.Size(144, 80);
            this.playerGroupBox.TabIndex = 3;
            this.playerGroupBox.TabStop = false;
            this.playerGroupBox.Text = "Player";
            // 
            // PlayerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.playerGroupBox);
            this.Name = "PlayerControl";
            this.Size = new System.Drawing.Size(144, 80);
            this.playerGroupBox.ResumeLayout(false);
            this.playerGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button rollButton;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.TextBox scoreField;
        private System.Windows.Forms.GroupBox playerGroupBox;
    }
}
