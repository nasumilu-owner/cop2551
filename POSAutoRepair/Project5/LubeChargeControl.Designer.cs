namespace Project5
{
    partial class LubeChargeControl
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
            this.lubeChargeGroupBox = new System.Windows.Forms.GroupBox();
            this.lubeJobField = new System.Windows.Forms.CheckBox();
            this.oilChangeField = new System.Windows.Forms.CheckBox();
            this.lubeChargeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lubeChargeGroupBox
            // 
            this.lubeChargeGroupBox.Controls.Add(this.lubeJobField);
            this.lubeChargeGroupBox.Controls.Add(this.oilChangeField);
            this.lubeChargeGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lubeChargeGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lubeChargeGroupBox.Location = new System.Drawing.Point(0, 0);
            this.lubeChargeGroupBox.Name = "lubeChargeGroupBox";
            this.lubeChargeGroupBox.Size = new System.Drawing.Size(154, 73);
            this.lubeChargeGroupBox.TabIndex = 0;
            this.lubeChargeGroupBox.TabStop = false;
            this.lubeChargeGroupBox.Text = "Lube Charges";
            // 
            // lubeJobField
            // 
            this.lubeJobField.AutoSize = true;
            this.lubeJobField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lubeJobField.Location = new System.Drawing.Point(6, 42);
            this.lubeJobField.Name = "lubeJobField";
            this.lubeJobField.Size = new System.Drawing.Size(132, 20);
            this.lubeJobField.TabIndex = 1;
            this.lubeJobField.Tag = "18.00";
            this.lubeJobField.Text = "Lube Job ($18.00)";
            this.lubeJobField.UseVisualStyleBackColor = true;
            this.lubeJobField.CheckedChanged += new System.EventHandler(this.ServiceCharge_Checked);
            // 
            // oilChangeField
            // 
            this.oilChangeField.AutoSize = true;
            this.oilChangeField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oilChangeField.Location = new System.Drawing.Point(6, 19);
            this.oilChangeField.Name = "oilChangeField";
            this.oilChangeField.Size = new System.Drawing.Size(142, 20);
            this.oilChangeField.TabIndex = 0;
            this.oilChangeField.Tag = "26.00";
            this.oilChangeField.Text = "Oil Change ($26.00)";
            this.oilChangeField.UseVisualStyleBackColor = true;
            this.oilChangeField.CheckedChanged += new System.EventHandler(this.ServiceCharge_Checked);
            // 
            // LubeChargeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lubeChargeGroupBox);
            this.Name = "LubeChargeControl";
            this.Size = new System.Drawing.Size(154, 73);
            this.lubeChargeGroupBox.ResumeLayout(false);
            this.lubeChargeGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox lubeChargeGroupBox;
        private System.Windows.Forms.CheckBox lubeJobField;
        private System.Windows.Forms.CheckBox oilChangeField;
    }
}
