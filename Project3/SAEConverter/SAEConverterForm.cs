using System;
using System.Windows.Forms;

namespace SAEConverter
{
    public partial class SAEConverterForm : Form
    {
        public SAEConverterForm()
        {
            InitializeComponent();
            // Set the two convert from & to list boxes data sources
            // ListBox datasources is an SAEUnint[]
            this.convertValueFromList.DataSource = Enum.GetValues(typeof(SAEUnit));
            this.convertValueToList.DataSource = Enum.GetValues(typeof(SAEUnit));
            this.valueToConvertField.Focus(); //Set the focus on the input text box
        }

        /// <summary>
        /// Convert button click handler.
        /// 
        /// 1. Trys to Parse the textbox input
        ///     a. Fails to parse the input
        ///         - selects all of the textbox input
        ///         - sets focus on textbox
        ///         - shows tooltip with error message (Kinda works the ballon style is wonkey
        ///         - abandons all hope (return;)
        /// 2. Hides tooltip in case it is still showing
        /// 3. Gets the convertFrom & convertTo Units
        /// 4. Updates the formula field with the necessary formula and converted value.
        /// 
        /// The logic is found in the SAEUnitExtension class.
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConvertButton_Click(object sender, EventArgs e)
        {

            if (!Double.TryParse(this.valueToConvertField.Text, out double inputValue))
            {
                this.valueToConvertField.SelectAll();
                this.valueToConvertField.Focus();
                toolTip.Show(String.Empty, this.valueToConvertField, 0);
                toolTip.Show("Value must be numeric!", this.valueToConvertField, this.valueToConvertField.Width/2, this.valueToConvertField.Height/2, 5000);
                return;
            } 
            toolTip.Hide(this.valueToConvertField);
            SAEUnit convertFromUnit = (SAEUnit)this.convertValueFromList.SelectedItem;
            SAEUnit convertToUnit = (SAEUnit)this.convertValueToList.SelectedItem;
            this.formulaField.Text = $"{inputValue:N} " +
                $"{convertFromUnit} " +
                $"{convertFromUnit.Operation(convertToUnit)} " +
                $"{convertFromUnit.Factor(convertToUnit)} = " +
                $"{convertFromUnit.Convert(convertToUnit, inputValue):N2} " +
                $"{convertToUnit}";
        }

        /// <summary>
        /// 1. Clears the input textbox
        /// 2. Sets the convertFrom & convertTo listboxes to the first item
        /// 3. Clears the formula field 
        /// 4. Sets the focus back to the inptu text box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearButton_Click(object sender, EventArgs e)
        {
            this.valueToConvertField.Text = String.Empty;
            this.convertValueFromList.SelectedIndex = 0;
            this.convertValueToList.SelectedIndex = 0;
            this.formulaField.Text = String.Empty;
            this.valueToConvertField.Focus();
        }

        /// <summary>
        /// Exits the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
