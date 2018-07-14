using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleEFConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create("Name","Description");
            //Display();
            //Update("himanshu");
            //Delete("prasad");
            Console.ReadKey();
        }

        public static void Delete(string name)
        {
            MumbaiDbContext db = new MumbaiDbContext();
            var student = db.Students.SingleOrDefault(m => m.Name == name);
            db.Students.Remove(student);
            Console.WriteLine("Deleted");
            db.SaveChanges();
        }

        public static void Update(string name)
        {
            MumbaiDbContext db = new MumbaiDbContext();
            var student = db.Students.SingleOrDefault(m => m.Name == name);
            student.Description = "Vasai";
            Console.WriteLine("Updated");
            db.SaveChanges();
        }

        public static void Display()
        {
            MumbaiDbContext db = new MumbaiDbContext();
            foreach (var student in db.Students)
            {
                Console.WriteLine("Id=" + student.Id+" Name="+student.Name+" Description="+student.Description);
            }
        }

        public static void Create(string name,string description)
        {
            Student s1 = new Student();
            s1.Name = name;
            s1.Description = description;
            MumbaiDbContext db = new MumbaiDbContext();
            db.Students.Add(s1);
            db.SaveChanges();
        }
    }
}
