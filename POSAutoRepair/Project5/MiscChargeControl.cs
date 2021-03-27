using System;
using System.Windows.Forms;

namespace Project5
{
    /// <summary>
    /// UserControl for the standard misc service charges.
    /// </summary>
    public partial class MiscChargeControl : UserControl, POSCharge 
    {
        /// <summary>
        /// EventHandler for when misc charges change.
        /// </summary>
        private EventHandler onChargesChanged;

        /// <summary>
        /// Default Constructor
        /// </summary>
        public MiscChargeControl()
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
        /// Gets the inspection charge
        /// 
        /// Note: The fee value is stored in the Control.Tag property.
        /// 
        /// </summary>
        public double InspectionCharge
        {
            get => this.inspectionField.Checked ? Double.Parse(this.inspectionField.Tag.ToString()) : 0.0;
        }

        /// <summary>
        /// Clears (unchecks) the inspection charge.
        /// </summary>
        public void ClearInspectionCharge()
        {
            this.inspectionField.Checked = false;
        }

        /// <summary>
        /// Gets the oil muffler replacement charge
        /// 
        /// Note: The fee value is stored in the Control.Tag property.
        /// 
        /// </summary>
        public double MufflerReplacementCharge
        {
            get => this.mufflerReplacementField.Checked ? Double.Parse(this.mufflerReplacementField.Tag.ToString()) : 0.0;
        }

        /// <summary>
        /// Clears (unchecks) the muffler replacement charge.
        /// </summary>
        public void ClearMufflerReplacementCharge()
        {
            this.mufflerReplacementField.Checked = false;
        }

        /// <summary>
        /// Gets the tire rotation charge
        /// 
        /// Note: The fee value is stored in the Control.Tag property.
        /// 
        /// </summary>
        public double TireRotationCharge
        {
            get => this.tireRotationField.Checked ? Double.Parse(this.tireRotationField.Tag.ToString()) : 0.0;
        }

        /// <summary>
        /// Clears (unchecks) the tire rotation charge.
        /// </summary>
        public void ClearTireRotationCharge()
        {
            this.tireRotationField.Checked = false;
        }

        /// <summary>
        /// Gets the total oil lube charges
        /// </summary>
        public double Charge
        {
            get => this.InspectionCharge + this.MufflerReplacementCharge + this.TireRotationCharge;
        }

        /// <summary>
        /// Gets the total misc charges
        /// </summary>
        public void ClearCharge()
        {
            this.ClearInspectionCharge();
            this.ClearMufflerReplacementCharge();
            this.ClearTireRotationCharge();
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
