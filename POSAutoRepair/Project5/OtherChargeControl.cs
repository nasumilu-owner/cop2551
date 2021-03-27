using System;
using System.Windows.Forms;

namespace Project5
{
    /// <summary>
    /// UserControl for the standard other service charges.
    /// </summary>
    public partial class OtherChargeControl : UserControl, POSCharge
    {
        /// <summary>
        /// EventHandler for when misc charges change.
        /// </summary>
        private EventHandler onChargesChanged;

        /// <summary>
        /// Default Constructor
        /// </summary>
        public OtherChargeControl()
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
        /// Checks to see if the user inputed at least a service name and either or both labor hours 
        /// or parts.
        /// </summary>
        private bool IsValid
        {
            get
            {
                if(this.serviceField.Text == String.Empty)
                {
                    return false;
                }

                if(this.laborHoursField.Text == String.Empty && this.partsCostField.Text == String.Empty)
                {
                    return false;
                }


                if(this.laborHoursField.Text != String.Empty && !Double.TryParse(this.laborHoursField.Text, out double hours))
                {
                    return false;
                }

                if(this.partsCostField.Text != String.Empty && !Double.TryParse(this.partsCostField.Text, out double parts))
                {
                    return false;
                }
                return true;
            }
        }

        /// <summary>
        /// Gets the total other charges
        /// </summary>
        public double Charge
        {
            get
            {
                double totalCharges = 0.0;
                foreach(OtherPOSCharge charge in this.otherChargesListBox.Items )
                {
                    totalCharges += charge.Charge;
                }
                return totalCharges;
            }
        }

        /// <summary>
        /// Gets the total other charges
        /// </summary>
        public void ClearCharge()
        {
            this.otherChargesListBox.Items.Clear();
            this.onChargesChanged?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Clears the service field
        /// </summary>
        protected void Clear()
        {
            this.serviceField.Text = String.Empty;
            this.laborHoursField.Text = String.Empty;
            this.partsCostField.Text = String.Empty;
        }

        /// <summary>
        /// Adds a service to the list and dispatches an OnChargesChange event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddService_Clicked(object sender, EventArgs e)
        {
            if(this.IsValid)
            {
                OtherPOSCharge charge = new OtherPOSCharge(this.serviceField.Text,
                    this.laborHoursField.Text != String.Empty ? Double.Parse(this.laborHoursField.Text) * Double.Parse(this.laborHoursField.Tag.ToString()) : 0.0,
                    this.partsCostField.Text != String.Empty ? Double.Parse(this.partsCostField.Text) : 0.0);
                this.otherChargesListBox.Items.Add(charge);
                onChargesChanged?.Invoke(this, e);
                this.Clear();
            } else
            {
                MessageBox.Show("Please enter a service name and either or both labor hours or parts cost!", "Other Service Cost Invalid", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Gets the parts charges for all other services
        /// </summary>
        public double PartsCharge
        {
            get
            {
                double partsCharge = 0.0;
                foreach (OtherPOSCharge charge in this.otherChargesListBox.Items)
                {
                    partsCharge += charge.PartsCharge;
                }
                return partsCharge;
            }
        }

        /// <summary>
        /// Gets the labor charges for all other service
        /// </summary>
        public double LaborCharge
        {
            get
            {
                double laborCharge = 0.0;
                foreach(OtherPOSCharge charge in this.otherChargesListBox.Items)
                {
                    laborCharge += charge.LaborCharge;
                }
                return laborCharge;
            }
        }

        /// <summary>
        /// Calculates the tax on the part only for all other services. 
        /// </summary>
        /// <param name="rate"></param>
        /// <returns></returns>
        public double Tax(double rate)
        {
            return rate * this.PartsCharge;
        }

        /// <summary>
        /// EventHandler for when an service is (un)selected to enable/disable the remove button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ServiceCharge_Selected(object sender, EventArgs e)
        {
            this.removeServiceButton.Enabled = (-1 != this.otherChargesListBox.SelectedIndex);
        }

        /// <summary>
        /// Removes a service to the list and dispatches an OnChargesChange event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveCharge_Clicked(object sender, EventArgs e)
        {
            Object item = this.otherChargesListBox.SelectedItem;
            if(null != item)
            {
                this.otherChargesListBox.Items.Remove(item);
                onChargesChanged?.Invoke(this, EventArgs.Empty);
            }
        }
    }

}
