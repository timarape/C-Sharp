using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks.Sources;

namespace WorkingWithClasses
{
    public class Student
    {
        private string _firstName;
        private string _lastName;


        public Student(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }
       
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }


        public string AttendClass(string moduleName)
        {
            return string.Concat("Attended ",moduleName);
        }
    }
}
