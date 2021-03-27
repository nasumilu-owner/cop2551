namespace Project7
{
    partial class Reel
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
            this.reelPictrueBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.reelPictrueBox)).BeginInit();
            this.SuspendLayout();
            // 
            // reelPictrueBox
            // 
            this.reelPictrueBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reelPictrueBox.Location = new System.Drawing.Point(0, 0);
            this.reelPictrueBox.Name = "reelPictrueBox";
            this.reelPictrueBox.Size = new System.Drawing.Size(283, 236);
            this.reelPictrueBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.reelPictrueBox.TabIndex = 0;
            this.reelPictrueBox.TabStop = false;
            // 
            // Reel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.reelPictrueBox);
            this.Name = "Reel";
            this.Size = new System.Drawing.Size(283, 236);
            ((System.ComponentModel.ISupportInitialize)(this.reelPictrueBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox reelPictrueBox;
    }
}
