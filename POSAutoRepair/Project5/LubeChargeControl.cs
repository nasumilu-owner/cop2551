using System;
using System.Windows.Forms;

namespace Project5
{
    /// <summary>
    /// UserControl for the standard lube service charges.
    /// </summary>
    public partial class LubeChargeControl : UserControl, POSCharge
    {

        /// <summary>
        /// EventHandler for when lube charges change.
        /// </summary>
        private EventHandler onChargesChanged;

        /// <summary>
        /// Default Constructor
        /// </summary>
        public LubeChargeControl()
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
        /// Clears (unchecks) the oil change charge.
        /// </summary>
        public void ClearOilChangeCharge()
        {
            this.oilChangeField.Checked = false;
        }


        /// <summary>
        /// Clears (unchecks) the lube job charge.
        /// </summary>
        public void ClearLubeJobCharge()
        {
            this.lubeJobField.Checked = false;
        }


        /// <summary>
        /// Clears (unchecks) the oil lube charges.
        /// </summary>
        public void ClearCharge()
        {
            this.ClearLubeJobCharge();
            this.ClearOilChangeCharge();
        }

        /// <summary>
        /// Gets the oil change charge
        /// 
        /// Note: The fee value is stored in the Control.Tag property.
        /// 
        /// </summary>
        public double OilChangeCharge
        {
            get => oilChangeField.Checked ? Double.Parse(oilChangeField.Tag.ToString()) : 0.0;
        }

        /// <summary>
        /// Gets the lube job charge
        /// 
        /// Note: The fee value is stored in the Control.Tag property.
        /// 
        /// </summary>
        public double LubeJobCharge
        {
            get => lubeJobField.Checked ? Double.Parse(lubeJobField.Tag.ToString()) : 0.0;
        }

        /// <summary>
        /// Gets the total oil lube charges
        /// </summary>
        public double Charge => this.OilChangeCharge + this.LubeJobCharge;

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

