using System.ComponentModel.DataAnnotations;

namespace Expression_App
{
    public class Contact
    {
        [Key]
        public string Name { get; set; }
        public string Number { get; set; }
        public string Location { get; set; }

        public Contact(string name,string number,string location)
        {
            Name = name;
            Number = number;
            Location = location;
        }
    }
}
