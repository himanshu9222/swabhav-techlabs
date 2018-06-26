using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DogDoorApp
{
    class Remote
    {
        private DogDoor _door;

        public Remote(DogDoor door)
        {
            _door = door;
        }

        public void PressButton()
        {
            Console.WriteLine("Pressing the remote control button...");
            if (_door.isOpen())
                _door.Close();
            else
                _door.Open();
        }
    }
}
