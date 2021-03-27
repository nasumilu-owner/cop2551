using System;
using System.Windows.Forms;

namespace Project8.Data.UI
{
    /// <summary>
    /// Custom dialog to obtain a UriStudentDataProvider
    /// </summary>
    public partial class OpenUriDialog : Form, IStudentDataProviderFactory
    {
        /// <summary>
        /// The dialogs UriStudentDataProvider
        /// </summary>
        private IStudentDataProvider provider;

        /// <summary>
        /// Constructs the OpenUriDialog
        /// </summary>
        public OpenUriDialog()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Getter/Setter for the OpenUriDialog
        /// </summary>
        public IStudentDataProvider DataProvider
        {
            get => this.provider;
            set => this.provider = value;
        }

        /// <summary>
        /// EventHandler for when the cancel button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        /// <summary>
        /// EventHandler for when the open button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenButton_Click(object sender, EventArgs e)
        {
            if(this.urlField.Text == String.Empty)
            {
                MessageBox.Show("The url field is emtpy!",
                    "Url", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(!long.TryParse(this.maxByteField.Text, out long bytes)
                || bytes < 10000)
            {
                MessageBox.Show($"Bytes field must be an integer greater or equal to 10,000, found {this.maxByteField.Text}!",
                    "Maximum Bytes Allowed", 
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if(!int.TryParse(this.timeOutField.Text, out int timeout)
                || timeout < 3000)
            {
                MessageBox.Show($"Timeout field must be an integer greater or equal to 3000, found {this.timeOutField.Text}!",
                    "Timeout",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.provider = new UriStudentDataProvider(this.urlField.Text, bytes, timeout);
            this.Close();
        }
    }
}
