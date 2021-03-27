using System;
using System.Windows.Forms;

namespace Project5
{
    public partial class PosLube : Form
    {
   
        public PosLube()
        {
            InitializeComponent();
        }

        public double OilLubeCharges
        {
            get => this.lubeChargeControl.Charge;
        }

        public void ClearOilLube()
        {
            this.lubeChargeControl.ClearCharge();
        }

        public double FlushCharges
        {
            get
            {
                return this.flushChargeControl.Charge;
            }
        }

        public void ClearFlushes()
        {
            this.flushChargeControl.ClearCharge();
        }

        public double MiscCharges
        {
            get
            {
                return this.miscChargeControl.Charge;
            }
        }

        public void ClearMisc()
        {
            this.miscChargeControl.ClearCharge();
        }

        public double OtherCharges
        {
            get
            {
                return this.otherChargeControl.Charge;
            }
        }

        public void ClearOther()
        {
            this.otherChargeControl.ClearCharge();
        }


        public double LaborServiceCharges
        {
            get
            {
                return this.OilLubeCharges + this.FlushCharges + this.MiscCharges + this.otherChargeControl.LaborCharge;
            }
        }

        public double PartsCharges
        {
            get => this.otherChargeControl.PartsCharge;
        }

        public double TaxCharges
        {
            get => this.otherChargeControl.Tax(0.06);
        }

        public double TotalCharges
        {
            get => this.LaborServiceCharges + this.PartsCharges + this.TaxCharges;
        }

        public void ClearFees()
        {
            this.ClearOilLube();
            this.ClearFlushes();
            this.ClearMisc();
            this.ClearOther();
        }

        private void Service_ChargeChanged(object sender, EventArgs e)
        {
            this.serviceLaborChargeField.Text = this.LaborServiceCharges.ToString("C2");
            this.partsChargeField.Text = this.PartsCharges.ToString("C2");
            this.taxField.Text = this.TaxCharges.ToString("C2");
            this.totalField.Text = this.TotalCharges.ToString("C2");
        }

        private void ClearButton_Clicked(object sender, EventArgs e)
        {
            this.ClearFees();
            this.lubeChargeControl.Select();
        }

        /// <summary>
        /// Sets the focus on the oil change checkbox on load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PosLube_Load(object sender, EventArgs e)
        {
            this.ClearButton_Clicked(sender, e);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
