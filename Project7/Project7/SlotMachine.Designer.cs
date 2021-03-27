namespace Project7
{
    partial class slotForm
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
            Project7.Bank bank2 = new Project7.Bank();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(slotForm));
            this.betLabel = new System.Windows.Forms.Label();
            this.betField = new System.Windows.Forms.NumericUpDown();
            this.spinButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.bankView = new Project7.BankView();
            this.reelSet1 = new Project7.ReelSet();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.betField)).BeginInit();
            this.SuspendLayout();
            // 
            // betLabel
            // 
            this.betLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betLabel.Location = new System.Drawing.Point(41, 317);
            this.betLabel.Name = "betLabel";
            this.betLabel.Size = new System.Drawing.Size(95, 36);
            this.betLabel.TabIndex = 4;
            this.betLabel.Text = "Bet Amount";
            this.betLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // betField
            // 
            this.betField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betField.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.betField.Location = new System.Drawing.Point(132, 325);
            this.betField.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.betField.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.betField.Name = "betField";
            this.betField.Size = new System.Drawing.Size(120, 22);
            this.betField.TabIndex = 5;
            this.betField.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // spinButton
            // 
            this.spinButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spinButton.Location = new System.Drawing.Point(270, 315);
            this.spinButton.Name = "spinButton";
            this.spinButton.Size = new System.Drawing.Size(164, 36);
            this.spinButton.TabIndex = 6;
            this.spinButton.Text = "&Spin";
            this.spinButton.UseVisualStyleBackColor = true;
            this.spinButton.Click += new System.EventHandler(this.SpinButton_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.ForeColor = System.Drawing.Color.Brown;
            this.statusLabel.Location = new System.Drawing.Point(42, 44);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(392, 79);
            this.statusLabel.TabIndex = 7;
            this.statusLabel.Text = "Place Your Bet";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bankView
            // 
            bank2.Balance = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.bankView.Bank = bank2;
            this.bankView.Location = new System.Drawing.Point(609, 93);
            this.bankView.Name = "bankView";
            this.bankView.Size = new System.Drawing.Size(328, 239);
            this.bankView.TabIndex = 3;
            // 
            // reelSet1
            // 
            this.reelSet1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("reelSet1.BackgroundImage")));
            this.reelSet1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.reelSet1.Location = new System.Drawing.Point(-36, 3);
            this.reelSet1.Name = "reelSet1";
            this.reelSet1.Size = new System.Drawing.Size(639, 436);
            this.reelSet1.TabIndex = 2;
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(835, 371);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(102, 45);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // slotForm
            // 
            this.AcceptButton = this.spinButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(964, 441);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.spinButton);
            this.Controls.Add(this.betField);
            this.Controls.Add(this.betLabel);
            this.Controls.Add(this.bankView);
            this.Controls.Add(this.reelSet1);
            this.Name = "slotForm";
            this.Text = "Slot Machine";
            ((System.ComponentModel.ISupportInitialize)(this.betField)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ReelSet reelSet1;
        private BankView bankView;
        private System.Windows.Forms.Label betLabel;
        private System.Windows.Forms.NumericUpDown betField;
        private System.Windows.Forms.Button spinButton;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Button exitButton;
    }
}

