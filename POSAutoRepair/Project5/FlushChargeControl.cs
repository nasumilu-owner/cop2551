using System;
using System.Windows.Forms;

namespace Project5
{
    /// <summary>
    /// UserControl for the standard flush service charges.
    /// </summary>
    public partial class FlushChargeControl : UserControl, POSCharge
    {
        /// <summary>
        /// EventHandler for when flush charges change.
        /// </summary>
        private EventHandler onChargesChanged;

        /// <summary>
        /// Default Constructor
        /// </summary>
        public FlushChargeControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Add/Remove EventHandler for handling charge changes. 
        /// </summary>
        public event EventHandler OnChargesChanged
        {
            add => onChargesChanged += value;
            remove => onChargesChanged -= value;
        }

        /// <summary>
        /// Gets the transmission flush charge.
        /// 
        /// Note: The fee is stored in the Control.Tag property
        /// 
        /// </summary>
        public double TransmissionFlushCharge
        {
            get => this.transmissionFlushField.Checked ? Double.Parse(this.transmissionFlushField.Tag.ToString()) : 0.0;
        }

        /// <summary>
        /// Clears (unchecks) the transmission flush charge.
        /// </summary>
        public void ClearTransmissionFlushCharge()
        {
            this.transmissionFlushField.Checked = false;
        }

        /// <summary>
        /// Gets the radiator flush charge
        /// 
        /// Note: The fee value is stored in the Control.Tag property.
        /// 
        /// </summary>
        public double RadiatorFlushCharge
        {
            get => this.radiatorFlushField.Checked ? Double.Parse(this.radiatorFlushField.Tag.ToString()) : 0.0;
        }

        /// <summary>
        /// Clears (unchecks) the transmission flush charge.
        /// </summary>
        public void ClearRadiatorFlushCharge()
        {
            this.radiatorFlushField.Checked = false;
        }

        /// <summary>
        /// Gets the total flush charges
        /// </summary>
        public double Charge
        {
            get => this.TransmissionFlushCharge + this.RadiatorFlushCharge;
        }

        /// <summary>
        /// Clears (unchecks) all flush charges.
        /// </summary>
        public void ClearCharge()
        {
            this.ClearTransmissionFlushCharge();
            this.ClearRadiatorFlushCharge();
        }

        /// <summary>
        /// EventHandler for when the user (un)checks on of the standard service
        /// CheckBox controls. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ServiceCharge_Checked(object sender, EventArgs e)
        {
            onChargesChanged?.Invoke(this, e);
        }
    }
}
