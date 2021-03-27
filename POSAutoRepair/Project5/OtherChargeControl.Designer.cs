namespace Project5
{
    partial class OtherChargeControl
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
            this.otherChargeGroupBox = new System.Windows.Forms.GroupBox();
            this.removeServiceButton = new System.Windows.Forms.Button();
            this.otherChargesListBox = new System.Windows.Forms.ListBox();
            this.addServiceButton = new System.Windows.Forms.Button();
            this.serviceField = new System.Windows.Forms.TextBox();
            this.serviceLabel = new System.Windows.Forms.Label();
            this.partsCostField = new System.Windows.Forms.TextBox();
            this.laborHoursField = new System.Windows.Forms.TextBox();
            this.partCostLabel = new System.Windows.Forms.Label();
            this.laborHoursLabel = new System.Windows.Forms.Label();
            this.otherChargeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // otherChargeGroupBox
            // 
            this.otherChargeGroupBox.Controls.Add(this.removeServiceButton);
            this.otherChargeGroupBox.Controls.Add(this.otherChargesListBox);
            this.otherChargeGroupBox.Controls.Add(this.addServiceButton);
            this.otherChargeGroupBox.Controls.Add(this.serviceField);
            this.otherChargeGroupBox.Controls.Add(this.serviceLabel);
            this.otherChargeGroupBox.Controls.Add(this.partsCostField);
            this.otherChargeGroupBox.Controls.Add(this.laborHoursField);
            this.otherChargeGroupBox.Controls.Add(this.partCostLabel);
            this.otherChargeGroupBox.Controls.Add(this.laborHoursLabel);
            this.otherChargeGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.otherChargeGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otherChargeGroupBox.Location = new System.Drawing.Point(0, 0);
            this.otherChargeGroupBox.Name = "otherChargeGroupBox";
            this.otherChargeGroupBox.Size = new System.Drawing.Size(350, 314);
            this.otherChargeGroupBox.TabIndex = 0;
            this.otherChargeGroupBox.TabStop = false;
            this.otherChargeGroupBox.Text = "Other Charges";
            // 
            // removeServiceButton
            // 
            this.removeServiceButton.Enabled = false;
            this.removeServiceButton.Location = new System.Drawing.Point(10, 272);
            this.removeServiceButton.Name = "removeServiceButton";
            this.removeServiceButton.Size = new System.Drawing.Size(329, 36);
            this.removeServiceButton.TabIndex = 2;
            this.removeServiceButton.TabStop = false;
            this.removeServiceButton.Text = "Remove Service";
            this.removeServiceButton.UseVisualStyleBackColor = true;
            this.removeServiceButton.Click += new System.EventHandler(this.RemoveCharge_Clicked);
            // 
            // otherChargesListBox
            // 
            this.otherChargesListBox.FormattingEnabled = true;
            this.otherChargesListBox.HorizontalScrollbar = true;
            this.otherChargesListBox.ItemHeight = 16;
            this.otherChargesListBox.Location = new System.Drawing.Point(10, 102);
            this.otherChargesListBox.Name = "otherChargesListBox";
            this.otherChargesListBox.Size = new System.Drawing.Size(329, 164);
            this.otherChargesListBox.TabIndex = 0;
            this.otherChargesListBox.TabStop = false;
            this.otherChargesListBox.SelectedValueChanged += new System.EventHandler(this.ServiceCharge_Selected);
            // 
            // addServiceButton
            // 
            this.addServiceButton.Location = new System.Drawing.Point(253, 46);
            this.addServiceButton.Name = "addServiceButton";
            this.addServiceButton.Size = new System.Drawing.Size(87, 49);
            this.addServiceButton.TabIndex = 3;
            this.addServiceButton.Text = "&Add Service";
            this.addServiceButton.UseVisualStyleBackColor = true;
            this.addServiceButton.Click += new System.EventHandler(this.AddService_Clicked);
            // 
            // serviceField
            // 
            this.serviceField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceField.Location = new System.Drawing.Point(85, 18);
            this.serviceField.Name = "serviceField";
            this.serviceField.Size = new System.Drawing.Size(256, 22);
            this.serviceField.TabIndex = 0;
            this.serviceField.Tag = "20.00";
            // 
            // serviceLabel
            // 
            this.serviceLabel.AutoSize = true;
            this.serviceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceLabel.Location = new System.Drawing.Point(7, 21);
            this.serviceLabel.Name = "serviceLabel";
            this.serviceLabel.Size = new System.Drawing.Size(54, 16);
            this.serviceLabel.TabIndex = 4;
            this.serviceLabel.Tag = "";
            this.serviceLabel.Text = "Service";
            // 
            // partsCostField
            // 
            this.partsCostField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partsCostField.Location = new System.Drawing.Point(85, 74);
            this.partsCostField.Name = "partsCostField";
            this.partsCostField.Size = new System.Drawing.Size(155, 22);
            this.partsCostField.TabIndex = 2;
            // 
            // laborHoursField
            // 
            this.laborHoursField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laborHoursField.Location = new System.Drawing.Point(85, 46);
            this.laborHoursField.Name = "laborHoursField";
            this.laborHoursField.Size = new System.Drawing.Size(155, 22);
            this.laborHoursField.TabIndex = 1;
            this.laborHoursField.Tag = "20.00";
            // 
            // partCostLabel
            // 
            this.partCostLabel.AutoSize = true;
            this.partCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partCostLabel.Location = new System.Drawing.Point(7, 78);
            this.partCostLabel.Name = "partCostLabel";
            this.partCostLabel.Size = new System.Drawing.Size(62, 16);
            this.partCostLabel.TabIndex = 1;
            this.partCostLabel.Text = "Part Cost";
            // 
            // laborHoursLabel
            // 
            this.laborHoursLabel.AutoSize = true;
            this.laborHoursLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laborHoursLabel.Location = new System.Drawing.Point(7, 49);
            this.laborHoursLabel.Name = "laborHoursLabel";
            this.laborHoursLabel.Size = new System.Drawing.Size(72, 16);
            this.laborHoursLabel.TabIndex = 0;
            this.laborHoursLabel.Tag = "";
            this.laborHoursLabel.Text = "Labor (hrs)";
            // 
            // OtherChargeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.otherChargeGroupBox);
            this.Name = "OtherChargeControl";
            this.Size = new System.Drawing.Size(350, 314);
            this.otherChargeGroupBox.ResumeLayout(false);
            this.otherChargeGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox otherChargeGroupBox;
        private System.Windows.Forms.TextBox partsCostField;
        private System.Windows.Forms.TextBox laborHoursField;
        private System.Windows.Forms.Label partCostLabel;
        private System.Windows.Forms.Label laborHoursLabel;
        private System.Windows.Forms.Button addServiceButton;
        private System.Windows.Forms.TextBox serviceField;
        private System.Windows.Forms.Label serviceLabel;
        private System.Windows.Forms.ListBox otherChargesListBox;
        private System.Windows.Forms.Button removeServiceButton;
    }
}
