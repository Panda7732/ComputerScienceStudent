using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Computer_Science_Student
{
    abstract class Student
    {
        //fields
        private string _name;
        private string _id;

        //constructor
        public Student(string name,string id)
        {
            _name = name;
            _id = id;
        }

        //Name property
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        //RequiredHours property (abstract)
        public abstract double RequiredHours
        {
            get;
        }


    }
}
