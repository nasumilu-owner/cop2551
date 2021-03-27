namespace Project5
{
    partial class PosLube
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PosLube));
            this.totalLabel = new System.Windows.Forms.Label();
            this.totalField = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.taxField = new System.Windows.Forms.Label();
            this.serviceLaborChargeLabel = new System.Windows.Forms.Label();
            this.serviceLaborChargeField = new System.Windows.Forms.Label();
            this.standardChargesGroupBox = new System.Windows.Forms.GroupBox();
            this.miscChargeControl = new Project5.MiscChargeControl();
            this.flushChargeControl = new Project5.FlushChargeControl();
            this.lubeChargeControl = new Project5.LubeChargeControl();
            this.otherChargeControl = new Project5.OtherChargeControl();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.partsChargeLabel = new System.Windows.Forms.Label();
            this.partsChargeField = new System.Windows.Forms.Label();
            this.standardChargesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // totalLabel
            // 
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(16, 434);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(119, 16);
            this.totalLabel.TabIndex = 7;
            this.totalLabel.Text = "Total";
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // totalField
            // 
            this.totalField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalField.Location = new System.Drawing.Point(165, 434);
            this.totalField.Name = "totalField";
            this.totalField.Size = new System.Drawing.Size(91, 16);
            this.totalField.TabIndex = 8;
            this.totalField.Text = "$0.00";
            this.totalField.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // taxLabel
            // 
            this.taxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxLabel.Location = new System.Drawing.Point(16, 407);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(119, 16);
            this.taxLabel.TabIndex = 17;
            this.taxLabel.Text = "Tax";
            this.taxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // taxField
            // 
            this.taxField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxField.Location = new System.Drawing.Point(165, 407);
            this.taxField.Name = "taxField";
            this.taxField.Size = new System.Drawing.Size(91, 16);
            this.taxField.TabIndex = 18;
            this.taxField.Text = "$0.00";
            this.taxField.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // serviceLaborChargeLabel
            // 
            this.serviceLaborChargeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceLaborChargeLabel.Location = new System.Drawing.Point(15, 358);
            this.serviceLaborChargeLabel.Name = "serviceLaborChargeLabel";
            this.serviceLaborChargeLabel.Size = new System.Drawing.Size(119, 16);
            this.serviceLaborChargeLabel.TabIndex = 19;
            this.serviceLaborChargeLabel.Text = "Service && Labor";
            this.serviceLaborChargeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // serviceLaborChargeField
            // 
            this.serviceLaborChargeField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceLaborChargeField.Location = new System.Drawing.Point(165, 358);
            this.serviceLaborChargeField.Name = "serviceLaborChargeField";
            this.serviceLaborChargeField.Size = new System.Drawing.Size(91, 16);
            this.serviceLaborChargeField.TabIndex = 20;
            this.serviceLaborChargeField.Text = "$0.00";
            this.serviceLaborChargeField.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // standardChargesGroupBox
            // 
            this.standardChargesGroupBox.Controls.Add(this.miscChargeControl);
            this.standardChargesGroupBox.Controls.Add(this.flushChargeControl);
            this.standardChargesGroupBox.Controls.Add(this.lubeChargeControl);
            this.standardChargesGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.standardChargesGroupBox.Location = new System.Drawing.Point(12, 12);
            this.standardChargesGroupBox.Name = "standardChargesGroupBox";
            this.standardChargesGroupBox.Size = new System.Drawing.Size(244, 333);
            this.standardChargesGroupBox.TabIndex = 21;
            this.standardChargesGroupBox.TabStop = false;
            this.standardChargesGroupBox.Text = "Standard Charges";
            // 
            // miscChargeControl
            // 
            this.miscChargeControl.Location = new System.Drawing.Point(6, 205);
            this.miscChargeControl.Margin = new System.Windows.Forms.Padding(4);
            this.miscChargeControl.Name = "miscChargeControl";
            this.miscChargeControl.Size = new System.Drawing.Size(221, 116);
            this.miscChargeControl.TabIndex = 2;
            this.miscChargeControl.OnChargesChanged += new System.EventHandler(this.Service_ChargeChanged);
            // 
            // flushChargeControl
            // 
            this.flushChargeControl.Location = new System.Drawing.Point(6, 113);
            this.flushChargeControl.Margin = new System.Windows.Forms.Padding(4);
            this.flushChargeControl.Name = "flushChargeControl";
            this.flushChargeControl.Size = new System.Drawing.Size(221, 85);
            this.flushChargeControl.TabIndex = 1;
            this.flushChargeControl.OnChargesChanged += new System.EventHandler(this.Service_ChargeChanged);
            // 
            // lubeChargeControl
            // 
            this.lubeChargeControl.Location = new System.Drawing.Point(7, 21);
            this.lubeChargeControl.Margin = new System.Windows.Forms.Padding(4);
            this.lubeChargeControl.Name = "lubeChargeControl";
            this.lubeChargeControl.Size = new System.Drawing.Size(221, 84);
            this.lubeChargeControl.TabIndex = 0;
            this.lubeChargeControl.OnChargesChanged += new System.EventHandler(this.Service_ChargeChanged);
            // 
            // otherChargeControl
            // 
            this.otherChargeControl.Location = new System.Drawing.Point(273, 12);
            this.otherChargeControl.Name = "otherChargeControl";
            this.otherChargeControl.Size = new System.Drawing.Size(362, 333);
            this.otherChargeControl.TabIndex = 3;
            this.otherChargeControl.OnChargesChanged += new System.EventHandler(this.Service_ChargeChanged);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(528, 351);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(107, 30);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "C&lear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Clicked);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(528, 420);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(107, 30);
            this.exitButton.TabIndex = 22;
            this.exitButton.TabStop = false;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(262, 351);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // partsChargeLabel
            // 
            this.partsChargeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partsChargeLabel.Location = new System.Drawing.Point(16, 383);
            this.partsChargeLabel.Name = "partsChargeLabel";
            this.partsChargeLabel.Size = new System.Drawing.Size(119, 16);
            this.partsChargeLabel.TabIndex = 24;
            this.partsChargeLabel.Text = "Parts";
            this.partsChargeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // partsChargeField
            // 
            this.partsChargeField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partsChargeField.Location = new System.Drawing.Point(165, 383);
            this.partsChargeField.Name = "partsChargeField";
            this.partsChargeField.Size = new System.Drawing.Size(91, 16);
            this.partsChargeField.TabIndex = 25;
            this.partsChargeField.Text = "$0.00";
            this.partsChargeField.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PosLube
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(650, 463);
            this.Controls.Add(this.partsChargeField);
            this.Controls.Add(this.partsChargeLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.standardChargesGroupBox);
            this.Controls.Add(this.serviceLaborChargeField);
            this.Controls.Add(this.serviceLaborChargeLabel);
            this.Controls.Add(this.taxField);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.otherChargeControl);
            this.Controls.Add(this.totalField);
            this.Controls.Add(this.totalLabel);
            this.Name = "PosLube";
            this.Text = "POS-I-LUBE";
            this.Load += new System.EventHandler(this.PosLube_Load);
            this.standardChargesGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label totalField;
        private LubeChargeControl lubeChargeControl;
        private FlushChargeControl flushChargeControl;
        private MiscChargeControl miscChargeControl;
        private OtherChargeControl otherChargeControl;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label taxField;
        private System.Windows.Forms.Label serviceLaborChargeLabel;
        private System.Windows.Forms.Label serviceLaborChargeField;
        private System.Windows.Forms.GroupBox standardChargesGroupBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label partsChargeLabel;
        private System.Windows.Forms.Label partsChargeField;
    }
}

