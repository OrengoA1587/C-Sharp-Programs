using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformUI
{
    public class Student
    {
        private double _GPA;
        private string _name;
        private string _semester;

        //public Student(double gpa, string name, string semester)
        //{
        //    GPA = gpa;
        //    Name = name;
        //    Semester = semester;
        //}

        public double GPA
        {
            get
            {
                return _GPA;
            }
            set
            {
                _GPA = value;
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public string Semester
        {
            get
            {
                return _semester;
            }
            set
            {
                Semester = value;
            }
        }
    }
}
