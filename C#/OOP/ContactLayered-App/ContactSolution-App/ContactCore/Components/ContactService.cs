using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ContactCore.Components
{
    public class ContactService
    {
        BinaryFormatter formatter = new BinaryFormatter();
        public void SerializeContact(List<Contact> list)
        {
            //new FileStream("Example.txt",FileMode.OpenOrCreate)
            Stream stream = File.OpenWrite("Example.txt");
            formatter.Serialize(stream, list);
            stream.Flush();
            stream.Close();
            stream.Dispose();
        }

        public List<Contact> DeserializeContact()
        {
            Stream stream = File.Open("Example.txt", FileMode.Open);
            List<Contact> getList = (List<Contact>)formatter.Deserialize(stream);
            stream.Flush();
            stream.Close();
            stream.Dispose();
            return getList;
        }
    }
}
