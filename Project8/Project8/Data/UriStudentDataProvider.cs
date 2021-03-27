using System;
using System.Net;
using System.IO;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Project8.Data
{
    /// <summary>
    /// My AbstractStudentDataProvider wouldn't be very abstract if I didn't provide
    /// additional implementations. So this is another file based adapater (sub-class)
    /// that retrieves the student data from an HTTP request. 
    /// <br/><br/>
    /// I stored the Names.txt file on my home.ite.sfcollege.edu for testting so if you'd
    /// like to try out this IStudentDataProvider point the File->Open to 
    /// <br/>
    /// http://home.ite.sfcollege.edu/~michael.lucas/cop2551/Names.txt
    /// 
    /// </summary>
    public class UriStudentDataProvider : AbstractStudentDataProvider
    {
        private int _timeout;
        private long _bytes;

        /// <summary>
        /// Default construct that has a null path, allowes a maximum file size of 
        /// 1 MB, and times out after 3 seconds.
        /// </summary>
        public UriStudentDataProvider() : this(null, 1048576, 30000) { }

        /// <summary>
        /// Construct that has a path, allows a maximum file size of 1 MB, 
        /// and times out after 3 seconds.
        /// </summary>
        /// <param name="path"></param>
        public UriStudentDataProvider(String path) : this(path, 1048576, 30000) { }

        /// <summary>
        /// Allows the construct of an IStudentDataProvider which obtains the data 
        /// from a url.
        /// 
        /// </summary>
        /// <param name="path"></param>
        /// <param name="bytes"></param>
        /// <param name="timeout"></param>
        public UriStudentDataProvider(String path, long bytes, int timeout) : base (path)
        {
            this._bytes = bytes;
            this._timeout = timeout;
        }

        /// <summary>
        /// Get/Set the http request timeout
        /// </summary>
        public int Timeout
        {
            get => this._timeout;
            set
            {
                this.firePropertyChanging("Timeout");
                this._timeout = value;
                this.firePropertyChanged("Timeout");
            }
        }

        /// <summary>
        /// Sets the Path from a Uri object
        /// Gets a Uri from the Path
        /// </summary>
        public Uri Uri
        {
            get => this.Path != null ? new Uri(this.Path) : null;
            set => this.Path = value?.AbsoluteUri;
        }

        /// <summary>
        /// Get/Set the maximum allowed bytes
        /// </summary>
        public long MaxBytesAllowed
        {
            get => this._bytes;
            set
            {
                this.firePropertyChanging("MaxBytesAllowed");
                this._bytes = value == 0  ? 3000 : value;
                this.firePropertyChanged("MaxBytesAllowed");
            }
        }


        /// <summary>
        /// Obtains the data from Path via WebRequest
        /// 
        /// <see cref="https://docs.microsoft.com/en-us/dotnet/api/system.net.webrequest?view=net-5.0"/>
        /// </summary>
        /// <returns></returns>
        public override StudentInfo[] GetData()
        {
            WebRequest request = WebRequest.Create(this.Uri);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
           
            // Response Status is anything but OK - Error
            if(response.StatusCode != HttpStatusCode.OK)
            {
                throw new IOException($"{response.StatusCode}: {response.StatusDescription}!");
            }

            // Check to make sure the file isn't giganormous
            if (long.TryParse(response.Headers.Get("Content-Length"), out long size)
                && size > this.MaxBytesAllowed )
            {
                throw new IOException($"The response content exceeds the maximum nuber of bytes allowed by {size - this.MaxBytesAllowed}!");
            }

            StreamReader reader = new StreamReader(response.GetResponseStream());
            List<StudentInfo> students = new List<StudentInfo>();
            Regex regex = new Regex(@"\s+"); // Tokenize by any number of whitespaces
            String line;
            int i = 0;
            while((line = reader.ReadLine()) != null)
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
                students.Add(new StudentInfo(data[0], dobYear));
                i++;
            }

            return students.ToArray();
        }
    }
}
