using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StructureExample
{

    class Program
    {
        static void Main(string[] args)
        {
            Books Book1 = new Books();   
            Books Book2 = new Books();   

            Book1.getValues("C Programming",
            "XYZ", "C Programming Tutorial", 6495407);

            Book2.getValues("Java",
            "ABC", "Java Tutorial", 6495700);

            Book1.display();
            Book2.display();

            Console.ReadKey();
        }
    }

    struct Books
    {
        private string _title;
        private string _author;
        private string _subject;
        private int _book_id;

        public void getValues(string t, string a, string s, int id)
        {
            _title = t;
            _author = a;
            _subject = s;
            _book_id = id;
        }

        public void display()
        {
            Console.WriteLine("Title : "+ _title);
            Console.WriteLine("Author : "+ _author);
            Console.WriteLine("Subject : "+ _subject);
            Console.WriteLine("Book_id : "+ _book_id+"\n");
        }
    };  
}
