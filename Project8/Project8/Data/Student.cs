using System;
using System.IO;
using System.ComponentModel;
using System.Text.RegularExpressions;

namespace Project8.Data
{
    /// <summary>
    /// Student data file which contains the parallel array of student data to meet the project requirements.
    /// </summary>
    public class Student : AbstractStudentDataProvider
    {
        /// <summary>
        /// The maximum allowed buffer size of student data
        /// </summary>
        private int _buffer;
        private readonly String[] _names;
        private readonly int[] _years;

        //flag to indicate that the data has been read
        private bool isRead = false;
   
        /// <summary>
        /// Defualt construct with no file path and a buffer of 30 students.
        /// </summary>
        public Student() : this(null) { }

        /// <summary>
        /// Constructs a Student with it's student data stored in a text file at property
        /// Path and a buffer size of 30
        /// </summary>
        /// <param name="path"></param>
        public Student(String path) : this(path, 30) { }

        /// <summary>
        /// Constructs a Student which is a file base IStudentDataProvider with
        /// its Student data stored in a text file at property Path and a maximum
        /// buffer size.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="buffer"></param>
        public Student(String path, int buffer) : base(path) {
            this._buffer = buffer;
            this._names = new String[this._buffer];
            this._years = new int[this._buffer];
        }

        /// <summary>
        /// Get the allowed buffer length
        /// </summary>
        public int Buffer
        {
            get => this._buffer;
            set
            {
                this.firePropertyChanging("Buffer");
                this._buffer = value;
                this.firePropertyChanged("Buffer");
            }
        }

        /// <summary>
        /// Gets the Student's names
        /// </summary>
        public String[] Names
        {
            get
            {
                if(!this.isRead)
                {
                    this.ReadFileContents();
                }
                return this._names;
            }
        }

        /// <summary>
        /// Gets the Student's birth years
        /// </summary>
        public int[] Years
        {
            get
            {
                if(!this.isRead)
                {
                    this.ReadFileContents();
                }
                return this._years;
            }
        }

        /// <summary>
        /// Reads the contents of file Student.Path one line at a time
        /// tokenizing each by any number of whitespaces. The first token must be the students name
        /// and the second the students birth year. 
        /// 
        /// This method is unable to load a student's first name and birth date if their first name contains
        /// any whitespaces. To accomidate such a situation the regex pattern would need to be altered to match
        /// /[a-z]*/i and a second to match only numbers /\d{4}/g but this has its own set of issues too. 
        /// 
        /// If to many tokens or fail parsing the birth year an IOException is thrown
        /// with an appropriate message
        /// </summary>
        private void ReadFileContents()
        {
            int i = 0;
            Regex regex = new Regex(@"\s+"); // Tokenize by any number of whitespaces
            StreamReader reader = File.OpenText(this.Path);
            String line;
            try
            {
                while (i < this.Buffer && (line = reader.ReadLine()) != null)
                {
                    String[] data = regex.Split(line);
                    if (data.Length != 2)
                    {
                        throw new IOException($"Malformed file on line {i + 1}: Require only two elements first name and birth year, found {data.Length}!");
                    }

                    if (!int.TryParse(data[1], out int dobYear))
                    {
                        throw new IOException($"Malformed file on line {i + 1}: Unable to read or missing birth year!");
                    }
                    this._names[i] = data[0];
                    this._years[i] = dobYear;
                    i++;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.isRead = true;
                reader.Close();
            }
        }


        /// <summary>
        /// Method that uses the parallel arrays to construct an array of StudentInfo objects.
        /// This is some performance lost because this is created each time the method is called. 
        /// I had approached this project differently and need to modify it to include the two
        /// parallel arrays. 
        /// </summary>
        public override StudentInfo[] GetData()
        {
            if(!this.isRead)
            {
                this.ReadFileContents();
            }
            StudentInfo[] students = new StudentInfo[this.Buffer];
            for(int i=0; i<this._buffer;i++)
            {
                students[i] = new StudentInfo(name: this._names[i], year: this._years[i]);
            }
            return students;
        }
    }
}
