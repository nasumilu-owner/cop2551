namespace Project7
{
    partial class ReelSet
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
            this.reel1Label = new System.Windows.Forms.Label();
            this.reel2Label = new System.Windows.Forms.Label();
            this.reel3Label = new System.Windows.Forms.Label();
            this.reel3 = new Project7.Reel();
            this.reel2 = new Project7.Reel();
            this.reel1 = new Project7.Reel();
            this.SuspendLayout();
            // 
            // reel1Label
            // 
            this.reel1Label.BackColor = System.Drawing.Color.Transparent;
            this.reel1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reel1Label.ForeColor = System.Drawing.Color.White;
            this.reel1Label.Location = new System.Drawing.Point(64, 280);
            this.reel1Label.Name = "reel1Label";
            this.reel1Label.Size = new System.Drawing.Size(128, 22);
            this.reel1Label.TabIndex = 0;
            this.reel1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reel2Label
            // 
            this.reel2Label.BackColor = System.Drawing.Color.Transparent;
            this.reel2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reel2Label.ForeColor = System.Drawing.Color.White;
            this.reel2Label.Location = new System.Drawing.Point(215, 280);
            this.reel2Label.Name = "reel2Label";
            this.reel2Label.Size = new System.Drawing.Size(128, 22);
            this.reel2Label.TabIndex = 6;
            this.reel2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reel3Label
            // 
            this.reel3Label.BackColor = System.Drawing.Color.Transparent;
            this.reel3Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reel3Label.ForeColor = System.Drawing.Color.White;
            this.reel3Label.Location = new System.Drawing.Point(362, 280);
            this.reel3Label.Name = "reel3Label";
            this.reel3Label.Size = new System.Drawing.Size(128, 22);
            this.reel3Label.TabIndex = 0;
            this.reel3Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reel3
            // 
            this.reel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.reel3.Location = new System.Drawing.Point(362, 149);
            this.reel3.Name = "reel3";
            this.reel3.NumSpins = 25;
            this.reel3.Size = new System.Drawing.Size(128, 128);
            this.reel3.TabIndex = 2;
            // 
            // reel2
            // 
            this.reel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.reel2.Location = new System.Drawing.Point(215, 149);
            this.reel2.Name = "reel2";
            this.reel2.NumSpins = 25;
            this.reel2.Size = new System.Drawing.Size(128, 128);
            this.reel2.TabIndex = 1;
            // 
            // reel1
            // 
            this.reel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.reel1.Location = new System.Drawing.Point(64, 149);
            this.reel1.Name = "reel1";
            this.reel1.NumSpins = 25;
            this.reel1.Size = new System.Drawing.Size(128, 128);
            this.reel1.TabIndex = 0;
            // 
            // ReelSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project7.Properties.Resources.slot;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Controls.Add(this.reel3Label);
            this.Controls.Add(this.reel2Label);
            this.Controls.Add(this.reel1Label);
            this.Controls.Add(this.reel3);
            this.Controls.Add(this.reel2);
            this.Controls.Add(this.reel1);
            this.DoubleBuffered = true;
            this.Name = "ReelSet";
            this.Size = new System.Drawing.Size(639, 436);
            this.ResumeLayout(false);

        }

        #endregion

        private Reel reel1;
        private Reel reel2;
        private Reel reel3;
        private System.Windows.Forms.Label reel1Label;
        private System.Windows.Forms.Label reel2Label;
        private System.Windows.Forms.Label reel3Label;
    }
}
