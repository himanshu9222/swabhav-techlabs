using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Employee_max_Salary_App
{
    class FileLoader : ILoadable
    {
        string text;
        public string LoadFile()
        {
            var fileStream = new FileStream(@"dataFile.txt", FileMode.Open, FileAccess.Read);
            var streamReader = new StreamReader(fileStream, Encoding.UTF8);
            string line;
            while ((line = streamReader.ReadLine()) != null)
            {
                text = text + line + "/";
            }
            return text;
        }
    }
}
