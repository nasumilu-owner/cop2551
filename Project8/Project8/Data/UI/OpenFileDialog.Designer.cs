
namespace Project8.Data.UI
{
    partial class OpenFileDialog
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
            this.bufferSizeLabel = new System.Windows.Forms.Label();
            this.bufferSizeField = new System.Windows.Forms.TextBox();
            this.findButton = new System.Windows.Forms.Button();
            this.fileLabel = new System.Windows.Forms.Label();
            this.fileField = new System.Windows.Forms.TextBox();
            this.openButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.dialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // bufferSizeLabel
            // 
            this.bufferSizeLabel.AutoSize = true;
            this.bufferSizeLabel.Location = new System.Drawing.Point(22, 21);
            this.bufferSizeLabel.Name = "bufferSizeLabel";
            this.bufferSizeLabel.Size = new System.Drawing.Size(58, 13);
            this.bufferSizeLabel.TabIndex = 0;
            this.bufferSizeLabel.Text = "Buffer Size";
            // 
            // bufferSizeField
            // 
            this.bufferSizeField.Location = new System.Drawing.Point(96, 18);
            this.bufferSizeField.Name = "bufferSizeField";
            this.bufferSizeField.Size = new System.Drawing.Size(144, 20);
            this.bufferSizeField.TabIndex = 1;
            this.bufferSizeField.Text = "30";
            // 
            // findButton
            // 
            this.findButton.Location = new System.Drawing.Point(408, 50);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(75, 23);
            this.findButton.TabIndex = 2;
            this.findButton.Text = "Find";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // fileLabel
            // 
            this.fileLabel.AutoSize = true;
            this.fileLabel.Location = new System.Drawing.Point(57, 55);
            this.fileLabel.Name = "fileLabel";
            this.fileLabel.Size = new System.Drawing.Size(23, 13);
            this.fileLabel.TabIndex = 3;
            this.fileLabel.Text = "File";
            // 
            // fileField
            // 
            this.fileField.Location = new System.Drawing.Point(96, 50);
            this.fileField.Name = "fileField";
            this.fileField.Size = new System.Drawing.Size(306, 20);
            this.fileField.TabIndex = 4;
            this.fileField.TabStop = false;
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(327, 90);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(75, 23);
            this.openButton.TabIndex = 3;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(408, 90);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // openFileDialog
            // 
            this.dialog.FileName = "OpenFileDialog";
            // 
            // OpenFileDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 133);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.fileField);
            this.Controls.Add(this.fileLabel);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.bufferSizeField);
            this.Controls.Add(this.bufferSizeLabel);
            this.Name = "StudentOpenFileDialog";
            this.Text = "Open File";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bufferSizeLabel;
        private System.Windows.Forms.TextBox bufferSizeField;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.Label fileLabel;
        private System.Windows.Forms.TextBox fileField;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.OpenFileDialog dialog;
    }
}