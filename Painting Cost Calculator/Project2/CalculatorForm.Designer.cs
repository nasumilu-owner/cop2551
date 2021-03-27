namespace Project2
{
    partial class PaintingCostCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaintingCostCalculator));
            this.paintCostLabel = new System.Windows.Forms.Label();
            this.paintCostField = new System.Windows.Forms.NumericUpDown();
            this.surfaceAreaLabel = new System.Windows.Forms.Label();
            this.surfaceAreaField = new System.Windows.Forms.NumericUpDown();
            this.calculatorResultPanel = new System.Windows.Forms.Panel();
            this.totalCostField = new System.Windows.Forms.Label();
            this.totalCostLabel = new System.Windows.Forms.Label();
            this.totalLaborCostField = new System.Windows.Forms.Label();
            this.totalLaborCostLabel = new System.Windows.Forms.Label();
            this.totalPaintCostField = new System.Windows.Forms.Label();
            this.totalPaintCostLabel = new System.Windows.Forms.Label();
            this.laborHoursField = new System.Windows.Forms.Label();
            this.laborHoursLabel = new System.Windows.Forms.Label();
            this.gallonsOfPaintField = new System.Windows.Forms.Label();
            this.gallonsOfPaintLabel = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.horizontalLine = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.paintCostField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.surfaceAreaField)).BeginInit();
            this.calculatorResultPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // paintCostLabel
            // 
            this.paintCostLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paintCostLabel.Location = new System.Drawing.Point(19, 20);
            this.paintCostLabel.Name = "paintCostLabel";
            this.paintCostLabel.Size = new System.Drawing.Size(178, 38);
            this.paintCostLabel.TabIndex = 0;
            this.paintCostLabel.Text = "Paint Cost (gallon)";
            this.paintCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // paintCostField
            // 
            this.paintCostField.DecimalPlaces = 2;
            this.paintCostField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paintCostField.ImeMode = System.Windows.Forms.ImeMode.On;
            this.paintCostField.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.paintCostField.Location = new System.Drawing.Point(225, 25);
            this.paintCostField.Margin = new System.Windows.Forms.Padding(5);
            this.paintCostField.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.paintCostField.Name = "paintCostField";
            this.paintCostField.Size = new System.Drawing.Size(219, 29);
            this.paintCostField.TabIndex = 1;
            this.paintCostField.Enter += new System.EventHandler(this.SelectValue_Enter);
            // 
            // surfaceAreaLabel
            // 
            this.surfaceAreaLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surfaceAreaLabel.Location = new System.Drawing.Point(19, 64);
            this.surfaceAreaLabel.Name = "surfaceAreaLabel";
            this.surfaceAreaLabel.Size = new System.Drawing.Size(178, 38);
            this.surfaceAreaLabel.TabIndex = 2;
            this.surfaceAreaLabel.Text = "Surface Area (sqft)";
            this.surfaceAreaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // surfaceAreaField
            // 
            this.surfaceAreaField.DecimalPlaces = 1;
            this.surfaceAreaField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surfaceAreaField.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.surfaceAreaField.Location = new System.Drawing.Point(225, 69);
            this.surfaceAreaField.Margin = new System.Windows.Forms.Padding(5);
            this.surfaceAreaField.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.surfaceAreaField.Name = "surfaceAreaField";
            this.surfaceAreaField.Size = new System.Drawing.Size(219, 29);
            this.surfaceAreaField.TabIndex = 2;
            this.surfaceAreaField.Enter += new System.EventHandler(this.SelectValue_Enter);
            // 
            // calculatorResultPanel
            // 
            this.calculatorResultPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.calculatorResultPanel.Controls.Add(this.totalCostField);
            this.calculatorResultPanel.Controls.Add(this.totalCostLabel);
            this.calculatorResultPanel.Controls.Add(this.totalLaborCostField);
            this.calculatorResultPanel.Controls.Add(this.totalLaborCostLabel);
            this.calculatorResultPanel.Controls.Add(this.totalPaintCostField);
            this.calculatorResultPanel.Controls.Add(this.totalPaintCostLabel);
            this.calculatorResultPanel.Controls.Add(this.laborHoursField);
            this.calculatorResultPanel.Controls.Add(this.laborHoursLabel);
            this.calculatorResultPanel.Controls.Add(this.gallonsOfPaintField);
            this.calculatorResultPanel.Controls.Add(this.gallonsOfPaintLabel);
            this.calculatorResultPanel.Location = new System.Drawing.Point(22, 127);
            this.calculatorResultPanel.Name = "calculatorResultPanel";
            this.calculatorResultPanel.Size = new System.Drawing.Size(422, 246);
            this.calculatorResultPanel.TabIndex = 4;
            // 
            // totalCostField
            // 
            this.totalCostField.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalCostField.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCostField.Location = new System.Drawing.Point(202, 184);
            this.totalCostField.Name = "totalCostField";
            this.totalCostField.Size = new System.Drawing.Size(207, 38);
            this.totalCostField.TabIndex = 0;
            this.totalCostField.Text = "$0.00";
            this.totalCostField.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalCostLabel
            // 
            this.totalCostLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCostLabel.Location = new System.Drawing.Point(14, 184);
            this.totalCostLabel.Name = "totalCostLabel";
            this.totalCostLabel.Size = new System.Drawing.Size(160, 38);
            this.totalCostLabel.TabIndex = 0;
            this.totalCostLabel.Text = "Total Cost:";
            this.totalCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // totalLaborCostField
            // 
            this.totalLaborCostField.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalLaborCostField.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLaborCostField.Location = new System.Drawing.Point(202, 143);
            this.totalLaborCostField.Name = "totalLaborCostField";
            this.totalLaborCostField.Size = new System.Drawing.Size(207, 38);
            this.totalLaborCostField.TabIndex = 0;
            this.totalLaborCostField.Text = "$0.00";
            this.totalLaborCostField.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalLaborCostLabel
            // 
            this.totalLaborCostLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLaborCostLabel.Location = new System.Drawing.Point(14, 143);
            this.totalLaborCostLabel.Name = "totalLaborCostLabel";
            this.totalLaborCostLabel.Size = new System.Drawing.Size(160, 38);
            this.totalLaborCostLabel.TabIndex = 0;
            this.totalLaborCostLabel.Text = "Total Labor Cost: ";
            this.totalLaborCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // totalPaintCostField
            // 
            this.totalPaintCostField.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalPaintCostField.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPaintCostField.Location = new System.Drawing.Point(202, 102);
            this.totalPaintCostField.Name = "totalPaintCostField";
            this.totalPaintCostField.Size = new System.Drawing.Size(207, 38);
            this.totalPaintCostField.TabIndex = 0;
            this.totalPaintCostField.Text = "$0.00";
            this.totalPaintCostField.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalPaintCostLabel
            // 
            this.totalPaintCostLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPaintCostLabel.Location = new System.Drawing.Point(14, 102);
            this.totalPaintCostLabel.Name = "totalPaintCostLabel";
            this.totalPaintCostLabel.Size = new System.Drawing.Size(160, 38);
            this.totalPaintCostLabel.TabIndex = 0;
            this.totalPaintCostLabel.Text = "Total Paint Cost: ";
            this.totalPaintCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // laborHoursField
            // 
            this.laborHoursField.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.laborHoursField.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laborHoursField.Location = new System.Drawing.Point(202, 61);
            this.laborHoursField.Name = "laborHoursField";
            this.laborHoursField.Size = new System.Drawing.Size(207, 38);
            this.laborHoursField.TabIndex = 0;
            this.laborHoursField.Text = "0.0";
            this.laborHoursField.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // laborHoursLabel
            // 
            this.laborHoursLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laborHoursLabel.Location = new System.Drawing.Point(14, 61);
            this.laborHoursLabel.Name = "laborHoursLabel";
            this.laborHoursLabel.Size = new System.Drawing.Size(160, 38);
            this.laborHoursLabel.TabIndex = 0;
            this.laborHoursLabel.Text = "Labor (hr):";
            this.laborHoursLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gallonsOfPaintField
            // 
            this.gallonsOfPaintField.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gallonsOfPaintField.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gallonsOfPaintField.Location = new System.Drawing.Point(202, 20);
            this.gallonsOfPaintField.Name = "gallonsOfPaintField";
            this.gallonsOfPaintField.Size = new System.Drawing.Size(207, 38);
            this.gallonsOfPaintField.TabIndex = 0;
            this.gallonsOfPaintField.Text = "0";
            this.gallonsOfPaintField.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gallonsOfPaintLabel
            // 
            this.gallonsOfPaintLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gallonsOfPaintLabel.Location = new System.Drawing.Point(14, 20);
            this.gallonsOfPaintLabel.Name = "gallonsOfPaintLabel";
            this.gallonsOfPaintLabel.Size = new System.Drawing.Size(160, 38);
            this.gallonsOfPaintLabel.TabIndex = 0;
            this.gallonsOfPaintLabel.Text = "Paint (gallons):";
            this.gallonsOfPaintLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.horizontalLine);
            this.mainPanel.Controls.Add(this.exitButton);
            this.mainPanel.Controls.Add(this.pictureBox1);
            this.mainPanel.Controls.Add(this.resetButton);
            this.mainPanel.Controls.Add(this.calculateButton);
            this.mainPanel.Controls.Add(this.surfaceAreaField);
            this.mainPanel.Controls.Add(this.calculatorResultPanel);
            this.mainPanel.Controls.Add(this.surfaceAreaLabel);
            this.mainPanel.Controls.Add(this.paintCostField);
            this.mainPanel.Controls.Add(this.paintCostLabel);
            this.mainPanel.Location = new System.Drawing.Point(12, 12);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(795, 448);
            this.mainPanel.TabIndex = 0;
            // 
            // horizontalLine
            // 
            this.horizontalLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.horizontalLine.Location = new System.Drawing.Point(23, 411);
            this.horizontalLine.Name = "horizontalLine";
            this.horizontalLine.Size = new System.Drawing.Size(577, 2);
            this.horizontalLine.TabIndex = 0;
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(629, 392);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(148, 41);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::Project2.Properties.Resources.paint_image;
            this.pictureBox1.Location = new System.Drawing.Point(473, 132);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(304, 241);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // resetButton
            // 
            this.resetButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.Location = new System.Drawing.Point(629, 59);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(148, 39);
            this.resetButton.TabIndex = 4;
            this.resetButton.Text = "&Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(473, 59);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(148, 39);
            this.calculateButton.TabIndex = 3;
            this.calculateButton.Text = "&Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // PaintingCostCalculator
            // 
            this.AcceptButton = this.calculateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(826, 478);
            this.Controls.Add(this.mainPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PaintingCostCalculator";
            this.Text = "ABC, Inc. - Paint Cost Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.paintCostField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.surfaceAreaField)).EndInit();
            this.calculatorResultPanel.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label paintCostLabel;
        private System.Windows.Forms.NumericUpDown paintCostField;
        private System.Windows.Forms.Label surfaceAreaLabel;
        private System.Windows.Forms.NumericUpDown surfaceAreaField;
        private System.Windows.Forms.Panel calculatorResultPanel;
        private System.Windows.Forms.Label gallonsOfPaintLabel;
        private System.Windows.Forms.Label gallonsOfPaintField;
        private System.Windows.Forms.Label laborHoursField;
        private System.Windows.Forms.Label laborHoursLabel;
        private System.Windows.Forms.Label totalPaintCostField;
        private System.Windows.Forms.Label totalPaintCostLabel;
        private System.Windows.Forms.Label totalLaborCostField;
        private System.Windows.Forms.Label totalLaborCostLabel;
        private System.Windows.Forms.Label totalCostField;
        private System.Windows.Forms.Label totalCostLabel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label horizontalLine;
    }
}

