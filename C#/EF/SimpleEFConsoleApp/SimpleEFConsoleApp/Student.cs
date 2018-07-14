using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleEFConsoleApp
{
    public class Student
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        public Student()
        {
            Id = Guid.NewGuid();
        }
    }
}
