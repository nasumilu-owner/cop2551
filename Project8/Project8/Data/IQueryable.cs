using System;

namespace Project8.Data
{
    public interface IQueryable
    {

        StudentInfo[] FindStudentByBirthYear(int birthYear);
    }
}
