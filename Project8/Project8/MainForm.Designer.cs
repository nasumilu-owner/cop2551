namespace Project8
{
    partial class MainForm
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
            this.studentListBox = new System.Windows.Forms.ListBox();
            this.birthYearLabel = new System.Windows.Forms.Label();
            this.birthYearField = new System.Windows.Forms.TextBox();
            this.birthYearResultListBox = new System.Windows.Forms.ListBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.studentListLabel = new System.Windows.Forms.Label();
            this.studentByYearLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openUrlMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // studentListBox
            // 
            this.studentListBox.FormattingEnabled = true;
            this.studentListBox.Location = new System.Drawing.Point(35, 58);
            this.studentListBox.Name = "studentListBox";
            this.studentListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.studentListBox.Size = new System.Drawing.Size(265, 472);
            this.studentListBox.Sorted = true;
            this.studentListBox.TabIndex = 0;
            this.studentListBox.TabStop = false;
            // 
            // birthYearLabel
            // 
            this.birthYearLabel.AutoSize = true;
            this.birthYearLabel.Location = new System.Drawing.Point(319, 65);
            this.birthYearLabel.Name = "birthYearLabel";
            this.birthYearLabel.Size = new System.Drawing.Size(64, 13);
            this.birthYearLabel.TabIndex = 1;
            this.birthYearLabel.Text = "Enter a year";
            // 
            // birthYearField
            // 
            this.birthYearField.Location = new System.Drawing.Point(389, 62);
            this.birthYearField.MaxLength = 4;
            this.birthYearField.Name = "birthYearField";
            this.birthYearField.Size = new System.Drawing.Size(162, 20);
            this.birthYearField.TabIndex = 0;
            this.birthYearField.TextChanged += new System.EventHandler(this.BirthYear_TextChanged);
            // 
            // birthYearResultListBox
            // 
            this.birthYearResultListBox.FormattingEnabled = true;
            this.birthYearResultListBox.Location = new System.Drawing.Point(322, 88);
            this.birthYearResultListBox.Name = "birthYearResultListBox";
            this.birthYearResultListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.birthYearResultListBox.Size = new System.Drawing.Size(229, 264);
            this.birthYearResultListBox.TabIndex = 3;
            this.birthYearResultListBox.UseTabStops = false;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(35, 545);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "Clea&r";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(476, 545);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "&Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // studentListLabel
            // 
            this.studentListLabel.AutoSize = true;
            this.studentListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentListLabel.Location = new System.Drawing.Point(31, 22);
            this.studentListLabel.Name = "studentListLabel";
            this.studentListLabel.Size = new System.Drawing.Size(149, 20);
            this.studentListLabel.TabIndex = 6;
            this.studentListLabel.Text = "StudentInfo By Name";
            // 
            // studentByYearLabel
            // 
            this.studentByYearLabel.AutoSize = true;
            this.studentByYearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentByYearLabel.Location = new System.Drawing.Point(318, 22);
            this.studentByYearLabel.Name = "studentByYearLabel";
            this.studentByYearLabel.Size = new System.Drawing.Size(182, 20);
            this.studentByYearLabel.TabIndex = 7;
            this.studentByYearLabel.Text = "StudentInfo by Birth Year";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project8.Properties.Resources.student;
            this.pictureBox1.Location = new System.Drawing.Point(322, 371);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(229, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(567, 24);
            this.menuStrip.TabIndex = 9;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openMenuItem,
            this.toolStripSeparator1,
            this.exitMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openMenuItem
            // 
            this.openMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileMenuItem,
            this.openUrlMenuItem});
            this.openMenuItem.Name = "openMenuItem";
            this.openMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openMenuItem.Text = "&Open";
            // 
            // openFileMenuItem
            // 
            this.openFileMenuItem.Name = "openFileMenuItem";
            this.openFileMenuItem.Size = new System.Drawing.Size(92, 22);
            this.openFileMenuItem.Text = "File";
            this.openFileMenuItem.Click += new System.EventHandler(this.OpenFileMenuItem_Click);
            // 
            // openUrlMenuItem
            // 
            this.openUrlMenuItem.Name = "openUrlMenuItem";
            this.openUrlMenuItem.Size = new System.Drawing.Size(92, 22);
            this.openUrlMenuItem.Text = "Url";
            this.openUrlMenuItem.Click += new System.EventHandler(this.OpenUrlMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(100, 6);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitMenuItem.Text = "&Exit";
            this.exitMenuItem.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(567, 583);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.studentByYearLabel);
            this.Controls.Add(this.studentListLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.birthYearResultListBox);
            this.Controls.Add(this.birthYearField);
            this.Controls.Add(this.birthYearLabel);
            this.Controls.Add(this.studentListBox);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_OnLoad);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox studentListBox;
        private System.Windows.Forms.Label birthYearLabel;
        private System.Windows.Forms.TextBox birthYearField;
        private System.Windows.Forms.ListBox birthYearResultListBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label studentListLabel;
        private System.Windows.Forms.Label studentByYearLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openUrlMenuItem;
    }
}

