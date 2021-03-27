using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project6
{
    /// <summary>
    /// Filesystem implementation of the IDataProvider
    /// </summary>
    public class FileDataProvider : IDataProvider<String>
    {
        /// <summary>
        /// The file path to read
        /// </summary>
        private String filename;
        /// <summary>
        /// The files data one line per Item
        /// </summary>
        private List<String> data;

        /// <summary>
        /// Static lazy OpenFileDialog
        /// </summary>
        private static OpenFileDialog dialog;

        /// <summary>
        /// EventHander for when the filename changes. 
        /// </summary>
        public event EventHandler FileNameChanged;

        /// <summary>
        /// Default construct for FileDataProvider
        /// </summary>
        public FileDataProvider() : this(String.Empty) { }

        /// <summary>
        /// Construct a IDataProvider which read data from a file.
        /// </summary>
        /// <param name="filename"></param>
        public FileDataProvider(String filename)
        {
            this.filename = filename;
        }

        /// <summary>
        /// Readonly filename property
        /// </summary>
        public String Filename
        {
            get => this.filename;
            set
            {
                this.filename = value;
                this.data = null;
                this.FileNameChanged(this, EventArgs.Empty);
            }
        }
        /// <summary>
        /// Utility to set the Filename with input from an 
        /// OpenFielDialog. 
        /// </summary>
        public void SetPath()
        {
            if(null == dialog)
            {
                dialog = new OpenFileDialog();
            }
            dialog.InitialDirectory = Application.StartupPath;
            dialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.Filename = dialog.FileName;
            }
        }

        /// <summary>
        /// Lazy loads and gets the data from the file.
        /// 
        /// Each line of the file is read as a single item of a list <see cref="File.ReadAllLines(string)"/> 
        /// for more details.
        /// 
        ///     
        /// </summary>
        public List<String> Data
        {
            get
            {
                if (null == this.data)
                {
                    this.data = new List<String>(File.ReadAllLines(this.filename));
                }
                return this.data;
            }
        }
    }
}
