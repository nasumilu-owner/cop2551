
namespace Project8.Data.UI
{
    partial class OpenUriDialog
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
            this.components = new System.ComponentModel.Container();
            this.urlLabel = new System.Windows.Forms.Label();
            this.timeOutLabel = new System.Windows.Forms.Label();
            this.timeOutField = new System.Windows.Forms.TextBox();
            this.maxByteLabel = new System.Windows.Forms.Label();
            this.maxByteField = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.urlField = new System.Windows.Forms.ComboBox();
            this.openUrlDialogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.openUrlDialogBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.Location = new System.Drawing.Point(17, 38);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(29, 13);
            this.urlLabel.TabIndex = 0;
            this.urlLabel.Text = "URL";
            // 
            // timeOutLabel
            // 
            this.timeOutLabel.AutoSize = true;
            this.timeOutLabel.Location = new System.Drawing.Point(1, 67);
            this.timeOutLabel.Name = "timeOutLabel";
            this.timeOutLabel.Size = new System.Drawing.Size(45, 13);
            this.timeOutLabel.TabIndex = 2;
            this.timeOutLabel.Text = "Timeout";
            // 
            // timeOutField
            // 
            this.timeOutField.Location = new System.Drawing.Point(52, 64);
            this.timeOutField.Name = "timeOutField";
            this.timeOutField.Size = new System.Drawing.Size(139, 20);
            this.timeOutField.TabIndex = 2;
            this.timeOutField.Text = "3000";
            // 
            // maxByteLabel
            // 
            this.maxByteLabel.AutoSize = true;
            this.maxByteLabel.Location = new System.Drawing.Point(205, 67);
            this.maxByteLabel.Name = "maxByteLabel";
            this.maxByteLabel.Size = new System.Drawing.Size(59, 13);
            this.maxByteLabel.TabIndex = 4;
            this.maxByteLabel.Text = "Max. Bytes";
            // 
            // maxByteField
            // 
            this.maxByteField.Location = new System.Drawing.Point(270, 64);
            this.maxByteField.Name = "maxByteField";
            this.maxByteField.Size = new System.Drawing.Size(139, 20);
            this.maxByteField.TabIndex = 3;
            this.maxByteField.Text = "1048576";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(334, 101);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(253, 101);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(75, 23);
            this.openButton.TabIndex = 4;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // urlField
            // 
            this.urlField.FormattingEnabled = true;
            this.urlField.Items.AddRange(new object[] {
            "http://home.ite.sfcollege.edu/~michael.lucas/cop2551/StudentClass2.txt",
            "http://home.ite.sfcollege.edu/~michael.lucas/cop2551/StudentClass3.txt",
            "http://home.ite.sfcollege.edu/~michael.lucas/cop2551/404.txt",
            "http://home.ite.sfcollege.edu/~michael.lucas/cop2551/BadNames.txt"});
            this.urlField.Location = new System.Drawing.Point(52, 35);
            this.urlField.Name = "urlField";
            this.urlField.Size = new System.Drawing.Size(357, 21);
            this.urlField.TabIndex = 6;
            // 
            // openUrlDialogBindingSource
            // 
            this.openUrlDialogBindingSource.DataSource = typeof(Project8.Data.UI.OpenUriDialog);
            // 
            // OpenUriDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 141);
            this.Controls.Add(this.urlField);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.maxByteField);
            this.Controls.Add(this.maxByteLabel);
            this.Controls.Add(this.timeOutField);
            this.Controls.Add(this.timeOutLabel);
            this.Controls.Add(this.urlLabel);
            this.HelpButton = true;
            this.Name = "OpenUriDialog";
            this.Text = "Open URL";
            ((System.ComponentModel.ISupportInitialize)(this.openUrlDialogBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label urlLabel;
        private System.Windows.Forms.Label timeOutLabel;
        private System.Windows.Forms.TextBox timeOutField;
        private System.Windows.Forms.Label maxByteLabel;
        private System.Windows.Forms.TextBox maxByteField;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.BindingSource openUrlDialogBindingSource;
        private System.Windows.Forms.ComboBox urlField;
    }
}