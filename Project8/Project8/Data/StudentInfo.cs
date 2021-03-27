using System;
using System.ComponentModel;

namespace Project8.Data
{
    /// <summary>
    /// This the data model for a StudentInfo
    /// </summary>
    public class StudentInfo : INotifyPropertyChanged
    {
        /// <summary>
        /// StudentInfo's first name
        /// </summary>
        private string _name;
        /// <summary>
        /// StudentInfo's birth year
        /// </summary>
        private int _year;

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Default constructor for a student with a null first name
        /// and -1 birth year
        /// </summary>
        public StudentInfo() : this(null, -1) { }

        /// <summary>
        /// Constructs a student with a first name and birth year
        /// </summary>
        /// <param name="name"></param>
        /// <param name="year"></param>
        public StudentInfo(string name, int year)
        {
            this._name = name;
            this._year = year;
        }

        /// <summary>
        /// The StudentInfo's first name
        /// </summary>
        public String Name
        {
            get => this._name;
            set
            {
                this._name = value;
                this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
            }
        }

        /// <summary>
        /// The StudentInfo's birth year
        /// </summary>
        public int Year
        {
            get => this._year;
            set
            {
                this._year = value;
                this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Year"));
            }
        }

        /// <summary>
        /// String representation of a StudentInfo
        /// 
        /// The StudentInfo's first name and birth year is tab delinated as
        /// [FIRST NAME]    [BIRTH YEAR]
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{this._name}\t{this._year}";
        }
    }
}
