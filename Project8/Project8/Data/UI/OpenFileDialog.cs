using System;
using System.Windows.Forms;

namespace Project8.Data.UI
{
    /// <summary>
    /// Custom dialog to obtain a IStudentDataProvider
    /// </summary>
    public partial class OpenFileDialog : Form, IStudentDataProviderFactory
    {

        private IStudentDataProvider _provider;

        /// <summary>
        /// Constrcuts a custom dialog to obtian the student data file path 
        /// and buffer size.
        /// </summary>
        public OpenFileDialog()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Getter/Setter for the IStudentDataProviderFactory.DataProvider
        /// </summary>
        public IStudentDataProvider DataProvider {
            get => this._provider;
            set => this._provider = value;
        }

        /// <summary>
        /// Opens the file dialog to naviage to an existing file path
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FindButton_Click(object sender, EventArgs e)
        {
            if (this.dialog.ShowDialog() == DialogResult.OK)
            {
                this.fileField.Text = this.dialog.FileName;
            }
        }

        /// <summary>
        /// EventHandler for when the open button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenButton_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(this.bufferSizeField.Text, out int buffer)
                && buffer <= 0)
            {
                MessageBox.Show($"Buffer size must be an integer and greter than zero, found {this.bufferSizeField.Text} ",
                    "Buffer Size", 
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if(this.fileField.Text == String.Empty)
            {
                MessageBox.Show("The data path can not be blank!", "File Path", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.DataProvider = new Student(this.fileField.Text, buffer);
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
    }
}
