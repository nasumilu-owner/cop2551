using System;
using System.ComponentModel;

namespace Project8.Data
{
    /// <summary>
    /// Service interface that provides student data
    /// </summary>
    public interface IStudentDataProvider : INotifyPropertyChanged, INotifyPropertyChanging, IQueryable
    {
        /// <summary>
        /// The loads  the student data into an array of StudentInfo objects
        /// </summary>
        StudentInfo[] GetData();

        /// <summary>
        /// The Path to the data
        /// </summary>
        String Path
        {
            get; set;
        }
    }
}
