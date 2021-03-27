namespace SAEConverter
{
    partial class SAEConverterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SAEConverterForm));
            this.inputValueLabel = new System.Windows.Forms.Label();
            this.valueToConvertField = new System.Windows.Forms.TextBox();
            this.convertFromLabel = new System.Windows.Forms.Label();
            this.converValueToLabel = new System.Windows.Forms.Label();
            this.convertValueFromList = new System.Windows.Forms.ListBox();
            this.convertValueToList = new System.Windows.Forms.ListBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.formulaField = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputValueLabel
            // 
            this.inputValueLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputValueLabel.Location = new System.Drawing.Point(18, 22);
            this.inputValueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.inputValueLabel.Name = "inputValueLabel";
            this.inputValueLabel.Size = new System.Drawing.Size(184, 28);
            this.inputValueLabel.TabIndex = 0;
            this.inputValueLabel.Text = "Value To Convert";
            this.inputValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // valueToConvertField
            // 
            this.valueToConvertField.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueToConvertField.Location = new System.Drawing.Point(226, 22);
            this.valueToConvertField.Margin = new System.Windows.Forms.Padding(4);
            this.valueToConvertField.Name = "valueToConvertField";
            this.valueToConvertField.Size = new System.Drawing.Size(307, 26);
            this.valueToConvertField.TabIndex = 1;
            // 
            // convertFromLabel
            // 
            this.convertFromLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertFromLabel.Location = new System.Drawing.Point(18, 66);
            this.convertFromLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.convertFromLabel.Name = "convertFromLabel";
            this.convertFromLabel.Size = new System.Drawing.Size(184, 77);
            this.convertFromLabel.TabIndex = 0;
            this.convertFromLabel.Text = "Convert Value From";
            this.convertFromLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // converValueToLabel
            // 
            this.converValueToLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.converValueToLabel.Location = new System.Drawing.Point(18, 158);
            this.converValueToLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.converValueToLabel.Name = "converValueToLabel";
            this.converValueToLabel.Size = new System.Drawing.Size(184, 77);
            this.converValueToLabel.TabIndex = 0;
            this.converValueToLabel.Text = "Convert Value From";
            this.converValueToLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // convertValueFromList
            // 
            this.convertValueFromList.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertValueFromList.FormattingEnabled = true;
            this.convertValueFromList.ItemHeight = 18;
            this.convertValueFromList.Location = new System.Drawing.Point(226, 66);
            this.convertValueFromList.Margin = new System.Windows.Forms.Padding(4);
            this.convertValueFromList.Name = "convertValueFromList";
            this.convertValueFromList.Size = new System.Drawing.Size(307, 76);
            this.convertValueFromList.TabIndex = 2;
            // 
            // convertValueToList
            // 
            this.convertValueToList.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertValueToList.FormattingEnabled = true;
            this.convertValueToList.ItemHeight = 18;
            this.convertValueToList.Location = new System.Drawing.Point(226, 158);
            this.convertValueToList.Margin = new System.Windows.Forms.Padding(4);
            this.convertValueToList.Name = "convertValueToList";
            this.convertValueToList.Size = new System.Drawing.Size(307, 76);
            this.convertValueToList.TabIndex = 3;
            // 
            // convertButton
            // 
            this.convertButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertButton.Location = new System.Drawing.Point(588, 22);
            this.convertButton.Margin = new System.Windows.Forms.Padding(4);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(170, 57);
            this.convertButton.TabIndex = 4;
            this.convertButton.Text = "Con&vert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(588, 87);
            this.clearButton.Margin = new System.Windows.Forms.Padding(4);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(170, 57);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "&Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(588, 178);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(170, 57);
            this.exitButton.TabIndex = 0;
            this.exitButton.TabStop = false;
            this.exitButton.Text = "&Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // toolTip
            // 
            this.toolTip.IsBalloon = true;
            this.toolTip.OwnerDraw = true;
            this.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.toolTip.ToolTipTitle = "Invalid Input";
            // 
            // formulaField
            // 
            this.formulaField.BackColor = System.Drawing.Color.Transparent;
            this.formulaField.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.formulaField.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formulaField.ForeColor = System.Drawing.SystemColors.ControlText;
            this.formulaField.Image = ((System.Drawing.Image)(resources.GetObject("formulaField.Image")));
            this.formulaField.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.formulaField.Location = new System.Drawing.Point(18, 265);
            this.formulaField.Margin = new System.Windows.Forms.Padding(0);
            this.formulaField.Name = "formulaField";
            this.formulaField.Size = new System.Drawing.Size(740, 77);
            this.formulaField.TabIndex = 0;
            this.formulaField.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SAEConverterForm
            // 
            this.AcceptButton = this.convertButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(793, 370);
            this.Controls.Add(this.formulaField);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.convertValueToList);
            this.Controls.Add(this.convertValueFromList);
            this.Controls.Add(this.converValueToLabel);
            this.Controls.Add(this.convertFromLabel);
            this.Controls.Add(this.valueToConvertField);
            this.Controls.Add(this.inputValueLabel);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SAEConverterForm";
            this.Text = "SAE Linear Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label inputValueLabel;
        private System.Windows.Forms.TextBox valueToConvertField;
        private System.Windows.Forms.Label convertFromLabel;
        private System.Windows.Forms.Label converValueToLabel;
        private System.Windows.Forms.ListBox convertValueFromList;
        private System.Windows.Forms.ListBox convertValueToList;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label formulaField;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

