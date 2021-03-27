namespace Project5
{
    partial class MiscChargeControl
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
            this.miscChargeGroupBox = new System.Windows.Forms.GroupBox();
            this.tireRotationField = new System.Windows.Forms.CheckBox();
            this.mufflerReplacementField = new System.Windows.Forms.CheckBox();
            this.inspectionField = new System.Windows.Forms.CheckBox();
            this.miscChargeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // miscChargeGroupBox
            // 
            this.miscChargeGroupBox.Controls.Add(this.tireRotationField);
            this.miscChargeGroupBox.Controls.Add(this.mufflerReplacementField);
            this.miscChargeGroupBox.Controls.Add(this.inspectionField);
            this.miscChargeGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.miscChargeGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miscChargeGroupBox.Location = new System.Drawing.Point(0, 0);
            this.miscChargeGroupBox.Name = "miscChargeGroupBox";
            this.miscChargeGroupBox.Size = new System.Drawing.Size(251, 96);
            this.miscChargeGroupBox.TabIndex = 0;
            this.miscChargeGroupBox.TabStop = false;
            this.miscChargeGroupBox.Text = "Misc. Charges";
            // 
            // tireRotationField
            // 
            this.tireRotationField.AutoSize = true;
            this.tireRotationField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tireRotationField.Location = new System.Drawing.Point(6, 66);
            this.tireRotationField.Name = "tireRotationField";
            this.tireRotationField.Size = new System.Drawing.Size(153, 20);
            this.tireRotationField.TabIndex = 2;
            this.tireRotationField.Tag = "20.00";
            this.tireRotationField.Text = "Tire Rotation ($20.00)";
            this.tireRotationField.UseVisualStyleBackColor = true;
            this.tireRotationField.CheckedChanged += new System.EventHandler(this.ServiceCharge_Checked);
            // 
            // mufflerReplacementField
            // 
            this.mufflerReplacementField.AutoSize = true;
            this.mufflerReplacementField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mufflerReplacementField.Location = new System.Drawing.Point(6, 43);
            this.mufflerReplacementField.Name = "mufflerReplacementField";
            this.mufflerReplacementField.Size = new System.Drawing.Size(206, 20);
            this.mufflerReplacementField.TabIndex = 1;
            this.mufflerReplacementField.Tag = "100.00";
            this.mufflerReplacementField.Text = "Muffler Replacement ($100.00)";
            this.mufflerReplacementField.UseVisualStyleBackColor = true;
            this.mufflerReplacementField.CheckedChanged += new System.EventHandler(this.ServiceCharge_Checked);
            // 
            // inspectionField
            // 
            this.inspectionField.AutoSize = true;
            this.inspectionField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inspectionField.Location = new System.Drawing.Point(6, 20);
            this.inspectionField.Name = "inspectionField";
            this.inspectionField.Size = new System.Drawing.Size(137, 20);
            this.inspectionField.TabIndex = 0;
            this.inspectionField.Tag = "15.00";
            this.inspectionField.Text = "Inspection ($15.00)";
            this.inspectionField.UseVisualStyleBackColor = true;
            this.inspectionField.CheckedChanged += new System.EventHandler(this.ServiceCharge_Checked);
            // 
            // MiscChargeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.miscChargeGroupBox);
            this.Name = "MiscChargeControl";
            this.Size = new System.Drawing.Size(251, 96);
            this.miscChargeGroupBox.ResumeLayout(false);
            this.miscChargeGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox miscChargeGroupBox;
        private System.Windows.Forms.CheckBox tireRotationField;
        private System.Windows.Forms.CheckBox mufflerReplacementField;
        private System.Windows.Forms.CheckBox inspectionField;
    }
}
