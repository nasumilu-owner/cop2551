using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project8.Data
{
    /// <summary>
    /// Very basic abstract layer which provides a buffer for student data and which is found at a path. 
    /// Sub-classes are responsible for loading the student data by implmenting a GetData method
    /// for a give Path.
    /// 
    /// Examples:
    /// <list type="table">
    ///     <item>
    ///         <term>./Names.text</term>
    ///         <description>Local file with the name Names.txt in the current working directory</description>
    ///     </item>
    ///     <item>
    ///         <term>https://some.com/Names.txt</term>
    ///         <description>Fully-qualified domain name (FQDN)</description>
    ///     </item>
    ///  </list>
    /// 
    /// Note: The IQuery interface is an adhoc interface to accomidate the progject specifications. 
    /// My first version read the data into an array of Student objects. That is now called StudentInfo
    /// so I can recreate the Student object to hold two parallel arrays with the data. That data will then
    /// be used to implement the IStudentDataProvider.GetData() method. 
    /// 
    /// </summary>
    public abstract class AbstractStudentDataProvider : IStudentDataProvider
    { 
        /// <summary>
        /// Notifies when a property value has changed
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Notifies when a property value is about to change.
        /// </summary>
        public event PropertyChangingEventHandler PropertyChanging;

        /// <summary>
        /// The data providers path
        /// </summary>
        private String _path;

        /// <summary>
        /// Default construct 
        /// </summary>
        public AbstractStudentDataProvider() { }

        /// <summary>
        /// Constructs a IStudentDataProvider whos student data is found at argument
        /// path.
        /// </summary>
        /// <param name="path"></param>
        public AbstractStudentDataProvider(String path)
        {
            this._path = path;
        }

        /// <summary>
        /// Get/Set the path to the student data.
        /// </summary>
        public string Path 
        {
            get => this._path;
            set
            {
                this.firePropertyChanging("Path");
                this._path = value;
                this.firePropertyChanged("Path");
            }
        }

        /// <summary>
        /// Dispatches a PropertyChangingEvent for argument <code>property</code>
        /// </summary>
        /// <param name="property"></param>
        protected void firePropertyChanging(String property)
        {
            this.PropertyChanging?.Invoke(this, new PropertyChangingEventArgs(property));
        }

        /// <summary>
        /// Dispatches a PropertyChangedEvent for arugment <code>property</code>
        /// </summary>
        /// <param name="property"></param>
        protected void firePropertyChanged(String property)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }

        public abstract StudentInfo[] GetData();

        public StudentInfo[] FindStudentByBirthYear(int birthYear)
        {
            return this.GetData().Where<StudentInfo>(std => std.Year == birthYear).ToArray();
        }
    }
}
