using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DogDoorApp
{
    class BarkRecognizer
    {
        private DogDoor _door;

        public BarkRecognizer(DogDoor door)
        {
            _door = door;
        }

        public void Recognize(Bark bark)
        {
            Console.WriteLine("Bark Recognizer : Heard a '" + bark.Sound + "'");
            List<Bark> allowedBarks = _door.GetAllowedBark;
            IEnumerator<Bark> iterator = allowedBarks.GetEnumerator();
            while (iterator.MoveNext())
            {
                Bark allowedBark = (Bark)iterator.Current;
                if (allowedBark.Equals(bark))
                {
                    _door.Open();
                    return;
                }
            }
            Console.WriteLine("Dog is not allowed");
        }
    }
}
