using System.Windows.Forms;

namespace Project8.Data.UI
{
    /// <summary>
    /// Service interface which creates a IStudentDataProvider
    /// from a Dialog
    /// </summary>
    public interface IStudentDataProviderFactory
    {

        /// <summary>
        /// Getter/Setter for the IStudentDataProvider
        /// </summary>
        IStudentDataProvider DataProvider
        {
            get;set;
        }

        /// <summary>
        /// Opens the Dialog for input.
        /// 
        /// DialogResult.OK indicates that the IStudentDataProvider was 
        /// created successfully and is ready to load data.
        /// 
        /// DialogResult.Cancle indicates that the user canceled the 
        /// creation of the IStudentDataProvider
        /// </summary>
        /// <returns></returns>
        DialogResult ShowDialog();
    }
}
