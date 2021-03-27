using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Project8.Data;
using Project8.Data.UI;

namespace Project8
{
    /// <summary>
    /// The applications main form.
    /// </summary>
    public partial class MainForm : Form
    {

        /// <summary>
        /// StudentInfo data provider
        /// </summary>
        private IStudentDataProvider studentDataProvider;
        /// <summary>
        /// Custom dialog for getting a UriStudentDataProvider
        /// </summary>
        private readonly IStudentDataProviderFactory uriDialog = new OpenUriDialog();
        /// <summary>
        /// Custom dialg for getting a Student
        /// </summary>
        private readonly IStudentDataProviderFactory openFileDialog = new Data.UI.OpenFileDialog();

        /// <summary>
        /// Init form components and set the inital data provider to 
        /// a text file found in the current working directory. 
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            this.studentDataProvider = new Student("./Names.txt");
        }

        /// <summary>
        /// Sets the student listboxes datasoruce when the form loads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_OnLoad(object sender, EventArgs e)
        {
            try
            {
                this.studentListBox.DataSource = this.studentDataProvider.GetData();
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error loading Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Getter/Setter for the student data provider
        /// </summary>
        public IStudentDataProvider DataProvider
        {
            get => this.studentDataProvider;
            set
            {
                this.ClearResults();
                this.studentDataProvider = value;
                this.Clear();
                try
                {
                    this.studentListBox.DataSource = value?.GetData();
                } catch(Exception e)
                {
                    MessageBox.Show(e.Message, "Data Provider", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Adds a birth year search resutls to the results listbox.
        /// </summary>
        /// <param name="value"></param>
        private void AddResults(String value)
        {
            this.AddResults(this.FindStudentForYear(value));
        }

        /// <summary>
        /// Adds the student's name to the results listbox
        /// </summary>
        /// <param name="results"></param>
        private void AddResults(StudentInfo[] results)
        {
            if(results.Length == 0)
            {
                this.birthYearResultListBox.Items.Add("No Students found");
                return;
            }
            foreach(StudentInfo s in results)
            {
                this.birthYearResultListBox.Items.Add(s.Name);
            }
        }

        /// <summary>
        /// Clears the results listbox
        /// </summary>
        private void ClearResults()
        {
            this.birthYearResultListBox.Items.Clear();
        }

        /// <summary>
        /// Clears the form
        /// </summary>
        private void Clear()
        {
            this.birthYearField.Text = String.Empty;
            this.ClearResults();
            this.studentListBox.DataSource = new StudentInfo[] { };
        }

        /// <summary>
        /// Finds the students for a specified birth year from the student listbox datasource.
        /// 
        /// If the string argument fails to parse this method will show a MessageBox; when
        /// parsed it will delegate to MainForm.FindStudentForYear(int year) method
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private StudentInfo[] FindStudentForYear(string value)
        {
            //Try parsing the value
            if (!int.TryParse(value, out int year))
            {
                MessageBox.Show("Please input a valid year!", "Invalid Birth Year", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.birthYearField.SelectAll();
            }
            return this.FindStudentForYear(year);
        }

        /// <summary>
        /// Finds the student for a specified birth year from the student listbox's datasoruce.
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        private StudentInfo[] FindStudentForYear(int year)
        {
            return this.studentDataProvider.FindStudentByBirthYear(year);
        }

        /// <summary>
        /// EventHandler for when the text changes in the birth year search field.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BirthYear_TextChanged(object sender, EventArgs e)
        {
            this.ClearResults(); // Clear any existing results
            String value = this.birthYearField.Text; // get the TextField changed value
            if(value != String.Empty)
            {
                this.AddResults(value);
            }
            
        }

        /// <summary>
        /// EventHandler for to handle when the clear button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearButton_Click(object sender, EventArgs e)
        {
            this.Clear();
        }

        /// <summary>
        /// EventHandler for when the exit button is clicked or
        /// the exit file menu item is chosen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// EventHandler for when the open file menu item is chosen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenFileMenuItem_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.DataProvider = this.openFileDialog.DataProvider;
            }
        }
        /// <summary>
        /// EventHandler for when the open url menu item is chosen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenUrlMenuItem_Click(object sender, EventArgs e)
        {
            
            if(this.uriDialog.ShowDialog() == DialogResult.OK)
            {
                this.DataProvider = this.uriDialog.DataProvider;
            }
        }
    }
}
