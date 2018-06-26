using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Student_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student(101,"Himanshu",7.55f);
            print(s1);
            s1.Cgpa = 8.99f;
            print(s1);
            s1.Cgpa = 11.5f;
            Console.WriteLine(s1.Cgpa);
            
            Student s2 = new Student(102, "Anshu", 6.99f);
            print(s2);
            Student s3 = new Student(101, "Parth", 4.55f);
            print(s3);
            
            Console.WriteLine("Count is "+Student.Count);
            Console.ReadKey();

        }

        static void print(Student s){
            Console.WriteLine("Name = "+s.Name+" RollNo = "+s.RollNo + " CGPA = "+s.Cgpa);
            Console.WriteLine();
        }
    }
}
