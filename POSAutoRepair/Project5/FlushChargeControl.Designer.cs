namespace Project5
{
    partial class FlushChargeControl
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
            this.flushChargeGroupBox = new System.Windows.Forms.GroupBox();
            this.transmissionFlushField = new System.Windows.Forms.CheckBox();
            this.radiatorFlushField = new System.Windows.Forms.CheckBox();
            this.flushChargeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // flushChargeGroupBox
            // 
            this.flushChargeGroupBox.Controls.Add(this.transmissionFlushField);
            this.flushChargeGroupBox.Controls.Add(this.radiatorFlushField);
            this.flushChargeGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flushChargeGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flushChargeGroupBox.Location = new System.Drawing.Point(0, 0);
            this.flushChargeGroupBox.Name = "flushChargeGroupBox";
            this.flushChargeGroupBox.Size = new System.Drawing.Size(216, 74);
            this.flushChargeGroupBox.TabIndex = 0;
            this.flushChargeGroupBox.TabStop = false;
            this.flushChargeGroupBox.Text = "Flush Charges";
            // 
            // transmissionFlushField
            // 
            this.transmissionFlushField.AutoSize = true;
            this.transmissionFlushField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transmissionFlushField.Location = new System.Drawing.Point(6, 44);
            this.transmissionFlushField.Name = "transmissionFlushField";
            this.transmissionFlushField.Size = new System.Drawing.Size(192, 20);
            this.transmissionFlushField.TabIndex = 1;
            this.transmissionFlushField.Tag = "80.00";
            this.transmissionFlushField.Text = "Transmission Flush ($80.00)";
            this.transmissionFlushField.UseVisualStyleBackColor = true;
            this.transmissionFlushField.CheckedChanged += new System.EventHandler(this.ServiceCharge_Checked);
            // 
            // radiatorFlushField
            // 
            this.radiatorFlushField.AutoSize = true;
            this.radiatorFlushField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiatorFlushField.Location = new System.Drawing.Point(6, 21);
            this.radiatorFlushField.Name = "radiatorFlushField";
            this.radiatorFlushField.Size = new System.Drawing.Size(163, 20);
            this.radiatorFlushField.TabIndex = 0;
            this.radiatorFlushField.Tag = "30.00";
            this.radiatorFlushField.Text = "Radiator Flush ($30.00)";
            this.radiatorFlushField.UseVisualStyleBackColor = true;
            this.radiatorFlushField.CheckedChanged += new System.EventHandler(this.ServiceCharge_Checked);
            // 
            // FlushChargeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flushChargeGroupBox);
            this.Name = "FlushChargeControl";
            this.Size = new System.Drawing.Size(216, 74);
            this.flushChargeGroupBox.ResumeLayout(false);
            this.flushChargeGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox flushChargeGroupBox;
        private System.Windows.Forms.CheckBox transmissionFlushField;
        private System.Windows.Forms.CheckBox radiatorFlushField;
    }
}
