using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace File_App
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo d = new DirectoryInfo(@"G:\");
            IEnumerable<FileInfo> files = d.GetFiles();

            var sort = from file in files
                       let len = file.Length
                       orderby len descending
                       select file;

            var sortByFunction = files.OrderByDescending(f => f.Length);
            
            Console.WriteLine("After Sorting");
            foreach (FileInfo file in sortByFunction)
            {
                Console.WriteLine(file.Name);
            }
            
            Console.ReadKey();
        }
    }
}
