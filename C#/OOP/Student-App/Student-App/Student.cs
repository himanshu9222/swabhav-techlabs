using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Student_App
{
    class Student
    {
        private int _rollNo;
        private string _name;
        private float _cgpa;
        private static int count;

        public Student(int rollNO,string name,float cgpa)
        {
            _rollNo = rollNO;
            _name = name;
            _cgpa = cgpa;
            count += 1;
        }

        static Student(){
            count = 0;
        }

        public static int Count {
            get
            {
                return count;
            }
        }
        

        public int RollNo
        {
            get
            {
                return _rollNo;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public float Cgpa
        {
            get
            {
                return _cgpa;
            }
            set
            {
                if (value < 10 && value > 1)
                    _cgpa = value;
            }
        }
    }
}
